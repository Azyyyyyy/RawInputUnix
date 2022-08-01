namespace RawInputUnix;

//TODO: Org keys
//TODO: Finish making current comments into comments that the user will be able to see
public enum Key
{
    Reserved = 0,
    Esc = 1,
    One = 2,
    Two = 3,
    Three = 4,
    Four = 5,
    Five = 6,
    Fix = 7,
    Seven = 8,
    Eight = 9,
    Nine = 10,
    Zero = 11,
    Minus = 12,
    Equal = 13,
    Backspace = 14,
    Tab = 15,
    Q = 16,
    W = 17,
    E = 18,
    R = 19,
    T = 20,
    Y = 21,
    U = 22,
    I = 23,
    O = 24,
    P = 25,
    LeftBrace = 26,
    RightBrace = 27,
    Enter = 28,
    LeftCtrl = 29,
    A = 30,
    S = 31,
    D = 32,
    F = 33,
    G = 34,
    H = 35,
    J = 36,
    K = 37,
    L = 38,
    Semicolon = 39,
    Apostrophe = 40,
    Grave = 41,
    LeftShift = 42,
    Backslash = 43,
    Z = 44,
    X = 45,
    C = 46,
    V = 47,
    B = 48,
    N = 49,
    M = 50,
    Comma = 51,
    Dot = 52,
    Slash = 53,
    RightShift = 54,
    Asterisks = 55,
    LeftAlt = 56,
    Space = 57,
    Capslock = 58,
    F1 = 59,
    F2 = 60,
    F3 = 61,
    F4 = 62,
    F5 = 63,
    F6 = 64,
    F7 = 65,
    F8 = 66,
    F9 = 67,
    F10 = 68,
    Numlock = 69,
    ScrollLock = 70,
    KeyPad7 = 71,
    KeyPad8 = 72,
    KeyPad9 = 73,
    KeyPadMinus = 74,
    KeyPad4 = 75,
    KeyPad5 = 76,
    KeyPad6 = 77,
    KeyPadPlus = 78,
    KeyPad1 = 79,
    KeyPad2 = 80,
    KeyPad3 = 81,
    KeyPad0 = 82,
    KeyPadDot = 83,

    ZenkakuHankaku = 85,
    Key102Nd = 86,
    F11 = 87,
    F12 = 88,
    Ro = 89,
    Katakana = 90,
    Hiragana = 91,
    Henkan = 92,
    KatakanaHiragana = 93,
    Muhenkan = 94,
    KeyPadJpComma = 95,
    KeyPadEnter = 96,
    RightCtrl = 97,
    KeyPadSlash = 98,
    SysRq = 99,
    RightAlt = 100,
    Linefeed = 101,
    Home = 102,
    Up = 103,
    PageUp = 104,
    Left = 105,
    Right = 106,
    End = 107,
    Down = 108,
    PageDown = 109,
    Insert = 110,
    Delete = 111,
    Macro = 112,
    Mute = 113,
    VolumeDown = 114,
    VolumeUp = 115,
    /// <summary>
    /// SC System Power Down
    /// </summary>
    Power = 116,
    KeyPadEqual = 117,
    KeyPadPlusMinus = 118,
    Pause = 119,
    /// <summary>
    /// AL Compiz Scale (Expose)
    /// </summary>
    Scale = 120, 

    KeyPadComma = 121,
    Hangeul = 122,
    Hanguel = Hangeul,
    Hanja = 123,
    Yen = 124,
    LeftMeta = 125,
    RightMeta = 126,
    Compose = 127,

