using VL.Core.Import;
using VL.Lib.Collections;
using VL.Lib.Reactive;
using YogaSharp;

namespace Flex
{
    public interface IFlexNode
    {
        public bool IsDirty { get; set; }
        public unsafe YGNode* GetHandle();
    }

    [ProcessNode(Name = "FlexNode")]
    public class FlexProcess
    {
        private FlexNode _output = new FlexNode();

        private bool shouldInvalidate;

        public void Update(out IFlexNode output, Spread<IFlexNode?>? children = null, IFlexStyle? style = null, IChannel<FlexLayout>? layoutChannel = null)
        {
            shouldInvalidate =
                // invalidate by style
                (_output.Style == null && style != null) ||
                (style == null && _output.Style != null) ||
                (!style?.Equals(_output.Style) ?? false) ||
                // invalidate by children
                children != _output.Children;

            if (shouldInvalidate)
            {
                _output.Children = children;
                _output.Style = style;
            }

            _output.UpdateLayout(layoutChannel);

            output = _output;
        }
    }

    public class FlexNode : IFlexNode, IDisposable
    {
        protected unsafe readonly YGNode* handle = YGNode.New();
        public unsafe YGNode* GetHandle() => handle;
        public FlexNode()
        {

        }

        private FlexLayout layout;
        public FlexLayout Layout
        {
            get => layout;
        }

        private Spread<IFlexNode?>? children = null;
        public Spread<IFlexNode?>? Children
        {
            internal get => children;
            set
            {
                if (value != children)
                {
                    var validChildren = value?.Where(child => child != null).ToSpread();
                    var validChildrenCount = validChildren?.Count;

                    if (validChildren is not null && validChildrenCount > 0)
                    {
                        unsafe
                        {
                            YGNode*[] refs = new YGNode*[validChildrenCount.Value];
                            for (int i = 0; i < validChildrenCount; i++)
                            {
                                refs[i] = validChildren[i]!.GetHandle();
                            }

                            handle->SetChildren(refs);
                        }
                    }
                    else
                    {
                        unsafe
                        {
                            handle->RemoveAllChildren();
                        }
                    }

                    children = value;
                }

            }
        }

        private IFlexStyle? style = null;
        public IFlexStyle? Style
        {
            get => style;
            set
            {
                if (value != style)
                {
                    ResetStyle();

                    value?.ApplyStyle(this);

                    style = value;
                }
            }
        }

        public void ResetStyle()
        {
            unsafe
            {
                var bulkNode = YGNode.New();
                GetHandle()->CopyStyle(bulkNode);
                bulkNode->Dispose();
            }
        }

        public void UpdateLayout(in IChannel<FlexLayout>? layoutChannel = null)
        {
            if (HasNewLayout)
            {
                unsafe
                {

                    layout = FlexLayout.GetLayout(GetHandle());
                }

                layoutChannel?.OnNext(layout);
                HasNewLayout = false;
            }
        }

        public bool HasNewLayout
        {
            get
            {
                unsafe
                {
                    return handle->GetHasNewLayout();
                }
            }
            set
            {
                unsafe
                {
                    handle->SetHasNewLayout(value);
                }
            }
        }
        public bool IsDirty
        {
            get
            {
                unsafe
                {
                    return handle->IsDirty();
                }
            }
            set
            {
                unsafe
                {
                    handle->MarkDirty();
                }
            }
        }

        public void Dispose()
        {
            unsafe
            {
                handle->Dispose();
            }

            GC.SuppressFinalize(this);
        }
    }
}
