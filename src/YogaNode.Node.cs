namespace VL.Yoga
{
    public partial class YogaNode : IDisposable
    {
        public void Free() { unsafe { Interop.YGNodeFree(_node); } }
        public void FreeRecursive() { unsafe { Interop.YGNodeFreeRecursive(_node); } }
        public void Finalize() { unsafe { Interop.YGNodeFinalize(_node); } }
        public void Reset() { unsafe { Interop.YGNodeReset(_node); } }
        public void CalculateLayout(float? ownerWidth, float? ownerHeight, YGDirection ownerDirection) { unsafe { Interop.YGNodeCalculateLayout(_node, ownerWidth ?? float.NaN, ownerHeight ?? float.NaN, ownerDirection); } }
        public bool GetHasNewLayout() { unsafe { return Interop.YGNodeGetHasNewLayout(_node); } }
        public void SetHasNewLayout(bool hasNewLayout) { unsafe { Interop.YGNodeSetHasNewLayout(_node, hasNewLayout); } }
        public bool IsDirty() { unsafe { return Interop.YGNodeIsDirty(_node); } }
        public void MarkDirty() { unsafe { Interop.YGNodeMarkDirty(_node); } }
        public void InsertChild(YogaNode child, int index) { unsafe { Interop.YGNodeInsertChild(_node, child._node, index); } }
        public void SwapChild(YogaNode child, int index) { unsafe { Interop.YGNodeSwapChild(_node, child._node, index); } }
        public void RemoveChild(YogaNode excludedChild) { unsafe { Interop.YGNodeRemoveChild(_node, excludedChild._node); } }
        public void RemoveAllChildren() { unsafe { Interop.YGNodeRemoveAllChildren(_node); } }

        // TODO: FIGURE OUT:
        public void SetChildren(List<YogaNode> children, int count)
        {
            unsafe
            {
                throw new NotImplementedException();
                // Interop.YGNodeSetChildren(children.Select(x => x._node).ToArray());
            }
        }

        // TODO: FIGURE OUT
        // public YGNode* GetChild(YGNode* node, int count) { unsafe { Interop.YGNodeGetChild(); } }

        public int GetChildCount() { unsafe { return Interop.YGNodeGetChildCount(_node); } }

        // TODO: FIGURE OUT
        // public YGNode* YGNodeGetOwner(YGNode* node) { unsafe { Interop.YGNodeGetOwner(); } }
        public void SetConfig(YogaConfig config) { unsafe { Interop.YGNodeSetConfig(_node, config._config); } }


        // TODO: FIGURE OUT
        // public YGConfig* GetConfig(YGNode* node) { unsafe { Interop.YGNodeGetConfig(); } }
        public void SetContext(YogaConfig config) { unsafe { Interop.YGNodeSetContext(_node, config._config); } }
        // TODO: FIGURE OUT
        // public void* YGNodeGetContext(YGNode* node) { unsafe { Interop.YGNodeGetContext(); } }

        // TODO: FIGURE OUT (Looks problematic)
        public void SetMeasureFunc(nint measureFunc) { unsafe { Interop.YGNodeSetMeasureFunc(_node, measureFunc); } }

        public bool HasMeasureFunc() { unsafe { return Interop.YGNodeHasMeasureFunc(_node); } }

        // TODO: FIGURE OUT (Looks problematic)
        public void SetBaselineFunc(nint baselineFunc) { unsafe { Interop.YGNodeSetBaselineFunc(_node, baselineFunc); } }

        public bool HasBaselineFunc() { unsafe { return Interop.YGNodeHasBaselineFunc(_node); } }
        public void SetIsReferenceBaseline(bool isReferenceBaseline) { unsafe { Interop.YGNodeSetIsReferenceBaseline(_node, isReferenceBaseline); } }
        public bool IsReferenceBaseline() { unsafe { return Interop.YGNodeIsReferenceBaseline(_node); } }
        public void SetNodeType(NodeType nodeType) { unsafe { Interop.YGNodeSetNodeType(_node, nodeType); } }
        public NodeType GetNodeType() { unsafe { return Interop.YGNodeGetNodeType(_node); } }
        public void SetAlwaysFormsContainingBlock(bool alwaysFormsContainingBlock) { unsafe { Interop.YGNodeSetAlwaysFormsContainingBlock(_node, alwaysFormsContainingBlock); } }
        public bool GetAlwaysFormsContainingBlock() { unsafe { return Interop.YGNodeGetAlwaysFormsContainingBlock(_node); } }
    }
}