    /// <summary>
    /// AC Stop
    /// </summary>
    Stop = 128,
    Again = 129,
    /// <summary>
    /// AC Properties
    /// </summary>
    Props = 130,
    /// <summary>
    /// AC Undo
    /// </summary>
    Undo = 131,
    Front = 132,
    /// <summary>
    /// AC Copy
    /// </summary>
    Copy = 133,
    /// <summary>
    /// AC Open
    /// </summary>
    Open = 134,
    /// <summary>
    /// AC Paste
    /// </summary>
    Paste = 135,
    /// <summary>
    /// AC Search
    /// </summary>
    Find = 136,
    /// <summary>
    /// AC Cut
    /// </summary>
    Cut = 137,
    /// <summary>
    /// AL Integrated Help Center
    /// </summary>
    Help = 138,
    /// <summary>
    /// Menu (show menu)
    /// </summary>
    Menu = 139,
    /// <summary>
    /// AL Calculator
    /// </summary>
    Calc = 140,
    Setup = 141,
    /// <summary>
    /// SC System Sleep
    /// </summary>
    Sleep = 142,
    /// <summary>
    /// System Wake Up
    /// </summary>
    Wakeup = 143,
    /// <summary>
    /// AL Local Machine Browser
    /// </summary>
    File = 144,
    SendFile = 145,
    DeleteFile = 146,
    Xfer = 147, //????
    Prog1 = 148,
    Prog2 = 149,
    /// <summary>
    /// AL Internet Browser
    /// </summary>
    Www = 150,
    MsDos = 151,
    /// <summary>
    /// AL Terminal Lock/Screensaver
    /// </summary>
    Coffee = 152,
    ScreenLock = Coffee,
    /// <summary>
    /// Display orientation for e.g. tablets
    /// </summary>
    RotateDisplay = 153,
    Direction = RotateDisplay,
    CycleWindows = 154,
    Mail = 155,
    /// <summary>
    /// AC Bookmarks
    /// </summary>
    Bookmarks = 156,
    Computer = 157,
    /// <summary>
    /// AC Back
    /// </summary>
    Back = 158,
    /// <summary>
    /// AC Forward
    /// </summary>
    Forward = 159,
    CloseCd = 160,
    EjectCd = 161,
    EjectCloseCd = 162,
    NextSong = 163,
    PlayPause = 164,
    PreviousSong = 165,
    StopCd = 166,
    Record = 167,
    Rewind = 168,
    /// <summary>
    /// Media Select Telephone
    /// </summary>
    Phone = 169,
    Iso = 170,
    /// <summary>
    /// AL Consumer Control Configuration
    /// </summary>
    Config = 171,
    /// <summary>
    /// AC Home
    /// </summary>
    Homepage = 172,
    /// <summary>
    /// AC Refresh
    /// </summary>
    Refresh = 173,
    /// <summary>
    /// AC Exit
    /// </summary>
    Exit = 174,
    Move = 175,
    Edit = 176,
    ScrollUp = 177,
    ScrollDown = 178,
    KeyPadLeftParen = 179,
    KeyPadRightParen = 180,
    /// <summary>
    /// AC New
    /// </summary>
    New = 181,
    /// <summary>
    /// AC Redo/Repeat
    /// </summary>
    Redo = 182,

    F13 = 183,
    F14 = 184,
    F15 = 185,
    F16 = 186,
    F17 = 187,
    F18 = 188,
    F19 = 189,
    F20 = 190,
    F21 = 191,
    F22 = 192,
    F23 = 193,
    F24 = 194,

    PlayCd = 200,
    PauseCd = 201,
    Prog3 = 202,
    Prog4 = 203,
    /// <summary>
    /// AC Desktop Show All Applications
    /// </summary>
    AllApplications = 204,
    Dashboard = AllApplications,
    Suspend = 205,
    /// <summary>
    /// AC Close
    /// </summary>
    Close = 206,
    Play = 207,
    FastForward = 208,
    BassBoost = 209,
    /// <summary>
    /// AC Print
    /// </summary>
    Print = 210,
    Hp = 211,
    Camera = 212,
    Sound = 213,
    Question = 214,
    Email = 215,
    Chat = 216,
    Search = 217,
    Connect = 218,
    /// <summary>
    /// AL Checkbook/Finance
    /// </summary>
    Finance = 219,
    Sport = 220,
    Shop = 221,
    AltErase = 222,
    /// <summary>
    /// AC Cancel
    /// </summary>
    Cancel = 223,
    BrightnessDown = 224,
    BrightnessUp = 225,
    Media = 226,

    /// <summary>
    /// Cycle between available video outputs (Monitor/LCD/TV-out/etc)
    /// </summary>
    SwitchVideoMode = 227,
    IllumToggle = 228,
    IllumDown = 229,
    IllumUp = 230,

    /// <summary>
    /// AC Send
    /// </summary>
    Send = 231,
    /// <summary>
    /// AC Reply
    /// </summary>
    Reply = 232,
    /// <summary>
    /// AC Forward Msg
    /// </summary>
    ForwardMail = 233,
    /// <summary>
    /// AC Save
    /// </summary>
    Save = 234,
    Documents = 235,
    Battery = 236,
    Bluetooth = 237,
    WLan = 238,
    Uwb = 239,
    Unknown = 240,

    VideoNext = 241, /* drive next video source */
    VideoPrev = 242, /* drive previous video source */
    BrightnessCycle = 243, /* brightness up, after max is min */
    BrightnessAuto = 244, /* Set Auto Brightness: manual brightness control is off, rely on ambient */
    BrightnessZero = BrightnessAuto,
    DisplayOff = 245, /* display device to off state */

