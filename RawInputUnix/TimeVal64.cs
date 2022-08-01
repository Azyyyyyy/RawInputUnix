using System.Runtime.InteropServices;

namespace RawInputUnix;

[StructLayout(LayoutKind.Explicit)]
public struct TimeVal64
{
    [FieldOffset(0)] public int TvSec;

    [FieldOffset(8)] public int TvIsec;
}