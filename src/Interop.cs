using System.Runtime.InteropServices;

namespace VL.Yoga
{
    public static unsafe partial class Interop
    {
        private const string yogacoredll = "yogacore.dll";

        /// <summary>
        /// Returns the computed dimensions of the node, following the contraints of <paramref name="widthMode"/> and <paramref name="heightMode"/>:<br/>
        /// <br/>
        /// <list type="table">
        ///   <item>
        ///     <term><see cref="MeasureMode.Undefined"/></term>
        ///     <description>The parent has not imposed any constraint on the child. It can be whatever size it wants.</description>
        ///   </item>
        ///   <item>
        ///     <term><see cref="MeasureMode.AtMost"/></term>
        ///     <description>The child can be as large as it wants up to the specified size.</description>
        ///   </item>
        ///   <item>
        ///     <term><see cref="MeasureMode.Exactly"/></term>
        ///     <description>The parent has determined an exact size for the child. The child is going to be given those bounds regardless of how big it wants to be.</description>
        ///   </item>
        /// </list>
        /// </summary>
        /// <returns>
        /// The size of the leaf node, measured under the given contraints.
        /// </returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate YGSize YGMeasureFuncDelegate(YGNode* node, float width, MeasureMode widthMode, float height, MeasureMode heightMode);

        /// <summary>
        /// A defined offet to baseline (ascent).
        /// </summary>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate float YGBaselineFuncDelegate(YGNode* node, float width, float height);

        /// <summary>
        /// Function delegate for YGConfigSetLogger.
        /// </summary>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int YGLoggerDelegate(YGConfig* config, YGNode* node, YGLogLevel level, char* format, /* va_list */ char** args);

        /// <summary>
        /// Function delegate for YGConfigSetCloneNodeFunc.
        /// </summary>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate YGNode* YGCloneNodeFuncDelegate(YGNode* oldNode, YGNode* owner, int childIndex);
    }

}