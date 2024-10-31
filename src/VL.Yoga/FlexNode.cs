using VL.Core.Import;
using YogaSharp;

namespace VL.Yoga
{
    public interface IFlexNode
    {
        public bool IsDirty();
        public unsafe YGNode* GetHandle();
    }

    [ProcessNode(HasStateOutput = true)]
    public partial class FlexNode : IFlexNode, IDisposable
    {
        protected internal unsafe YGNode* handle;

        public FlexNode()
        {
            unsafe
            {
                handle = Interop.YGNodeNew();
            }
        }

        [Fragment(IsHidden = true)]
        public bool IsDirty()
        {
            unsafe
            {
                return Interop.YGNodeIsDirty(handle);
            }
        }

        [Fragment(IsHidden = true)]
        public unsafe YGNode* GetHandle() => handle;
    }
}