    WiWan = 246, /* Wireless WAN (LTE, UMTS, GSM, etc.) */
    WiMax = WiWan,
    RfKill = 247, /* Key that controls all radios */

    MicMute = 248, /* Mute / unmute the microphone */

    Ok = 0x160,
    Select = 0x161,
    Goto = 0x162,
    Clear = 0x163,
    Power2 = 0x164,
    Option = 0x165,
    Info = 0x166, /* AL OEM Features/Tips/Tutorial */
    Time = 0x167,
    Vendor = 0x168,
    Archive = 0x169,
    Program = 0x16a, /* Media Select Program Guide */
    Channel = 0x16b,
    Favorites = 0x16c,
    Epg = 0x16d,
    Pvr = 0x16e, /* Media Select Home */
    Mhp = 0x16f,
    Language = 0x170,
    Title = 0x171,
    Subtitle = 0x172,
    Angle = 0x173,
    FullScreen = 0x174, /* AC View Toggle */
    Zoom = FullScreen,
    Mode = 0x175,
    Keyboard = 0x176,
    AspectRatio = 0x177, /* HUTRR37: Aspect */
    Screen = AspectRatio,
    Pc = 0x178, /* Media Select Computer */
    Tv = 0x179, /* Media Select TV */
    Tv2 = 0x17a, /* Media Select Cable */
    Vcr = 0x17b, /* Media Select VCR */
    Vcr2 = 0x17c, /* VCR Plus */
    Sat = 0x17d, /* Media Select Satellite */
    Sat2 = 0x17e,
    Cd = 0x17f, /* Media Select CD */
    Tape = 0x180, /* Media Select Tape */
    Radio = 0x181,
    Tuner = 0x182, /* Media Select Tuner */
    Player = 0x183,
    Text = 0x184,
    Dvd = 0x185, /* Media Select DVD */
    Aux = 0x186,
    Mp3 = 0x187,
    Audio = 0x188, /* AL Audio Browser */
    Video = 0x189, /* AL Movie Browser */
    Directory = 0x18a,
    List = 0x18b,
    Memo = 0x18c, /* Media Select Messages */
    Calendar = 0x18d,
    Red = 0x18e,
    Green = 0x18f,
    Yellow = 0x190,
    Blue = 0x191,
    ChannelUp = 0x192, /* Channel Increment */
    ChannelDown = 0x193, /* Channel Decrement */
    First = 0x194,
    Last = 0x195, /* Recall Last */
    Ab = 0x196,
    Next = 0x197,
    Restart = 0x198,
    Slow = 0x199,
    Shuffle = 0x19a,
    Break = 0x19b,
    Previous = 0x19c,
    Digits = 0x19d,
    Teen = 0x19e,
    Twen = 0x19f,
    Videophone = 0x1a0, /* Media Select Video Phone */
    Games = 0x1a1, /* Media Select Games */
    ZoomIn = 0x1a2, /* AC Zoom In */
    ZoomOut = 0x1a3, /* AC Zoom Out */
    ZoomReset = 0x1a4, /* AC Zoom */
    WordProcessor = 0x1a5, /* AL Word Processor */
    Editor = 0x1a6, /* AL Text Editor */
    Spreadsheet = 0x1a7, /* AL Spreadsheet */
    GraphicsEditor = 0x1a8, /* AL Graphics Editor */
    Presentation = 0x1a9, /* AL Presentation App */
    Database = 0x1aa, /* AL Database App */
    News = 0x1ab, /* AL Newsreader */
    Voicemail = 0x1ac, /* AL Voicemail */
    AddressBook = 0x1ad, /* AL Contacts/Address Book */
    Messenger = 0x1ae, /* AL Instant Messaging */
    DisplayToggle = 0x1af, /* Turn display (LCD) on and off */
    BrightnessToggle = DisplayToggle,
    Spellcheck = 0x1b0, /* AL Spell Check */
    Logoff = 0x1b1, /* AL Logoff */

    Dollar = 0x1b2,
    Euro = 0x1b3,

    FrameBack = 0x1b4, /* Consumer - transport controls */
    FrameForward = 0x1b5,
    ContextMenu = 0x1b6, /* GenDesc - system context menu */
    MediaRepeat = 0x1b7, /* Consumer - transport control */
    ChannelsUp10 = 0x1b8, /* 10 channels up (10+) */
    ChannelsDown10 = 0x1b9, /* 10 channels down (10-) */
    Images = 0x1ba, /* AL Image Browser */
    NotificationCenter = 0x1bc, /* Show/hide the notification center */
    PickupPhone = 0x1bd, /* Answer incoming call */
    HangupPhone = 0x1be, /* Decline incoming call */

