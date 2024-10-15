using System.Runtime.InteropServices;

namespace VL.Yoga
{
    public static unsafe partial class Interop
    {
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern float YGNodeLayoutGetLeft(YGNode* node);

        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern float YGNodeLayoutGetTop(YGNode* node);

        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern float YGNodeLayoutGetRight(YGNode* node);

        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern float YGNodeLayoutGetBottom(YGNode* node);

        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern float YGNodeLayoutGetWidth(YGNode* node);

        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern float YGNodeLayoutGetHeight(YGNode* node);

        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern YGDirection YGNodeLayoutGetDirection(YGNode* node);

        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool YGNodeLayoutGetHadOverflow(YGNode* node);

        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern float YGNodeLayoutGetMargin(YGNode* node, YGEdge edge);

        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern float YGNodeLayoutGetBorder(YGNode* node, YGEdge edge);

        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern float YGNodeLayoutGetPadding(YGNode* node, YGEdge edge);
    }

}