namespace VL.Yoga
{
    public enum YGAlign
    {
        Auto,
        FlexStart,
        Center,
        FlexEnd,
        Stretch,
        Baseline,
        SpaceBetween,
        SpaceAround,
        SpaceEvenly
    }

    public enum YGDimension
    {
        Width,
        Height
    }

    public enum YGDirection
    {
        Inherit,
        LTR,
        RTL
    }

    public enum YGDisplay
    {
        Flex,
        None
    }

    public enum YGEdge
    {
        Left,
        Top,
        Right,
        Bottom,
        Start,
        End,
        Horizontal,
        Vertical,
        All
    }

    public enum YGErrata
    {
        None = 0,
        StretchFlexBasis = 1,
        AbsolutePositioningIncorrect = 2,
        AbsolutePercentAgainstInnerSize = 4,
        All = int.MaxValue,
        Classic = int.MaxValue - 1
    }

    public enum YGExperimentalFeature
    {
        WebFlexBasis
    }

    public enum YGFlexDirection
    {
        Column,
        ColumnReverse,
        Row,
        RowReverse
    }

    public enum YGGutter
    {
        Column,
        Row,
        All
    }

    public enum YGJustify
    {
        FlexStart,
        Center,
        FlexEnd,
        SpaceBetween,
        SpaceAround,
        SpaceEvenly
    }

    public enum YGLogLevel
    {
        Error,
        Warn,
        Info,
        Debug,
        Verbose,
        Fatal
    }

    public enum MeasureMode
    {
        Undefined,
        Exactly,
        AtMost
    }

    public enum NodeType
    {
        Default,
        Text
    }

    public enum YGOverflow
    {
        Visible,
        Hidden,
        Scroll
    }

    public enum PhysicalEdge
    {
        Left,
        Top,
        Right,
        Bottom
    }

    public enum YGPositionType
    {
        Static,
        Relative,
        Absolute
    }

    public enum YGUnit
    {
        Undefined,
        Point,
        Percent,
        Auto
    }

    public enum YGWrap
    {
        NoWrap,
        Wrap,
        WrapReverse
    }

}
