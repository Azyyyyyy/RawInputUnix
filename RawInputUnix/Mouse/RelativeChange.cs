namespace RawInputUnix;

public enum RelativeChange : ushort
{
    X = 0x00,
    Y = 0x01,
    Z = 0x02,
    Rx = 0x03,
    Ry = 0x04,
    Rz = 0x05,
    HWheel = 0x06,
    Dial = 0x07,
    Wheel = 0x08,
    Misc = 0x09,
    
    Reserved = 0x0a,
    WheelHiRes = 0x0b,
    HWheelHiRes = 0x0c,
    Max = 0x0f,
    Cnt = (Max + 1),
}