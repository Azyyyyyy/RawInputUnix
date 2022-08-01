using System.Text;
using RawInputUnix.States;

namespace RawInputUnix;

public class KeyState : DeviceState
{
    public char Key { get; set; }

    public uint Repeats
    {
        get;
        set;
    } // count_repeats differs from the actual number of repeated characters! afaik, only the OS knows how these two values are related (by respecting configured repeat speed and delay)

    public bool IsDown { get; set; }

    public bool RepeatEnd { get; set; }
    public bool ScancodeOk { get; set; }
    public bool CapslockInEffect { get; set; }
    public bool ShiftInEffect { get; set; }
    public bool AltGrInEffect { get; set; }
    public bool AltInEffect { get; set; }
    public bool IsMetaInEffect { get; set; }
    public bool CtrlInEffect { get; set; } // used for identifying Ctrl+C / Ctrl+D
}