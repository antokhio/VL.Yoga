using System.Runtime.InteropServices;

namespace Flex
{
    /*
     *  WIP
     */

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct LayoutContext
    {
        public float OwnerWidth { get; set; }
        public float OwnerHeight { get; set; }
        public LayoutContext(float? ownerWidth, float? ownerHeight)
        {
            OwnerWidth = ownerWidth ?? float.NaN;
            OwnerHeight = ownerHeight ?? float.NaN;
        }
        public unsafe LayoutContext* GetHandle()
        {
            fixed (LayoutContext* ptr = &this)
            {
                return ptr;
            }
        }
    }
}
