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

    [ProcessNode(HasStateOutput = true, FragmentSelection = FragmentSelection.Implicit)]
    public partial class FlexNode : IFlexNode, IDisposable
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

        private IEnumerable<IFlexNode?>? children = null;
        [Fragment(IsHidden = false)]
        public IEnumerable<IFlexNode?>? Children
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
        [Fragment(IsHidden = false)]
        public IFlexStyle? Style
        {
            get => style;
            set
            {
                if (value != style)
                {
                    value?.ApplyStyle(this);

                    style = value;
                }
            }
        }

        [Fragment(IsHidden = false)]
        public void Update(in IChannel<FlexLayout>? layoutChannel = null)
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

        [Fragment(IsHidden = true)]
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

        [Fragment(IsHidden = true)]
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
        [Fragment(IsHidden = true)]
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
