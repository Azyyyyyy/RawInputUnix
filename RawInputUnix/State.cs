namespace RawInputUnix;

// these event.value-s aren't defined in <linux/input.h> ?
public enum State : ushort
{
    Make = 1, // when key/button pressed
    Break = 0, // when key/button released
    Repeat = 2 // when key/button switches to repeating after short delay
}