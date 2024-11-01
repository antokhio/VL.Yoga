using YogaSharp;

namespace Flex
{
    public interface IFlexConfig
    {
        IFlexConfig? Config { get; set; }
        public unsafe void ApplyConfig(YGConfig* handle);
    }
    internal class FlexConfig : IDisposable
    {
        protected internal unsafe YGConfig* handle = YGConfig.GetDefault();
        public unsafe YGConfig* GetHandle() => handle;
        public FlexConfig()
        {
            ConfigDefault();
        }

        public unsafe void ApplyConfig(IFlexNode node, IFlexConfig config)
        {
            config.ApplyConfig(handle);
            node.GetHandle()->SetConfig(handle);
        }

        public unsafe void ConfigDefault(IFlexNode? node = null)
        {
            // TODO: Figure out how to reset config
            handle->SetPointScaleFactor(0);

            if (node != null)
            {
                node.GetHandle()->SetConfig(handle);
            }
        }



        public void Dispose()
        {
            unsafe
            {
                handle->Dispose();
            }
        }
    }

    public static partial class Config
    {
        // TEMPLATE
        /*
        public static Internal.ConfigUseWebDefaults SetUseWebDefaults(IFlexConfig? config, bool enabled) => new(config, enabled);
        */
    }
}

namespace Flex.Internal
{
    // TEMPLATE 
    /*
    public unsafe record struct ConfigUseWebDefaults(IFlexConfig? Config, bool Enabled) : IFlexConfig
    {
        public unsafe void ApplyConfig(YGConfig* handle)
        {
            handle->SetUseWebDefaults(Enabled);
            Config?.ApplyConfig(handle);
        }
    }
    */
}
