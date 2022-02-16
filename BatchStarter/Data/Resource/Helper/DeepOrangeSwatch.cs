using System.Collections.Generic;
using System.Windows.Media;

namespace BatchStarter.Data.Resource.Helper
{
    internal class DeepOrangeSwatch : ISwatch
    {
        public static Color DeepOrange50 { get; } = (Color)ColorConverter.ConvertFromString("#FBE9E7");
        public static Color DeepOrange100 { get; } = (Color)ColorConverter.ConvertFromString("#FFCCBC");
        public static Color DeepOrange200 { get; } = (Color)ColorConverter.ConvertFromString("#FFAB91");
        public static Color DeepOrange300 { get; } = (Color)ColorConverter.ConvertFromString("#FF8A65");
        public static Color DeepOrange400 { get; } = (Color)ColorConverter.ConvertFromString("#FF7043");
        public static Color DeepOrange500 { get; } = (Color)ColorConverter.ConvertFromString("#FF5722");
        public static Color DeepOrange600 { get; } = (Color)ColorConverter.ConvertFromString("#F4511E");
        public static Color DeepOrange700 { get; } = (Color)ColorConverter.ConvertFromString("#E64A19");
        public static Color DeepOrange800 { get; } = (Color)ColorConverter.ConvertFromString("#D84315");
        public static Color DeepOrange900 { get; } = (Color)ColorConverter.ConvertFromString("#BF360C");
        public static Color DeepOrangeA100 { get; } = (Color)ColorConverter.ConvertFromString("#FF9E80");
        public static Color DeepOrangeA200 { get; } = (Color)ColorConverter.ConvertFromString("#FF6E40");
        public static Color DeepOrangeA400 { get; } = (Color)ColorConverter.ConvertFromString("#FF3D00");
        public static Color DeepOrangeA700 { get; } = (Color)ColorConverter.ConvertFromString("#DD2C00");

        public string Name { get; } = "Deep Orange";

        public IDictionary<ColorEnum, Color> Lookup { get; } = new Dictionary<ColorEnum, Color>
        {
            { ColorEnum.DeepOrange50, DeepOrange50 },
            { ColorEnum.DeepOrange100, DeepOrange100 },
            { ColorEnum.DeepOrange200, DeepOrange200 },
            { ColorEnum.DeepOrange300, DeepOrange300 },
            { ColorEnum.DeepOrange400, DeepOrange400 },
            { ColorEnum.DeepOrange500, DeepOrange500 },
            { ColorEnum.DeepOrange600, DeepOrange600 },
            { ColorEnum.DeepOrange700, DeepOrange700 },
            { ColorEnum.DeepOrange800, DeepOrange800 },
            { ColorEnum.DeepOrange900, DeepOrange900 },
            { ColorEnum.DeepOrangeA100, DeepOrangeA100 },
            { ColorEnum.DeepOrangeA200, DeepOrangeA200 },
            { ColorEnum.DeepOrangeA400, DeepOrangeA400 },
            { ColorEnum.DeepOrangeA700, DeepOrangeA700 },
        };

        public IEnumerable<Color> Hues => Lookup.Values;
    }
}
