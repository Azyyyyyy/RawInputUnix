using System.Runtime.InteropServices;

namespace RawInputUnix;

[StructLayout(LayoutKind.Explicit)]
public struct InputEvent64
{
    [FieldOffset(0)] public TimeVal64 Time;

    [FieldOffset(16)] public EventType Type;

    [FieldOffset(18)] public ushort Code;

    [FieldOffset(20)] public ushort Value;
}