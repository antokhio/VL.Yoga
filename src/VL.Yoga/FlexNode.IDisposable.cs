using VL.Core.Import;
using YogaSharp;

namespace Flex
{
    public partial class FlexNode : IFlexNode, IDisposable
    {
        [Fragment(IsHidden = true)]
        public bool IsValid()
        {
            unsafe
            {
                // TODO: Test
                return handle != null;
            }
        }

        [Fragment(IsHidden = true)]
        public void Dispose()
        {
            unsafe
            {
                if (IsValid())
                {
                    Interop.YGNodeFree(handle);
                    handle = null;
                }
            }
        }
    }
}
