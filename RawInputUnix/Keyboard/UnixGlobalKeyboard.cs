using static RawInputUnix.KeyTable;

namespace RawInputUnix;

//Sources used to create everything needed here :)
//https://www.kernel.org/doc/Documentation/input/input.txt
//https://github.com/kernc/logkeys/blob/master/src/logkeys.cc
//https://stackoverflow.com/questions/2384/read-binary-file-into-a-struct
//https://ftp.gnu.org/old-gnu/Manuals/glibc-2.2.3/html_node/libc_418.html
//https://elixir.bootlin.com/linux/latest/source/include/uapi/linux/input-event-codes.h#L39
public class UnixGlobalKeyboard
{
    public static string? GetKeyboardPath() => UnixGlobalCommon.GetDevicePath("-B8 -E 'KEY=.*e$'", "keyboard");

    public static Dictionary<string, int>? GetKeyboardPaths() =>
        UnixGlobalCommon.GetDevicePaths("-B8 -E 'KEY=.*e$'", "keyboard");

    public static ValueTask GetKeyboardEvents(string keyboardPath,
        Action<KeyState>? processKey, CancellationToken cancellationToken) =>
        UnixGlobalCommon.ProcessDeviceEvents(keyboardPath, ProcessEvent, processKey, cancellationToken);

    /// <summary>
    /// Processes the InputEvent
    /// </summary>
    /// <param name="state">KeyState to write to</param>
    /// <param name="inputEvent">Event to handle</param>
    /// <returns>If we processed this event or if the event wasn't something to process</returns>
    private static bool ProcessEvent(KeyState state, InputEvent64 inputEvent)
    {
        if (inputEvent.Type != EventType.Key)
            return false; // keyboard events are always of type EV_KEY

        var scanCode =
            inputEvent.Code; // the key code of the pressed key (some codes are from "scan code set 1", some are different (see <linux/input.h>)

        state.RepeatEnd = false;
        switch ((State)inputEvent.Value)
        {
            case State.Repeat:
                state.Repeats++;
                return true;
            case State.Break:
                switch ((Key)scanCode)
                {
                    case Key.LeftShift or Key.RightShift:
                        state.ShiftInEffect = false;
                        return true;
                    case Key.RightAlt:
                        state.AltGrInEffect = false;
                        return true;
                    case Key.LeftAlt:
                        state.AltInEffect = false;
                        return true;
                    case Key.LeftCtrl or Key.RightCtrl:
                        state.CtrlInEffect = false;
                        return true;
                }

                if (IsFuncKey(scanCode))
                {
                    var func = FuncKeys[ToFuncKeysIndex(scanCode)];
                    if (func is "<LMeta>" or "<RMeta>")
                    {
                        state.IsMetaInEffect = false;
                        return true;
                    }
                }

                state.RepeatEnd = state.Repeats > 0;
                state.IsDown = GetCharFromScanCode(scanCode, state, out _) != state.Key && state.IsDown;
                return true;
        }

        state.Repeats = 0;

        state.ScancodeOk = scanCode < CharOrFuncLength;
        if (!state.ScancodeOk)
            return true;

        state.Key = '\0';

        if (inputEvent.Value != (ushort)State.Make)
            return false;

        state.IsDown = true;
        switch ((Key)scanCode)
        {
            case Key.Capslock:
                state.CapslockInEffect = !state.CapslockInEffect;
                break;
            case Key.LeftShift:
            case Key.RightShift:
                state.ShiftInEffect = true;
                break;
            case Key.RightAlt:
                state.AltGrInEffect = true;
                break;
            case Key.LeftAlt:
                state.AltInEffect = true;
                break;
            case Key.LeftCtrl:
            case Key.RightCtrl:
                state.CtrlInEffect = true;
                break;
            default:
                state.Key = GetCharFromScanCode(scanCode, state, out var isCharKey);

                if (!isCharKey)
                {
                    var func = FuncKeys[ToFuncKeysIndex(scanCode)];
                    switch (func)
                    {
                        case "<RMeta>" or "<LMeta>":
                            state.IsMetaInEffect = true;
                            break;
                    }
                }
                break;
        }

        return true;
    }

    private static char GetCharFromScanCode(ushort scanCode, KeyState state, out bool isCharKey)
    {
        if (isCharKey = IsCharKey(scanCode))
        {
            char wch;
            if (state.AltGrInEffect)
            {
                wch = AltGrKeys[ToCharKeysIndex(scanCode)];
                if (wch == '\0')
                    wch = state.ShiftInEffect
                        ? ShiftKeys[ToCharKeysIndex(scanCode)]
                        : CharKeys[ToCharKeysIndex(scanCode)];
            }
            else if (state.CapslockInEffect && char.IsLetter(CharKeys[ToCharKeysIndex(scanCode)]))
            {
                // only bother with capslock if alpha
                wch = state.ShiftInEffect ? CharKeys[ToCharKeysIndex(scanCode)] : ShiftKeys[ToCharKeysIndex(scanCode)];
                if (wch == '\0')
                    wch = CharKeys[ToCharKeysIndex(scanCode)];
            }
            else if (state.ShiftInEffect)
            {
                wch = ShiftKeys[ToCharKeysIndex(scanCode)];
                if (wch == '\0')
                    wch = CharKeys[ToCharKeysIndex(scanCode)];
            }
            else // neither altgr nor shift are effective, this is a normal char
            {
                wch = CharKeys[ToCharKeysIndex(scanCode)];
            }

            return wch;
        }
                
        //TODO: At some point report the func's as well
        //We want to report some func's 
        var func = FuncKeys[ToFuncKeysIndex(scanCode)];
        switch (func)
        {
            case "<BckSp>":
                return '\b';
            case "<Tab>":
                return '\t';
            case "<Enter>":
                return '\n';
            case "<Space>":
                return ' ';
        }

        return '\0';
    }
}