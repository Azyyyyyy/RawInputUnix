using RawInputUnix.States;

namespace RawInputUnix;

public class MouseState : DeviceState
{
    public Button Button { get; set; }

    public bool IsDown { get; set; }

    /// <summary>
    /// -1 is on the left, 0 no change, 1 on the right
    /// </summary>
    public double LastHorizontalWheelValue { get; set; }

    /// <summary>
    /// -1 is down, 0 no change, 1 is up
    /// </summary>
    public double LastVerticalWheelValue { get; set; }
    
    /// <summary>
    /// -X is left, 0 no change, +X is right
    /// </summary>
    public double LastXValue { get; set; }

    /// <summary>
    /// -X is up, 0 no change, +X is down
    /// </summary>
    public double LastYValue { get; set; }
    
    public bool IsLeftButtonDown { get; set; }
    public bool IsMiddleButtonDown { get; set; }
    public bool IsRightButtonDown { get; set; }
    public bool IsBaseButtonDown { get; set; }
    public bool IsBase2ButtonDown { get; set; }
}