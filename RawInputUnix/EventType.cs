namespace RawInputUnix;

public enum EventType : ushort
{
    /// <summary>
    /// Used as markers to separate events. Events may be separated in time or in space, such as with the multitouch protocol.
    /// </summary>
    Syn = 0x00,
    /// <summary>
    /// Used to describe state changes of keyboards, buttons, or other key-like devices.
    /// </summary>
    Key = 0x01,
    /// <summary>
    /// Used to describe relative axis value changes, e.g. moving the mouse 5 units to the left.
    /// </summary>
    Rel = 0x02,
    /// <summary>
    /// Used to describe absolute axis value changes, e.g. describing the coordinates of a touch on a touchscreen.
    /// </summary>
    Abs = 0x03,
    /// <summary>
    /// Used to describe miscellaneous input data that do not fit into other types.
    /// </summary>
    Msc = 0x04,
    /// <summary>
    /// Used to describe binary state input switches.
    /// </summary>
    Sw = 0x05,
    /// <summary>
    /// Used to turn LEDs on devices on and off.
    /// </summary>
    Led = 0x11,
    /// <summary>
    /// Used to output sound to devices.
    /// </summary>
    Snd = 0x12,
    /// <summary>
    /// Used for auto-repeating devices.
    /// </summary>
    Rep = 0x14,
    /// <summary>
    /// Used to send force feedback commands to an input device.
    /// </summary>
    Ff = 0x15,
    /// <summary>
    /// A special type for power button and switch input.
    /// </summary>
    Pwr = 0x16,
    /// <summary>
    /// Used to receive force feedback device status.
    /// </summary>
    FfStatus = 0x17,
    Max = 0x1f,
    Cnt = Max + 1
}