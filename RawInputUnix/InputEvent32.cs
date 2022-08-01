using System.Runtime.InteropServices;

namespace RawInputUnix;

//TODO: Check this on a 32-bit device
[StructLayout(LayoutKind.Explicit)]
public struct InputEvent32
{
    [FieldOffset(0)] public TimeVal32 Time;

    [FieldOffset(8)] public EventType Type;

    [FieldOffset(10)] public ushort Code;

    [FieldOffset(12)] public ushort Value;
}