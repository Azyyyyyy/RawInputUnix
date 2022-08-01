using System.Diagnostics;

namespace RawInputUnix;

//A lot of source code initially came from https://github.com/kernc/logkeys/blob/master/src/keytables.cc
public class KeyTable
{
    private const string CharOrFunc =  // c = character key, f = function key, _ = blank/error ('_' is used, don't change); all according to KEY_* defines from <linux/input.h>
    "_fccccccccccccff" +
    "ccccccccccccffcc" +
    "ccccccccccfccccc" +
    "ccccccffffffffff" +
    "ffffffffffffffff" +
    "ffff__cff_______" +
    "ffffffffffffffff" +
    "_______f_____fff";

    // these are ordered default US keymap keys
    public const string CharKeys =  "1234567890-=qwertyuiop[]asdfghjkl;'`\\zxcvbnm,./<";
    public const string ShiftKeys = "!@#$%^&*()_+QWERTYUIOP{}ASDFGHJKL:\"~|ZXCVBNM<>?>";
    public const string AltGrKeys = "\0"; // old, US don't use AltGr key: "\0@\0$\0\0{[]}\\\0qwertyuiop\0~asdfghjkl\0\0\0\0zxcvbnm\0\0\0|";  // \0 on no symbol; as obtained by `loadkeys us`
    // TODO: add altgr_shift_keys[] (http://en.wikipedia.org/wiki/AltGr_key#US_international)
    
    public static string[] FuncKeys = {
        "<Esc>", "<BckSp>", "<Tab>", "<Enter>", "<LCtrl>", "<LShft>", "<RShft>", "<KP*>", "<LAlt>", "<Space>", "<CpsLk>", "<F1>", "<F2>", "<F3>", "<F4>", "<F5>",
        "<F6>", "<F7>", "<F8>", "<F9>", "<F10>", "<NumLk>", "<ScrLk>", "<KP7>", "<KP8>", "<KP9>", "<KP->", "<KP4>", "<KP5>", "<KP6>", "<KP+>", "<KP1>",
        "<KP2>", "<KP3>", "<KP0>", "<KP.>", /*"<",*/ "<F11>", "<F12>", "<KPEnt>", "<RCtrl>", "<KP/>", "<PrtSc>", "<AltGr>", "<Break>" /*linefeed?*/, "<Home>", "<Up>", "<PgUp>", 
        "<Left>", "<Right>", "<End>", "<Down>", "<PgDn>", "<Ins>", "<Del>", "<Pause>", "<LMeta>", "<RMeta>", "<Menu>"
    };

    public static readonly int CharOrFuncLength = CharOrFunc.Length - 1;
    public readonly int KeysDefined = CharOrFunc.Count(x => x is 'c' or 'f');  // sum of all 'c' and 'f' chars in char_or_func[]

    public static bool IsCharKey(int code)
    {
        Debug.Assert(code < CharOrFuncLength);
        return (CharOrFunc[code] == 'c');
    }

    public static bool IsFuncKey(int code)
    {
        Debug.Assert(code < CharOrFuncLength);
        return (CharOrFunc[code] == 'f');
    }

    public static bool IsUsedKey(int code)
    {
        Debug.Assert(code < CharOrFuncLength);
        return (CharOrFunc[code] != '_');
    }
    
    // translates character keycodes to continuous array indexes
    public static int ToCharKeysIndex(int keycode) =>
        keycode switch
        {
            // keycodes 2-13: US keyboard: 1, 2, ..., 0, -, =
            >= (int)Key.One and <= (int)Key.Equal => keycode - 2,
            // keycodes 16-27: q, w, ..., [, ]
            >= (int)Key.Q and <= (int)Key.RightBrace => keycode - 4,
            // keycodes 30-41: a, s, ..., ', `
            >= (int)Key.A and <= (int)Key.Grave => keycode - 6,
            // keycodes 43-53: \, z, ..., ., /
            >= (int)Key.Backslash and <= (int)Key.Slash => keycode - 7,
            (int)Key.Key102Nd => 47,
            _ => -1
        };

    // translates function keys keycodes to continuous array indexes
    public static int ToFuncKeysIndex(int keycode) =>
        keycode switch
        {
            // 1
            (int)Key.Esc => 0,
            // 14-15
            >= (int)Key.Backspace and <= (int)Key.Tab => keycode - 13,
            // 28-29
            >= (int)Key.Enter and <= (int)Key.LeftCtrl => keycode - 25,
            (int)Key.LeftShift => keycode - 37,
            // 54-83
            >= (int)Key.RightShift and <= (int)Key.KeyPadDot => keycode - 48,
            // 87-88
            >= (int)Key.F11 and <= (int)Key.F12 => keycode - 51,
            // 96-111
            >= (int)Key.KeyPadEnter and <= (int)Key.Delete => keycode - 58,
            // 119
            (int)Key.Paste => keycode - 65,
            // 125-127
            >= (int)Key.LeftMeta and <= (int)Key.Compose => keycode - 70,
            _ => -1
        };
}