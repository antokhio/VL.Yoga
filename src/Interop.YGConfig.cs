using System.Runtime.InteropServices;

namespace VL.Yoga
{
    public static unsafe partial class Interop
    {
        /// <summary>
        /// Allocates a set of configuration options. The configuration may be applied to multiple nodes (i.e.a single global config), or can be applied more granularly per-node.
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern YGConfig* YGConfigNew();

        /// <summary>
        /// Frees the associated Yoga configuration.
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGConfigFree(YGConfig* config);

        /// <summary>
        /// Returns the default config values set by Yoga.
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern YGConfig* YGConfigGetDefault();

        /// <summary>
        /// Yoga by default creates new nodes with style defaults different from flexbox on web (e.g. <see cref="YGFlexDirection.Column"/> and <see cref="YGPositionType.Relative"/>).<br/>
        /// `UseWebDefaults` instructs Yoga to instead use a default style consistent with the web.
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGConfigSetUseWebDefaults(YGConfig* config, bool enabled);

        /// <summary>
        /// Whether the configuration is set to use web defaults.
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool YGConfigGetUseWebDefaults(YGConfig* config);

        /// <summary>
        /// Yoga will by deafult round final layout positions and dimensions to the nearst point.<br/>
        /// `pointScaleFactor` controls the density of the grid used for layout rounding (e.g.to round to the closest display pixel).<br/>
        /// May be set to 0.0f to avoid rounding the layout results.
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGConfigSetPointScaleFactor(YGConfig* config, float pixelsInPoint);

        /// <summary>
        /// Get the currently set point scale factor.
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern float YGConfigGetPointScaleFactor(YGConfig* config);

        /// <summary>
        /// Configures how Yoga balances W3C conformance vs compatibility with layouts created against earlier versions of Yoga.<br/>
        /// <br/>
        /// By deafult Yoga will prioritize W3C conformance. `Errata` may be set to ask Yoga to produce specific incorrect behaviors. E.g. `YGConfigSetErrata(config, <see cref="YGErrata.StretchFlexBasis"/>)`.<br/>
        /// <br/>
        /// YGErrata is a bitmask, and multiple errata may be set at once. Predfined constants exist for convenience:<br/>
        /// <list type="table">
        ///   <item>
        ///     <term><see cref="YGErrata.None"/></term>
        ///     <description>No errata</description>
        ///   </item>
        ///   <item>
        ///     <term><see cref="YGErrata.Classic"/></term>
        ///     <description>Match layout behaviors of Yoga 1.x</description>
        ///   </item>
        ///   <item>
        ///     <term><see cref="YGErrata.All"/></term>
        ///     <description>Match layout behaviors of Yoga 1.x, including `UseLegacyStretchBehaviour`</description>
        ///   </item>
        /// </list>
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGConfigSetErrata(YGConfig* config, YGErrata errata);

        /// <summary>
        /// Get the currently set errata.
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern YGErrata YGConfigGetErrata(YGConfig* config);

        /// <summary>
        /// Set a custom log function for to use when logging diagnostics or fatal errors.
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGConfigSetLogger(YGConfig* config, nint logger);

        /// <summary>
        /// Sets an arbitrary context pointer on the config which may be read from during callbacks.
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGConfigSetContext(YGConfig* config, void* context);

        /// <summary>
        /// Gets the currently set context.
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void* YGConfigGetContext(YGConfig* config);

        /// <summary>
        /// Enable an experimental/unsupported feature in Yoga.
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGConfigSetExperimentalFeatureEnabled(YGConfig* config, YGExperimentalFeature feature, bool enabled);

        /// <summary>
        /// Whether an experimental feature is set.
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool YGConfigIsExperimentalFeatureEnabled(YGConfig* config, YGExperimentalFeature feature);

        /// <summary>
        /// Sets a callback, called during layout, to create a new mutable Yoga node if Yoga must write to it and its owner is not its parent observed during layout.
        /// </summary>
        [DllImport(yogacoredll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGConfigSetCloneNodeFunc(YGConfig* config, nint callback);
    }

}