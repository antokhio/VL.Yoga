namespace VL.Yoga
{
    public partial class YogaConfig : IDisposable
    {
        // TODO: Better implementation or shorthand && inconsistency check
        public void SetDefault() { unsafe { _config = Interop.YGConfigGetDefault(); } }

        public void SetUseWebDefaults(bool enabled) { unsafe { Interop.YGConfigSetUseWebDefaults(_config, enabled); } }
        public bool GetUseWebDefaults() { unsafe { return Interop.YGConfigGetUseWebDefaults(_config); } }
        public void SetPointScaleFactor(float pixelsInPoint) { unsafe { Interop.YGConfigSetPointScaleFactor(_config, pixelsInPoint); } }
        public float GetPointScaleFactor() { unsafe { return Interop.YGConfigGetPointScaleFactor(_config); } }
        public YGErrata GetErrata() { unsafe { return Interop.YGConfigGetErrata(_config); } }

        // TODO: FIGURE OUT
        public void SetLogger(nint logger) { unsafe { Interop.YGConfigSetLogger(_config, logger); } }

        // TODO: FIGURE OUT
        // public void YGConfigSetContext(YGConfig* config, void* context) { unsafe { Interop.YGConfigSetContext(); } }
        // public void* YGConfigGetContext(YGConfig* config) { unsafe { Interop.YGConfigGetContext(); } }

        public bool IsExperimentalFeatureEnabled(YGExperimentalFeature feature) { unsafe { return Interop.YGConfigIsExperimentalFeatureEnabled(_config, feature); } }

        // TODO: FIGURE OUT
        public void SetCloneNodeFunc(nint callback) { unsafe { Interop.YGConfigSetCloneNodeFunc(_config, callback); } }
    }
}
