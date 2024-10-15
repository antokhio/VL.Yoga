using System.Runtime.InteropServices;

namespace VL.Yoga
{
    [StructLayout(LayoutKind.Sequential)]
    public struct YGValue
    {
        public float value;
        public YGUnit unit;

        public static YGValue Undefined
            => new() { value = float.NaN, unit = YGUnit.Undefined };

        public static YGValue Auto
            => new() { value = float.NaN, unit = YGUnit.Auto };

        public static YGValue Percent(float value)
            => new() { value = value, unit = YGUnit.Percent };

        public static YGValue Point(float value)
            => new() { value = value, unit = YGUnit.Point };

        public static implicit operator YGValue(float value) => Point(value);

        public override string ToString()
        {
            return unit switch
            {
                YGUnit.Auto => "Auto",
                YGUnit.Point => $"{value}",
                YGUnit.Percent => $"{value}%",
                _ => "Undefined"
            };
        }
    }
}
