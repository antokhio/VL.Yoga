// OBSOLETE 
// TODO: REMOVE

namespace VL.Yoga
{

    public unsafe struct YGConfig : IDisposable
    {
        /// <inheritdoc cref="Interop.YGConfigGetDefault"/>
        public static YGConfig* GetDefault()
        {
            return Interop.YGConfigGetDefault();
        }

        /// <inheritdoc cref="Interop.YGConfigNew"/>
        public static YGConfig* New()
        {
            return Interop.YGConfigNew();
        }

        /// <inheritdoc cref="Interop.YGConfigFree(YGConfig*)"/>
        public void Dispose()
        {
            fixed (YGConfig* ptr = &this)
                Interop.YGConfigFree(ptr);
        }

        /// <inheritdoc cref="Interop.YGConfigSetUseWebDefaults(YGConfig*, bool)"/>
        public void SetUseWebDefaults(bool enabled)
        {
            fixed (YGConfig* ptr = &this)
                Interop.YGConfigSetUseWebDefaults(ptr, enabled);
        }

        /// <inheritdoc cref="Interop.YGConfigGetUseWebDefaults(YGConfig*)"/>
        public bool GetUseWebDefaults()
        {
            fixed (YGConfig* ptr = &this)
                return Interop.YGConfigGetUseWebDefaults(ptr);
        }

        /// <inheritdoc cref="Interop.YGConfigSetPointScaleFactor(YGConfig*, float)"/>
        public void SetPointScaleFactor(float pixelsInPoint)
        {
            fixed (YGConfig* ptr = &this)
                Interop.YGConfigSetPointScaleFactor(ptr, pixelsInPoint);
        }

        /// <inheritdoc cref="Interop.YGConfigGetPointScaleFactor(YGConfig*)"/>
        public float GetPointScaleFactor()
        {
            fixed (YGConfig* ptr = &this)
                return Interop.YGConfigGetPointScaleFactor(ptr);
        }

        /// <inheritdoc cref="Interop.YGConfigSetErrata(YGConfig*, YGErrata)"/>
        public void SetErrata(YGErrata errata)
        {
            fixed (YGConfig* ptr = &this)
                Interop.YGConfigSetErrata(ptr, errata);
        }

        /// <inheritdoc cref="Interop.YGConfigGetErrata(YGConfig*)"/>
        public YGErrata GetErrata()
        {
            fixed (YGConfig* ptr = &this)
                return Interop.YGConfigGetErrata(ptr);
        }

        /// <inheritdoc cref="Interop.YGConfigSetContext(YGConfig*, void*)"/>
        public unsafe void SetContext(void* context)
        {
            fixed (YGConfig* ptr = &this)
                Interop.YGConfigSetContext(ptr, context);
        }

        /// <inheritdoc cref="Interop.YGConfigGetContext(YGConfig*)"/>
        public unsafe void* GetContext()
        {
            fixed (YGConfig* ptr = &this)
                return Interop.YGConfigGetContext(ptr);
        }

        /// <inheritdoc cref="Interop.YGConfigSetExperimentalFeatureEnabled(YGConfig*, YGExperimentalFeature, bool)"/>
        public void SetContext(YGExperimentalFeature feature, bool enabled)
        {
            fixed (YGConfig* ptr = &this)
                Interop.YGConfigSetExperimentalFeatureEnabled(ptr, feature, enabled);
        }

        /// <inheritdoc cref="Interop.YGConfigIsExperimentalFeatureEnabled(YGConfig*, YGExperimentalFeature)"/>
        public bool IsExperimentalFeatureEnabled(YGExperimentalFeature feature)
        {
            fixed (YGConfig* ptr = &this)
                return Interop.YGConfigIsExperimentalFeatureEnabled(ptr, feature);
        }

        /// <inheritdoc cref="Interop.YGConfigSetLogger(YGConfig*, nint)"/>
        public void SetLogger(nint logger)
        {
            fixed (YGConfig* ptr = &this)
                Interop.YGConfigSetLogger(ptr, logger);
        }

        /// <inheritdoc cref="Interop.YGConfigSetCloneNodeFunc(YGConfig*, nint)"/>
        public void SetCloneNodeFunc(nint cloneFunc)
        {
            fixed (YGConfig* ptr = &this)
                Interop.YGConfigSetCloneNodeFunc(ptr, cloneFunc);
        }
    }

}