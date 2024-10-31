using YogaSharp;

namespace VL.Yoga
{
    public interface IFlexConfig
    {
        IFlexConfig? Config { get; set; }
        public void ApplyConfig(FlexConfig node, IFlexConfig config);
    }

    public static partial class Config
    {
        public record struct HiddenStruct(float Test);
        // TEMPLATE CONFIG
        /*
        public record struct ConfigUseWebDefaults(IFlexConfig? Config, bool Enabled) : IFlexConfig
        {
            public void ApplyConfig(FlexConfig node, IFlexConfig config)
            {
                unsafe
                {
                    Interop.YGConfigSetUseWebDefaults(node.GetHandle(), Enabled);
                    Config?.ApplyConfig(node, Config);
                }
            }
        }

        public static ConfigUseWebDefaults SetUseWebDefaults(IFlexConfig? style, bool enabled) => new ConfigUseWebDefaults(style, enabled);
        */
    }

    public partial class FlexConfig : IDisposable
    {
        protected internal unsafe YGConfig* handle;
        public FlexConfig()
        {
            ConfigDefault();
        }

        public void ApplyConfig(IFlexNode? node, IFlexConfig config)
        {
            unsafe
            {
                config?.ApplyConfig(this, config);

                if (node != null)
                {
                    Interop.YGNodeSetConfig(node.GetHandle(), GetHandle());
                }
            }
        }

        public void ConfigDefault(IFlexNode? node = null)
        {
            unsafe
            {
                handle = Interop.YGConfigGetDefault();
                Interop.YGConfigSetPointScaleFactor(handle, 0.0f);

                if (node != null)
                {
                    Interop.YGNodeSetConfig(node.GetHandle(), GetHandle());
                }
            }
        }

        public unsafe YGConfig* GetHandle() => handle;

        public bool IsValid()
        {
            unsafe
            {
                return handle != null;
            }
        }

        public void Dispose()
        {
            unsafe
            {
                if (IsValid())
                {
                    Interop.YGConfigFree(handle);
                    handle = null;
                }
            }
        }
    }
}
