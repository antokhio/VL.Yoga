namespace VL.Yoga
{
    public partial class YogaConfig : IDisposable
    {
        internal unsafe YGConfig* _config;

        public YogaConfig()
        {
            unsafe
            {
                _config = Interop.YGConfigNew();
            }

        }

        // TODO: Fix, this looks ok, however
        // pretty sure it's not
        public bool IsValid()
        {
            unsafe
            {
                return _config != null;
            }
        }

        public void Dispose()
        {
            unsafe
            {
                Interop.YGConfigFree(_config);
                _config = null;
            }
        }
    }
}
