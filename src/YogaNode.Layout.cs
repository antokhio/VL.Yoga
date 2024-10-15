namespace VL.Yoga
{
    public partial class YogaNode : IDisposable
    {
        public float LayoutGetLeft() { unsafe { return Interop.YGNodeLayoutGetLeft(_node); } }
        public float LayoutGetTop() { unsafe { return Interop.YGNodeLayoutGetTop(_node); } }
        public float LayoutGetRight() { unsafe { return Interop.YGNodeLayoutGetRight(_node); } }
        public float LayoutGetBottom() { unsafe { return Interop.YGNodeLayoutGetBottom(_node); } }
        public float LayoutGetWidth() { unsafe { return Interop.YGNodeLayoutGetWidth(_node); } }
        public float LayoutGetHeight() { unsafe { return Interop.YGNodeLayoutGetHeight(_node); } }
        public YGDirection LayoutGetDirection() { unsafe { return Interop.YGNodeLayoutGetDirection(_node); } }
        public bool LayoutGetHadOverflow() { unsafe { return Interop.YGNodeLayoutGetHadOverflow(_node); } }
        public float LayoutGetMargin(YGEdge edge) { unsafe { return Interop.YGNodeLayoutGetMargin(_node, edge); } }
        public float LayoutGetBorder(YGEdge edge) { unsafe { return Interop.YGNodeLayoutGetBorder(_node, edge); } }
        public float YGNodeLayoutGetPadding(YGEdge edge) { unsafe { return Interop.YGNodeLayoutGetPadding(_node, edge); } }
    }
}
