namespace Flex
{
    public interface IFlexStyle
    {
        IFlexStyle? Style { get; set; }
        public void ApplyStyle(IFlexNode node);
    }

    public static partial class Style
    {
        // Template style
        /*
        public record struct StyleFlex(IFlexStyle? Style, float Flex) : IFlexStyle
        {
            public void ApplyStyle(IFlexNode node)
            {
                unsafe
                {
                    Interop.YGNodeStyleSetFlex(node.GetHandle(), Flex);
                }

                Style?.ApplyStyle(node);
            }
        }

        public static StyleFlex SetFlex(IFlexStyle? style, float flex) => new(style, flex);
        */
    }
}