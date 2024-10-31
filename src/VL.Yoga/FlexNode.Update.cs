using VL.Core.Import;
using VL.Lib.Collections;
using VL.Lib.Reactive;
using YogaSharp;

namespace VL.Yoga
{
    public partial class FlexNode : IFlexNode, IDisposable
    {
        private Spread<IFlexNode>? _children;
        private IFlexStyle? _style = null;
        private FlexLayout _layout = new FlexLayout();

        [Fragment(IsHidden = false)]
        public void Update(in Spread<IFlexNode>? children = null, in IFlexStyle? style = null, in IChannel<FlexLayout>? layout = null)
        {
            if (children != _children)
            {
                if (children == null)
                {
                    RemoveAllChildren();
                }
                else
                {
                    SetChildren(children);
                }

                _children = children;
            }

            if (style != _style)
            {
                if (style == null)
                {
                    RemoveAllStyle();
                }
                else
                {
                    SetStyle(style);
                }

                _style = style;
            }

            if (HasNewLayout())
            {
                _layout = new FlexLayout(this);

                layout?.OnNext(_layout);

                SetHasNewLayout(false);
            }
        }

        [Fragment(IsHidden = true)]
        public FlexLayout GetLayout() => _layout;

        [Fragment(IsHidden = true)]
        public bool HasNewLayout()
        {
            unsafe
            {
                return Interop.YGNodeGetHasNewLayout(handle);
            }
        }

        [Fragment(IsHidden = true)]
        public void SetHasNewLayout(bool hasNewLayout)
        {
            unsafe
            {
                Interop.YGNodeSetHasNewLayout(handle, hasNewLayout);
            }
        }

        [Fragment(IsHidden = true)]
        public void SetStyle(IFlexStyle style)
        {
            style.ApplyStyle(this);
        }

        [Fragment(IsHidden = true)]
        public void RemoveAllStyle()
        {
            unsafe
            {
                var bulkNode = Interop.YGNodeNew();
                Interop.YGNodeCopyStyle(handle, bulkNode);
                Interop.YGNodeFree(bulkNode);
            }
        }

        [Fragment(IsHidden = true)]
        public void SetChildren(IEnumerable<IFlexNode?> children)
        {
            var validChildren = children.Where(child => child != null).ToSpread();
            var validChildrenCount = validChildren.Count;

            if (validChildrenCount > 0)
            {
                unsafe
                {
                    var childrenRefs = stackalloc YGNode*[validChildrenCount];
                    for (int i = 0; i < validChildrenCount; i++)
                    {
                        childrenRefs[i] = validChildren[i]!.GetHandle();
                    }

                    Interop.YGNodeSetChildren(handle, childrenRefs, validChildrenCount);
                }
            }
            else
            {
                RemoveAllChildren();
            }
        }

        [Fragment(IsHidden = true)]
        public void RemoveAllChildren()
        {
            unsafe
            {
                Interop.YGNodeRemoveAllChildren(handle);
            }
        }
    }
}
