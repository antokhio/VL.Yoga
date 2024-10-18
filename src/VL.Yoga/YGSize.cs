using Stride.Core.Mathematics;
using YogaSharp;

namespace VL.Yoga
{
    public static class Extensions
    {
        public static YGSize YGSize(Vector2 size) => new()
        {
            Width = size.X,
            Height = size.Y
        };

        public static Vector2 Vector2(YGSize size) => new Vector2(size.Width, size.Height);
    }
}

