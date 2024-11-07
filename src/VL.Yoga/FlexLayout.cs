using Stride.Core.Mathematics;
using VL.Core.Import;
using YogaSharp;

namespace Flex
{
    public record struct FlexLayout
    {
        public float Left { get; set; }
        public float Top { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }

        // shouldScroll?

        public unsafe FlexLayout(YGNode* handle, FlexLayout? ownerLayout = null)
        {
            Left = handle->GetComputedLeft() + ownerLayout?.Left ?? .0f;
            Top = handle->GetComputedTop() + ownerLayout?.Top ?? .0f;
            Width = handle->GetComputedWidth();
            Height = handle->GetComputedHeight();
        }
        public static unsafe FlexLayout GetLayout(YGNode* handle)
        {
            var owner = handle->GetOwner();

            if (owner != null)
            {
                var ownerLayout = GetLayout(owner);
                return new FlexLayout(handle, ownerLayout);
            }

            return new FlexLayout(handle);
        }

        public static void Split(in FlexLayout layout, out Vector2 position, out Vector2 size)
        {
            position = new Vector2(layout.Left + layout.Width / 2, layout.Top + layout.Height / 2);
            size = new Vector2(layout.Width, layout.Height);
        }
    }



    [ProcessNode(Name = "FlexLayout")]
    public class FlexLayoutProcess
    {
        private FlexConfig _flexConfig;
        private IFlexNode? _node = null;
        private IFlexConfig? _config = null;
        private float? _ownerWidth = null;
        private float? _ownerHeight = null;
        private YGDirection? _ownerDirection = null;
        public FlexLayoutProcess()
        {
            _flexConfig = new FlexConfig();
        }

        private bool shouldApplyConfig;
        private bool canApplyConfig;
        private bool shouldCalculateLayout;
        private bool canCalculateLayout;

        public void Update(in IFlexNode? node = null, in IFlexConfig? config = null, in float? ownerWidth = null, in float? ownerHeight = null, in YGDirection? ownerDirection = null)
        {
            shouldApplyConfig = (config != null && !config.Equals(_config)) || (config == null && _config != null);
            canApplyConfig = node != null;

            shouldCalculateLayout = shouldApplyConfig || node != _node || ownerWidth != _ownerWidth || ownerHeight != _ownerHeight || ownerDirection != _ownerDirection;
            canCalculateLayout = node != null;

            if (shouldApplyConfig && canApplyConfig)
            {
                if (config == null)
                {
                    _flexConfig.ConfigDefault(node);
                }
                else
                {
                    _flexConfig.ApplyConfig(node!, config);
                }

                _config = config;
            }

            if (canCalculateLayout)
            {
                var isDirty = node?.IsDirty ?? false;

                if (shouldCalculateLayout || isDirty)
                {
                    unsafe
                    {
                        _ownerWidth = ownerWidth;
                        _ownerHeight = ownerHeight;
                        _ownerDirection = ownerDirection;
                        _node = node;

                        node!.GetHandle()->CalculateLayout(_ownerWidth ?? float.NaN, _ownerHeight ?? float.NaN, _ownerDirection ?? YGDirection.Inherit);
                    }
                }
            }
            else
            {
                _node = null;
            }
        }
    }
}
