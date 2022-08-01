using System.Runtime.InteropServices;

namespace RawInputUnix;

[StructLayout(LayoutKind.Explicit)]
public struct TimeVal32
{
    [FieldOffset(0)] public int TvSec;

    [FieldOffset(4)] public int TvUsec;
}