    DelEol = 0x1c0,
    DelEos = 0x1c1,
    InsLine = 0x1c2,
    DelLine = 0x1c3,

    Fn = 0x1d0,
    FnEsc = 0x1d1,
    FnF1 = 0x1d2,
    FnF2 = 0x1d3,
    FnF3 = 0x1d4,
    FnF4 = 0x1d5,
    FnF5 = 0x1d6,
    FnF6 = 0x1d7,
    FnF7 = 0x1d8,
    FnF8 = 0x1d9,
    FnF9 = 0x1da,
    FnF10 = 0x1db,
    FnF11 = 0x1dc,
    FnF12 = 0x1dd,
    Fn1 = 0x1de,
    Fn2 = 0x1df,
    FnD = 0x1e0,
    FnE = 0x1e1,
    FnF = 0x1e2,
    FnS = 0x1e3,
    FnB = 0x1e4,
    FnRightShift = 0x1e5,

    BrlDot1 = 0x1f1,
    BrlDot2 = 0x1f2,
    BrlDot3 = 0x1f3,
    BrlDot4 = 0x1f4,
    BrlDot5 = 0x1f5,
    BrlDot6 = 0x1f6,
    BrlDot7 = 0x1f7,
    BrlDot8 = 0x1f8,
    BrlDot9 = 0x1f9,
    BrlDot10 = 0x1fa,

    Numeric0 = 0x200, /* used by phones, remote controls, */
    Numeric1 = 0x201, /* and other keypads */
    Numeric2 = 0x202,
    Numeric3 = 0x203,
    Numeric4 = 0x204,
    Numeric5 = 0x205,
    Numeric6 = 0x206,
    Numeric7 = 0x207,
    Numeric8 = 0x208,
    Numeric9 = 0x209,
    NumericStar = 0x20a,
    NumericPound = 0x20b,
    NumericA = 0x20c, /* Phone key A - HUT Telephony 0xb9 */
    NumericB = 0x20d,
    NumericC = 0x20e,
    NumericD = 0x20f,

    CameraFocus = 0x210,
    WpsButton = 0x211, /* WiFi Protected Setup key */

    TouchpadToggle = 0x212, /* Request switch touchpad on or off */
    TouchpadOn = 0x213,
    TouchpadOff = 0x214,

    CameraZoomIn = 0x215,
    CameraZoomOut = 0x216,
    CameraUp = 0x217,
    CameraDown = 0x218,
    CameraLeft = 0x219,
    CameraRight = 0x21a,

    AttendantOn = 0x21b,
    AttendantOff = 0x21c,
    AttendantToggle = 0x21d, /* Attendant call on or off */
    LightsToggle = 0x21e, /* Reading light on or off */
    AlsToggle = 0x230, /* Ambient light sensor */
    RotateLockToggle = 0x231, /* Display rotation lock */
    ButtonConfig = 0x240, /* AL Button Configuration */
    TaskManager = 0x241, /* AL Task/Project Manager */
    Journal = 0x242, /* AL Log/Journal/Timecard */
    ControlPanel = 0x243, /* AL Control Panel */
    AppSelect = 0x244, /* AL Select Task/Application */
    Screensaver = 0x245, /* AL Screen Saver */
    VoiceCommand = 0x246, /* Listening Voice Command */
    Assistant = 0x247, /* AL Context-aware desktop assistant */
    KbdLayoutNext = 0x248, /* AC Next Keyboard Layout Select */
    EmojiPicker = 0x249, /* Show/hide emoji picker (HUTRR101) */
    Dictate = 0x24a, /* Start or Stop Voice Dictation Session (HUTRR99) */

    BrightnessMin = 0x250, /* Set Brightness to Minimum */
    BrightnessMax = 0x251, /* Set Brightness to Maximum */

    KbdInputAssistPrev = 0x260,
    KbdInputAssistNext = 0x261,
    KbdInputAssistPrevGroup = 0x262,
    KbdInputAssistNextGroup = 0x263,
    KbdInputAssistAccept = 0x264,
    KbdInputAssistCancel = 0x265,

    /* Diagonal movement keys */
    RightUp = 0x266,
    RightDown = 0x267,
    LeftUp = 0x268,
    LeftDown = 0x269,

    RootMenu = 0x26a, /* Show Device's Root Menu */

