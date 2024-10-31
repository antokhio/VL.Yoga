using System.Text.Json;
using System.Text.Json.Serialization;
using YogaSharp;

namespace Flex
{
    public static class Debug
    {
        internal static JsonSerializerOptions SerializerOptions()
        {
            var opts = new JsonSerializerOptions
            {
                WriteIndented = true,
                NumberHandling = JsonNumberHandling.AllowNamedFloatingPointLiterals,
            };

            opts.Converters.Add(new JsonStringEnumConverter());

            return opts;
        }

        public static string? DebugFlexNodeConfig(IFlexNode? node)
        {
            unsafe
            {
                if (node != null)
                {
                    var config = Interop.YGNodeGetConfig(node.GetHandle());
                    var hasConfig = config is not null;

                    if (hasConfig)
                    {
                        return JsonSerializer.Serialize(new
                        {
                            useWebDefaults = Interop.YGConfigGetUseWebDefaults(config),
                            pointScaleFactor = Interop.YGConfigGetPointScaleFactor(config),
                            errata = Interop.YGConfigGetErrata(config),
                            experimentalFeatureWebFlexBasis = Interop.YGConfigIsExperimentalFeatureEnabled(config, YGExperimentalFeature.WebFlexBasis)
                        }, SerializerOptions());
                    }
                }

                return null;
            }
        }

        public static string? DebugFlexNodeStyle(IFlexNode? node)
        {
            unsafe
            {
                if (node != null)
                {
                    return JsonSerializer.Serialize(new
                    {
                        direction = Interop.YGNodeStyleGetDirection(node.GetHandle()),
                        flexDirection = Interop.YGNodeStyleGetFlexDirection(node.GetHandle()),
                        justifyContent = Interop.YGNodeStyleGetJustifyContent(node.GetHandle()),
                        alignContent = Interop.YGNodeStyleGetAlignContent(node.GetHandle()),
                        alignItems = Interop.YGNodeStyleGetAlignItems(node.GetHandle()),
                        alignSelf = Interop.YGNodeStyleGetAlignSelf(node.GetHandle()),
                        positionType = Interop.YGNodeStyleGetPositionType(node.GetHandle()),
                        flexWrap = Interop.YGNodeStyleGetFlexWrap(node.GetHandle()),
                        overflow = Interop.YGNodeStyleGetOverflow(node.GetHandle()),
                        display = Interop.YGNodeStyleGetDisplay(node.GetHandle()),
                        flex = Interop.YGNodeStyleGetFlex(node.GetHandle()),
                        flexGrow = Interop.YGNodeStyleGetFlexGrow(node.GetHandle()),
                        flexShrink = Interop.YGNodeStyleGetFlexShrink(node.GetHandle()),
                        flexBasis = Interop.YGNodeStyleGetFlexBasis(node.GetHandle()),

                        position = new
                        {
                            Left = Interop.YGNodeStyleGetPosition(node.GetHandle(), YGEdge.Left),
                            Right = Interop.YGNodeStyleGetPosition(node.GetHandle(), YGEdge.Right),
                            Top = Interop.YGNodeStyleGetPosition(node.GetHandle(), YGEdge.Top),
                            Bottom = Interop.YGNodeStyleGetPosition(node.GetHandle(), YGEdge.Bottom),
                            Horizontal = Interop.YGNodeStyleGetPosition(node.GetHandle(), YGEdge.Horizontal),
                            Vertical = Interop.YGNodeStyleGetPosition(node.GetHandle(), YGEdge.Vertical),
                            All = Interop.YGNodeStyleGetPosition(node.GetHandle(), YGEdge.All),
                        },

                        margin = new
                        {
                            Left = Interop.YGNodeStyleGetMargin(node.GetHandle(), YGEdge.Left),
                            Right = Interop.YGNodeStyleGetMargin(node.GetHandle(), YGEdge.Right),
                            Top = Interop.YGNodeStyleGetMargin(node.GetHandle(), YGEdge.Top),
                            Bottom = Interop.YGNodeStyleGetMargin(node.GetHandle(), YGEdge.Bottom),
                            Horizontal = Interop.YGNodeStyleGetMargin(node.GetHandle(), YGEdge.Horizontal),
                            Vertical = Interop.YGNodeStyleGetMargin(node.GetHandle(), YGEdge.Vertical),
                            All = Interop.YGNodeStyleGetMargin(node.GetHandle(), YGEdge.All),
                        },

                        padding = new
                        {
                            Left = Interop.YGNodeStyleGetMargin(node.GetHandle(), YGEdge.Left),
                            Right = Interop.YGNodeStyleGetMargin(node.GetHandle(), YGEdge.Right),
                            Top = Interop.YGNodeStyleGetMargin(node.GetHandle(), YGEdge.Top),
                            Bottom = Interop.YGNodeStyleGetMargin(node.GetHandle(), YGEdge.Bottom),
                            Horizontal = Interop.YGNodeStyleGetMargin(node.GetHandle(), YGEdge.Horizontal),
                            Vertical = Interop.YGNodeStyleGetMargin(node.GetHandle(), YGEdge.Vertical),
                            All = Interop.YGNodeStyleGetMargin(node.GetHandle(), YGEdge.All),
                        },

                        border = new
                        {
                            Left = Interop.YGNodeStyleGetBorder(node.GetHandle(), YGEdge.Left),
                            Right = Interop.YGNodeStyleGetBorder(node.GetHandle(), YGEdge.Right),
                            Top = Interop.YGNodeStyleGetBorder(node.GetHandle(), YGEdge.Top),
                            Bottom = Interop.YGNodeStyleGetBorder(node.GetHandle(), YGEdge.Bottom),
                            Horizontal = Interop.YGNodeStyleGetBorder(node.GetHandle(), YGEdge.Horizontal),
                            Vertical = Interop.YGNodeStyleGetBorder(node.GetHandle(), YGEdge.Vertical),
                            All = Interop.YGNodeStyleGetBorder(node.GetHandle(), YGEdge.All),
                        },

                        gap = new
                        {
                            Column = Interop.YGNodeStyleGetGap(node.GetHandle(), YGGutter.Column),
                            Row = Interop.YGNodeStyleGetGap(node.GetHandle(), YGGutter.Row),
                            All = Interop.YGNodeStyleGetGap(node.GetHandle(), YGGutter.All),
                        },

                        aspectRatio = Interop.YGNodeStyleGetAspectRatio(node.GetHandle()),
                        width = Interop.YGNodeStyleGetWidth(node.GetHandle()),
                        height = Interop.YGNodeStyleGetHeight(node.GetHandle()),
                        minWidth = Interop.YGNodeStyleGetMinWidth(node.GetHandle()),
                        minHeight = Interop.YGNodeStyleGetMinWidth(node.GetHandle()),
                        maxWidth = Interop.YGNodeStyleGetMaxWidth(node.GetHandle()),
                        maxHeight = Interop.YGNodeStyleGetMaxHeight(node.GetHandle()),
                    }, SerializerOptions());
                }

                return null;
            }
        }
    }
}
