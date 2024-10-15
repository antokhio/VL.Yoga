namespace VL.Yoga
{
    public partial class YogaNode : IDisposable
    {
        private unsafe YGNode* _node;

        public YogaNode()
        {
            unsafe
            {
                _node = Interop.YGNodeNew();
            }
        }

        public void Dispose()
        {
            unsafe
            {

                if (IsValid())
                {
                    Interop.YGNodeFree(_node);
                    _node = null;
                }
            }
        }

        // TODO: Fix, this looks ok, however
        // pretty sure it's not
        public bool IsValid()
        {
            unsafe
            {
                return _node != null;
            }
        }
    }
}
