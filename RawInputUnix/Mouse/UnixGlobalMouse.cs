namespace RawInputUnix;

public class UnixGlobalMouse
{
    public static string? GetMousePath() => UnixGlobalCommon.GetDevicePath("-B8 -E 'KEY=.*0 0 0 0'", "mouse");

    public static Dictionary<string, int>? GetMousePaths() =>
        UnixGlobalCommon.GetDevicePaths("-B8 -E 'KEY=.*0 0 0 0'", "mouse");

    public static ValueTask GetMouseEvents(string mousePath,
        Action<MouseState>? processMouseState, CancellationToken cancellationToken) =>
        UnixGlobalCommon.ProcessDeviceEvents(mousePath, ProcessEvent, processMouseState, cancellationToken);

    /// <summary>
    /// Processes the InputEvent
    /// </summary>
    /// <param name="state">MouseState to write to</param>
    /// <param name="inputEvent">Event to handle</param>
    /// <returns>If we processed this event or if the event wasn't something to process</returns>
    private static bool ProcessEvent(MouseState state, InputEvent64 inputEvent)
    {
        state.LastHorizontalWheelValue = 0;
        state.LastVerticalWheelValue = 0;
        state.LastXValue = 0;
        state.LastYValue = 0;
        return inputEvent.Type switch
        {
            EventType.Key => //button change
                ProcessKeyEvent(state, inputEvent),
            EventType.Rel => //axis change
                ProcessAxisEvent(state, inputEvent),
            _ => false
        };
    }

    private static bool ProcessKeyEvent(MouseState state, InputEvent64 inputEvent)
    {
        var buttonCode = (Button)inputEvent.Code;
        switch ((State)inputEvent.Value)
        {
            case State.Make:
                state.Button = buttonCode;
                state.IsDown = true;
                ChangeDownState(state, buttonCode);
                return true;
            case State.Break:
                state.IsDown = false;
                ChangeDownState(state, buttonCode);
                return true;
        }

        return false;
    }

    private static void ChangeDownState(MouseState state, Button btn)
    {
        switch (btn)
        {
            case Button.Left:
                state.IsLeftButtonDown = state.IsDown;
                return;
            case Button.Middle:
                state.IsMiddleButtonDown = state.IsDown;
                return;
            case Button.Right:
                state.IsRightButtonDown = state.IsDown;
                return;
            case Button.Base:
                state.IsBaseButtonDown = state.IsDown;
                return;
            case Button.Base2:
                state.IsBase2ButtonDown = state.IsDown;
                break;
        }
    }

    //Thanks to https://stackoverflow.com/a/9245610 for pointing out about inputEvent.value
    private static bool ProcessAxisEvent(MouseState state, InputEvent64 inputEvent)
    {
        /*The accumulated value 120 represents movement by one detent. For devices that do not provide high-resolution
         scrolling, the value is always a multiple of 120. For devices with high-resolution scrolling, 
         the value may be a fraction of 120.*/
        if (inputEvent.Code == (ushort)RelativeChange.WheelHiRes)
        {
            state.LastVerticalWheelValue = (short)inputEvent.Value / 120;
            return true;
        }
        if (inputEvent.Code == (ushort)RelativeChange.HWheelHiRes)
        {
            state.LastHorizontalWheelValue = (short)inputEvent.Value / 120;
            return true;
        }

        if (inputEvent.Code == (ushort)RelativeChange.X)
        {
            state.LastXValue = (short)inputEvent.Value;
            return true;
        }
        if (inputEvent.Code == (ushort)RelativeChange.Y)
        {
            state.LastYValue = (short)inputEvent.Value;
            return true;
        }
        return false;
    }
}