    /* Show Top Menu of the Media (e.g. DVD) */
    MediaTopMenu = 0x26b,
    Numeric11 = 0x26c,
    Numeric12 = 0x26d,

/*
 * Toggle Audio Description: refers to an audio service that helps blind and
 * visually impaired consumers understand the action in a program. Note: in
 * some countries this is referred to as "Video Description".
 */
    AudioDesc = 0x26e,
    Mode3D = 0x26f,
    NextFavorite = 0x270,
    StopRecord = 0x271,
    PauseRecord = 0x272,
    Vod = 0x273, /* Video on Demand */
    Unmute = 0x274,
    FastReverse = 0x275,
    SlowReverse = 0x276,

/*
 * Control a data application associated with the currently viewed channel,
 * e.g. teletext or data broadcast application (MHEG, MHP, HbbTV, etc.)
 */
    Data = 0x277,
    OnscreenKeyboard = 0x278,

/* Electronic privacy screen control */
    PrivacyScreenToggle = 0x279,

/* Select an area of screen to be copied */
    SelectiveScreenshot = 0x27a,

/* Move the focus to the next or previous user controllable element within a UI container */
    NextElement = 0x27b,
    PreviousElement = 0x27c,

/* Toggle Autopilot engagement */
    AutopilotEngageToggle = 0x27d,

/* Shortcut Keys */
    MarkWaypoint = 0x27e,
    Sos = 0x27f,
    NavChart = 0x280,
    FishingChart = 0x281,
    SingleRangeRadar = 0x282,
    DualRangeRadar = 0x283,
    RadarOverlay = 0x284,
    TraditionalSonar = 0x285,
    ClearVuSonar = 0x286,
    SideVuSonar = 0x287,
    NavInfo = 0x288,
    BrightnessMenu = 0x289,

/*
 * Some keyboards have keys which do not have a defined meaning, these keys
 * are intended to be programmed / bound to macros by the user. For most
 * keyboards with these macro-keys the key-sequence to inject, or action to
 * take, is all handled by software on the host side. So from the kernel's
 * point of view these are just normal keys.
 *
 * The MACRO# codes below are intended for such keys, which may be labeled
 * e.g. G1-G18, or S1 - S30. The MACRO# codes MUST NOT be used for keys
 * where the marking on the key does indicate a defined meaning / purpose.
 *
 * The MACRO# codes MUST also NOT be used as fallback for when no existing
 * FOO define matches the marking / purpose. In this case a new FOO
 * define MUST be added.
 */
    Macro1 = 0x290,
    Macro2 = 0x291,
    Macro3 = 0x292,
    Macro4 = 0x293,
    Macro5 = 0x294,
    Macro6 = 0x295,
    Macro7 = 0x296,
    Macro8 = 0x297,
    Macro9 = 0x298,
    Macro10 = 0x299,
    Macro11 = 0x29a,
    Macro12 = 0x29b,
    Macro13 = 0x29c,
    Macro14 = 0x29d,
    Macro15 = 0x29e,
    Macro16 = 0x29f,
    Macro17 = 0x2a0,
    Macro18 = 0x2a1,
    Macro19 = 0x2a2,
    Macro20 = 0x2a3,
    Macro21 = 0x2a4,
    Macro22 = 0x2a5,
    Macro23 = 0x2a6,
    Macro24 = 0x2a7,
    Macro25 = 0x2a8,
    Macro26 = 0x2a9,
    Macro27 = 0x2aa,
    Macro28 = 0x2ab,
    Macro29 = 0x2ac,
    Macro30 = 0x2ad,

/*
 * Some keyboards with the macro-keys described above have some extra keys
 * for controlling the host-side software responsible for the macro handling:
 * -A macro recording start/stop key. Note that not all keyboards which emit
 *  MACRO_RECORD_START will also emit MACRO_RECORD_STOP if
 *  MACRO_RECORD_STOP is not advertised, then MACRO_RECORD_START
 *  should be interpreted as a recording start/stop toggle;
 * -Keys for switching between different macro (pre)sets, either a key for
 *  cycling through the configured presets or keys to directly select a preset.
 */
    MacroRecordStart = 0x2b0,
    MacroRecordStop = 0x2b1,
    MacroPresetCycle = 0x2b2,
    MacroPreset1 = 0x2b3,
    MacroPreset2 = 0x2b4,
    MacroPreset3 = 0x2b5,

/*
 * Some keyboards have a buildin LCD panel where the contents are controlled
 * by the host. Often these have a number of keys directly below the LCD
 * intended for controlling a menu shown on the LCD. These keys often don't
 * have any labeling so we just name them KBD_LCD_MENU#
 */
    KbdLcdMenu1 = 0x2b8,
    KbdLcdMenu2 = 0x2b9,
    KbdLcdMenu3 = 0x2ba,
    KbdLcdMenu4 = 0x2bb,
    KbdLcdMenu5 = 0x2bc
}