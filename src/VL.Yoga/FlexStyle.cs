namespace Flex
{
    public interface IFlexStyle
    {
        IFlexStyle? Style { get; set; }
        public void ApplyStyle(IFlexNode node);
    }

    public static partial class Style
    {
        // TEMPLATE
        /*
        public static Style.Internal.StyleFlex SetFlex(IFlexStyle? style, float flex) => new(style, flex);
        */
    }
}

namespace Flex.Internal
{
    // TEMPLATE

    /*
    public unsafe record struct StyleFlex(IFlexStyle? Style, float Flex) : IFlexStyle
    {
        public void ApplyStyle(IFlexNode node)
        {
            node.GetHandle()->SetFlex(Flex);
            Style?.ApplyStyle(node);
        }
    }
    */
}
