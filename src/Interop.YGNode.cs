using System.Runtime.InteropServices;


namespace VL.Yoga
{
    public static unsafe partial class Interop
    {
        /// <summary>
        /// Heap allocates and returns a new Yoga node using Yoga settings.
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern YGNode* YGNodeNew();

        /// <summary>
        /// Heap allocates and returns a new Yoga node, with customized settings.
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern YGNode* YGNodeNewWithConfig(YGConfig* config);

        /// <summary>
        /// Returns a mutable copy of an existing node, with the same context and
        /// children, but no owner set.<br/>
        /// Does not call the function set by YGConfigSetCloneNodeFunc().
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern YGNode* YGNodeClone(YGNode* oldnode);

        /// <summary>
        /// Frees the Yoga node, disconnecting it from its owner and children.
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeFree(YGNode* node);

        /// <summary>
        /// Frees the subtree of Yoga nodes rooted at the given node.
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeFreeRecursive(YGNode* node);

        /// <summary>
        /// Frees the Yoga node without disconnecting it from its owner or children.<br/>
        /// Allows garbage collecting Yoga nodes in parallel when the entire tree is unrechable.
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeFinalize(YGNode* node);

        /// <summary>
        /// Resets the node to its default state.
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeReset(YGNode* node);

        /// <summary>
        /// Calculates the layout of the tree rooted at the given node.<br/>
        /// Layout results may be read after calling YGNodeCalculateLayout() using
        /// functions like YGNodeLayoutGetLeft(), YGNodeLayoutGetTop(), etc.<br/>
        /// YGNodeGetHasNewLayout() may be read to know if the layout of the node or its
        /// subtrees may have changed since the last time YGNodeCalculate() was called.
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeCalculateLayout(YGNode* node, float ownerWidth, float ownerHeight, YGDirection ownerDirection);

        /// <summary>
        /// Whether the given node may have new layout results. Must be reset by calling YGNodeSetHasNewLayout().
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool YGNodeGetHasNewLayout(YGNode* node);

        /// <summary>
        /// Sets whether a nodes layout is considered new.
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeSetHasNewLayout(YGNode* node, bool hasNewLayout);

        /// <summary>
        /// Whether the node's layout results are dirty due to it or its children changing.
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool YGNodeIsDirty(YGNode* node);

        /// <summary>
        /// Marks a node with custom measure function as dirty.
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeMarkDirty(YGNode* node);

        // [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)]
        // public static extern void YGNodeSetDirtiedFunc(YGNode* node, YGDirtiedFunc* dirtiedFunc);

        // [DllImport(YogaDll, CallingConvention = CallingConvention.Cdecl)]
        // public static extern YGDirtiedFunc* YGNodeGetDirtiedFunc(YGNode* node);

        /// <summary>
        /// Inserts a child node at the given index.
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeInsertChild(YGNode* node, YGNode* child, int index);

        /// <summary>
        /// Replaces the child node at a given index with a new one.
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeSwapChild(YGNode* node, YGNode* child, int index);

        /// <summary>
        /// Removes the given child node.
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeRemoveChild(YGNode* node, YGNode* excludedChild);

        /// <summary>
        /// Removes all children nodes.
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeRemoveAllChildren(YGNode* node);

        /// <summary>
        /// Sets children according to the given list of nodes.
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeSetChildren(YGNode* node, YGNode** children, int count);

        /// <summary>
        /// Get the child node at a given index.
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern YGNode* YGNodeGetChild(YGNode* node, int count);

        /// <summary>
        /// The number of child nodes.
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern int YGNodeGetChildCount(YGNode* node);

        /// <summary>
        /// Get the parent/owner currently set for a node.
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern YGNode* YGNodeGetOwner(YGNode* node);

        /// <summary>
        /// Set a new config for the node after creation.
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeSetConfig(YGNode* node, YGConfig* config);

        /// <summary>
        /// Get the config currently set on the node.
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern YGConfig* YGNodeGetConfig(YGNode* node);

        /// <summary>
        /// Sets extra data on the Yoga node which may be read from during callbacks.
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeSetContext(YGNode* node, void* config);

        /// <summary>
        /// Returns the context or NULL if no context has been set.
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void* YGNodeGetContext(YGNode* node);

        /// <summary>
        /// Allows providing custom measurements for a Yoga leaf node(usually for measuring text).<br/>
        /// YGNodeMarkDirty() must be set if content effecting the measurements of the node changes.
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeSetMeasureFunc(YGNode* node, nint measureFunc);

        /// <summary>
        /// Whether a measure function is set.
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool YGNodeHasMeasureFunc(YGNode* node);

        /// <summary>
        /// Set a custom function for determining the text baseline for use in baseline alignment.
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeSetBaselineFunc(YGNode* node, nint baselineFunc);

        /// <summary>
        /// Whether a baseline function is set.
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool YGNodeHasBaselineFunc(YGNode* node);

        /// <summary>
        /// Sets this node should be considered the reference baseline among siblings.
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeSetIsReferenceBaseline(YGNode* node, bool isReferenceBaseline);

        /// <summary>
        /// Whether this node is set as the reference baseline.
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool YGNodeIsReferenceBaseline(YGNode* node);

        /// <summary>
        /// Sets whether a leaf node's layout results may be truncated during layout rounding.
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeSetNodeType(YGNode* node, NodeType nodeType);

        /// <summary>
        /// Whether a leaf node's layout results may be truncated during layout rounding.
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern NodeType YGNodeGetNodeType(YGNode* node);

        /// <summary>
        /// Make it so that this node will always form a containing block for any descendant nodes.<br/>
        /// This is useful for when a node has a property outside of of Yoga that will form a containing block.<br/>
        /// For example, transforms or some of the others listed in <see href="https://developer.mozilla.org/en-US/docs/Web/CSS/Containing_block"/>
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeSetAlwaysFormsContainingBlock(YGNode* node, bool alwaysFormsContainingBlock);

        /// <summary>
        /// Whether the node will always form a containing block for any descendant.<br/>
        /// This can happen in situation where the client implements something like a transform
        /// that can affect containing blocks but is not handled by Yoga directly.
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool YGNodeGetAlwaysFormsContainingBlock(YGNode* node);
    }

}