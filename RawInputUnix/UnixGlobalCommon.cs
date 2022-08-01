using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using RawInputUnix.States;

//TODO: Add trackpad support and touchscreen support (look into other input devices on linux)
namespace RawInputUnix;

/*The input protocol is a stateful protocol. Events are emitted only when values of event codes have changed. However,
 the state is maintained within the Linux input subsystem; drivers do not need to maintain the state and may attempt to 
 emit unchanged values without harm. Userspace may obtain the current state of event code values using the EVIOCG* ioctls 
 defined in linux/input.h. The event reports supported by a device are also provided by sysfs in class/input/event<X>/device/capabilities/, 
 and the properties of a device are provided in class/input/event<X>/device/properties.*/
public class UnixGlobalCommon
{
    //TODO: Make this editable
    private const string EXE_GREP = "/bin/grep";
    private const string EXE_SHELL = "/bin/bash";

    private const string INPUT_EVENT_PATH = "/dev/input/";

    //TODO: Check with mouse plugged in (Keyboard event)
    public static string? GetDevicePath(string args, string deviceName)
    {
        return GetDevicePaths(args, deviceName)?.OrderByDescending(x => x.Value).First().Key;
    }

    //Main help for this is logkeys project
    public static Dictionary<string, int>? GetDevicePaths(string args, string deviceName)
    {
        //Run command to get inputs
        var process = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = EXE_SHELL,
                Arguments = $"-c \"{EXE_GREP} {args} /proc/bus/input/devices | {EXE_GREP} -E 'Name|Handlers|KEY' \"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            }
        };

        process.Start();
        process.WaitForExit();
        var lines = process.StandardOutput.ReadToEnd();

        if (string.IsNullOrWhiteSpace(lines))
            //Didn't get any input from grep....
            return null;

        var devices = new Dictionary<string, int>();

        var lineType = 0;
        var score = 0;
        var input = "";
        
        //Get devices from command
        foreach (var line in lines.Split())
        {
            //Generate score based on device name
            if (lineType == 0)
            {
                if (line.ToLower().IndexOf(deviceName, StringComparison.Ordinal) != -1) 
                    score += 100;
            }
            //Add the event handler
            else if (lineType == 1)
            {
                var index = line.IndexOf("event", StringComparison.Ordinal);
                if (index != -1 && int.TryParse(line[(index + 5)..], out var eventIndex))
                    input = $"{INPUT_EVENT_PATH}event{eventIndex}";
            }
            //Generate score based on size of key bitmask
            else if (lineType == 2)
            {
                var index = line.IndexOf('=');
                score += index == -1 ? 0 : line.Length - (index + 1);

                if (!string.IsNullOrWhiteSpace(input)) 
                    devices.Add(input, score);

                score = 0;
                input = "";
            }

            lineType++;
            lineType %= 3;
        }

        return !devices.Any() ? null : devices;
    }

    public static async ValueTask ProcessDeviceEvents<TState>(string devicePath, 
        Func<TState, InputEvent64, bool> processDevice, Action<TState>? processedDevice, CancellationToken cancellationToken)
        where TState : DeviceState, new()
    {
        var count = Environment.Is64BitOperatingSystem ? 24 : 16;
        var state = new TState();

        //Open device event
        await using var stream = File.OpenRead(devicePath);
        using var reader = new BinaryReader(stream);

        InputEvent64 ipEvent;
        while (!cancellationToken.IsCancellationRequested)
        {
            GCHandle handle = default;
            var freedHandle = false;
            try
            {
                var readBuffer = reader.ReadBytes(count);

                handle = GCHandle.Alloc(readBuffer, GCHandleType.Pinned);
                freedHandle = false;
                ipEvent = Marshal.PtrToStructure<InputEvent64>(handle.AddrOfPinnedObject());
                handle.Free();
                freedHandle = true;

                var processed = processDevice(state, ipEvent);
                if (processed)
                {
                    state.LastEventTimeStamp = (ulong)ipEvent.Time.TvSec;
                    processedDevice?.Invoke(state);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                if (!freedHandle)
                {
                    handle.Free();
                }
            }
        }
    }
}