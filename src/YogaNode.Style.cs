namespace VL.Yoga
{
    public partial class YogaNode : IDisposable
    {
        public void CopyStyle(YogaNode dstNode) { unsafe { Interop.YGNodeCopyStyle(dstNode._node, _node); } }
        public void StyleSetDirection(YGDirection value) { unsafe { Interop.YGNodeStyleSetDirection(_node, value); } }
        public YGDirection StyleGetDirection() { unsafe { return Interop.YGNodeStyleGetDirection(_node); } }
        public void StyleSetFlexDirection(YGFlexDirection flexDirection) { unsafe { Interop.YGNodeStyleSetFlexDirection(_node, flexDirection); } }
        public YGFlexDirection StyleGetFlexDirection() { unsafe { return Interop.YGNodeStyleGetFlexDirection(_node); } }
        public void StyleSetJustifyContent(YGJustify justifyContent) { unsafe { Interop.YGNodeStyleSetJustifyContent(_node, justifyContent); } }
        public YGJustify StyleGetJustifyContent() { unsafe { return Interop.YGNodeStyleGetJustifyContent(_node); } }
        public void StyleSetAlignContent(YGAlign alignContent) { unsafe { Interop.YGNodeStyleSetAlignContent(_node, alignContent); } }
        public YGAlign StyleGetAlignContent() { unsafe { return Interop.YGNodeStyleGetAlignContent(_node); } }
        public void StyleSetAlignItems(YGAlign alignItems) { unsafe { Interop.YGNodeStyleSetAlignItems(_node, alignItems); } }
        public YGAlign StyleGetAlignItems() { unsafe { return Interop.YGNodeStyleGetAlignItems(_node); } }
        public void StyleSetAlignSelf(YGAlign alignSelf) { unsafe { Interop.YGNodeStyleSetAlignSelf(_node, alignSelf); } }
        public YGAlign StyleGetAlignSelf() { unsafe { return Interop.YGNodeStyleGetAlignSelf(_node); } }
        public void StyleSetPositionType(YGPositionType position) { unsafe { Interop.YGNodeStyleSetPositionType(_node, position); } }
        public YGPositionType StyleGetPositionType() { unsafe { return Interop.YGNodeStyleGetPositionType(_node); } }
        public void StyleSetFlexWrap(YGWrap flexWrap) { unsafe { Interop.YGNodeStyleSetFlexWrap(_node, flexWrap); } }
        public YGWrap StyleGetFlexWrap() { unsafe { return Interop.YGNodeStyleGetFlexWrap(_node); } }
        public void StyleSetOverflow(YGOverflow overflow) { unsafe { Interop.YGNodeStyleSetOverflow(_node, overflow); } }
        public YGOverflow StyleGetOverflow() { unsafe { return Interop.YGNodeStyleGetOverflow(_node); } }
        public void StyleSetDisplay(YGDisplay display) { unsafe { Interop.YGNodeStyleSetDisplay(_node, display); } }
        public YGDisplay StyleGetDisplay() { unsafe { return Interop.YGNodeStyleGetDisplay(_node); } }
        public void StyleSetFlex(float flex) { unsafe { Interop.YGNodeStyleSetFlex(_node, flex); } }
        public float StyleGetFlex() { unsafe { return Interop.YGNodeStyleGetFlex(_node); } }
        public void StyleSetFlexGrow(float flexGrow) { unsafe { Interop.YGNodeStyleSetFlexGrow(_node, flexGrow); } }
        public float StyleGetFlexGrow() { unsafe { return Interop.YGNodeStyleGetFlexGrow(_node); } }
        public void StyleSetFlexShrink(float flexShrink) { unsafe { Interop.YGNodeStyleSetFlexShrink(_node, flexShrink); } }
        public float StyleGetFlexShrink() { unsafe { return Interop.YGNodeStyleGetFlexShrink(_node); } }
        public void StyleSetFlexBasis(float flexBasis) { unsafe { Interop.YGNodeStyleSetFlexBasis(_node, flexBasis); } }
        public void StyleSetFlexBasisPercent(float flexBasisPercent) { unsafe { Interop.YGNodeStyleSetFlexBasisPercent(_node, flexBasisPercent); } }
        public void StyleSetFlexBasisAuto() { unsafe { Interop.YGNodeStyleSetFlexBasisAuto(_node); } }
        public YGValue StyleGetFlexBasis() { unsafe { return Interop.YGNodeStyleGetFlexBasis(_node); } }
        public void StyleSetPosition(YGEdge edge, float value) { unsafe { Interop.YGNodeStyleSetPosition(_node, edge, value); } }
        public void StyleSetPositionPercent(YGEdge edge, float percent) { unsafe { Interop.YGNodeStyleSetPositionPercent(_node, edge, percent); } }
        public YGValue StyleGetPosition(YGEdge edge) { unsafe { return Interop.YGNodeStyleGetPosition(_node, edge); } }
        public void StyleSetMargin(YGEdge edge, float value) { unsafe { Interop.YGNodeStyleSetMargin(_node, edge, value); } }
        public void StyleSetMarginPercent(YGEdge edge, float percent) { unsafe { Interop.YGNodeStyleSetMarginPercent(_node, edge, percent); } }
        public void StyleSetMarginAuto(YGEdge edge) { unsafe { Interop.YGNodeStyleSetMarginAuto(_node, edge); } }
        public YGValue StyleGetMargin(YGEdge edge) { unsafe { return Interop.YGNodeStyleGetMargin(_node, edge); } }
        public void StyleSetPadding(YGEdge edge, float value) { unsafe { Interop.YGNodeStyleSetPadding(_node, edge, value); } }
        public void StyleSetPaddingPercent(YGEdge edge, float percent) { unsafe { Interop.YGNodeStyleSetPaddingPercent(_node, edge, percent); } }
        public YGValue StyleGetPadding(YGEdge edge) { unsafe { return Interop.YGNodeStyleGetPadding(_node, edge); } }
        public void StyleSetBorder(YGEdge edge, float value) { unsafe { Interop.YGNodeStyleSetBorder(_node, edge, value); } }
        public float StyleGetBorder(YGEdge edge) { unsafe { return Interop.YGNodeStyleGetBorder(_node, edge); } }
        public void StyleSetGap(YGGutter gutter, float gapLength) { unsafe { Interop.YGNodeStyleSetGap(_node, gutter, gapLength); } }
        public float StyleGetGap(YGGutter gutter) { unsafe { return Interop.YGNodeStyleGetGap(_node, gutter); } }
        public void StyleSetAspectRatio(float aspectRatio) { unsafe { Interop.YGNodeStyleSetAspectRatio(_node, aspectRatio); } }
        public float StyleGetAspectRatio() { unsafe { return Interop.YGNodeStyleGetAspectRatio(_node); } }
        public void StyleSetWidth(float width) { unsafe { Interop.YGNodeStyleSetWidth(_node, width); } }
        public void StyleSetWidthPercent(float widthPercent) { unsafe { Interop.YGNodeStyleSetWidthPercent(_node, widthPercent); } }
        public void StyleSetWidthAuto() { unsafe { Interop.YGNodeStyleSetWidthAuto(_node); } }
        public YGValue StyleGetWidth() { unsafe { return Interop.YGNodeStyleGetWidth(_node); } }
        public void StyleSetHeight(float height) { unsafe { Interop.YGNodeStyleSetHeight(_node, height); } }
        public void StyleSetHeightPercent(float heightPercent) { unsafe { Interop.YGNodeStyleSetHeightPercent(_node, heightPercent); } }
        public void StyleSetHeightAuto() { unsafe { Interop.YGNodeStyleSetHeightAuto(_node); } }
        public YGValue StyleGetHeight() { unsafe { return Interop.YGNodeStyleGetHeight(_node); } }
        public void StyleSetMinWidth(float minWidth) { unsafe { Interop.YGNodeStyleSetMinWidth(_node, minWidth); } }
        public void StyleSetMinWidthPercent(float minWidthPercent) { unsafe { Interop.YGNodeStyleSetMinWidthPercent(_node, minWidthPercent); } }
        public YGValue StyleGetMinWidth() { unsafe { return Interop.YGNodeStyleGetMinWidth(_node); } }
        public void StyleSetMinHeight(float minHeight) { unsafe { Interop.YGNodeStyleSetMinHeight(_node, minHeight); } }
        public void StyleSetMinHeightPercent(float minHeightPercent) { unsafe { Interop.YGNodeStyleSetMinHeightPercent(_node, minHeightPercent); } }
        public YGValue StyleGetMinHeight() { unsafe { return Interop.YGNodeStyleGetMinHeight(_node); } }
        public void StyleSetMaxWidth(float maxWidth) { unsafe { Interop.YGNodeStyleSetMaxWidth(_node, maxWidth); } }
        public void StyleSetMaxWidthPercent(float maxWidthPercent) { unsafe { Interop.YGNodeStyleSetMaxWidthPercent(_node, maxWidthPercent); } }
        public YGValue StyleGetMaxWidth() { unsafe { return Interop.YGNodeStyleGetMaxWidth(_node); } }
        public void StyleSetMaxHeight(float maxHeight) { unsafe { Interop.YGNodeStyleSetMaxHeight(_node, maxHeight); } }
        public void StyleSetMaxHeightPercent(float maxHeightPercent) { unsafe { Interop.YGNodeStyleSetMaxHeightPercent(_node, maxHeightPercent); } }
        public YGValue StyleGetMaxHeight() { unsafe { return Interop.YGNodeStyleGetMaxHeight(_node); } }
    }
}
