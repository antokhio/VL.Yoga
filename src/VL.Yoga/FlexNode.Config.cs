using VL.Core.Import;
using YogaSharp;

namespace VL.Yoga
{
    public partial class FlexNode : IFlexNode, IDisposable
    {
        [Fragment(IsHidden = true)]
        public void GetConfig(out bool hasConfig, out bool? useWebDefaults, out float? pointScaleFactor, out YGErrata? errata/*, out Spread<YGExperimentalFeature> experimentalFeatures*/)
        {
            unsafe
            {
                var config = Interop.YGNodeGetConfig(this.GetHandle());

                hasConfig = config != null;

                if (hasConfig)
                {
                    hasConfig = true;
                    useWebDefaults = Interop.YGConfigGetUseWebDefaults(config);
                    pointScaleFactor = Interop.YGConfigGetPointScaleFactor(config);
                    errata = Interop.YGConfigGetErrata(config);
                }
                else
                {
                    hasConfig = false;
                    useWebDefaults = null;
                    pointScaleFactor = null;
                    errata = null;
                }
            }
        }
    }
}
