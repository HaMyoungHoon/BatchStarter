using BatchStarter.Data.Resource.Helper;
using System.Collections.Generic;
using System.Windows.Media;

namespace BatchStarter.Data.Resource.ColorSwatch
{
    internal class DeepPurpleSwatch : ISwatch
    {
        public static Color DeepPurple50 { get; } = (Color)ColorConverter.ConvertFromString("#EDE7F6");
        public static Color DeepPurple100 { get; } = (Color)ColorConverter.ConvertFromString("#D1C4E9");
        public static Color DeepPurple200 { get; } = (Color)ColorConverter.ConvertFromString("#B39DDB");
        public static Color DeepPurple300 { get; } = (Color)ColorConverter.ConvertFromString("#9575CD");
        public static Color DeepPurple400 { get; } = (Color)ColorConverter.ConvertFromString("#7E57C2");
        public static Color DeepPurple500 { get; } = (Color)ColorConverter.ConvertFromString("#673AB7");
        public static Color DeepPurple600 { get; } = (Color)ColorConverter.ConvertFromString("#5E35B1");
        public static Color DeepPurple700 { get; } = (Color)ColorConverter.ConvertFromString("#512DA8");
        public static Color DeepPurple800 { get; } = (Color)ColorConverter.ConvertFromString("#4527A0");
        public static Color DeepPurple900 { get; } = (Color)ColorConverter.ConvertFromString("#311B92");
        public static Color DeepPurpleA100 { get; } = (Color)ColorConverter.ConvertFromString("#B388FF");
        public static Color DeepPurpleA200 { get; } = (Color)ColorConverter.ConvertFromString("#7C4DFF");
        public static Color DeepPurpleA400 { get; } = (Color)ColorConverter.ConvertFromString("#651FFF");
        public static Color DeepPurpleA700 { get; } = (Color)ColorConverter.ConvertFromString("#6200EA");

        public string Name { get; } = "Deep Purple";

        public IDictionary<ColorEnum, Color> Lookup { get; } = new Dictionary<ColorEnum, Color>
        {
            { ColorEnum.DeepPurple50, DeepPurple50 },
            { ColorEnum.DeepPurple100, DeepPurple100 },
            { ColorEnum.DeepPurple200, DeepPurple200 },
            { ColorEnum.DeepPurple300, DeepPurple300 },
            { ColorEnum.DeepPurple400, DeepPurple400 },
            { ColorEnum.DeepPurple500, DeepPurple500 },
            { ColorEnum.DeepPurple600, DeepPurple600 },
            { ColorEnum.DeepPurple700, DeepPurple700 },
            { ColorEnum.DeepPurple800, DeepPurple800 },
            { ColorEnum.DeepPurple900, DeepPurple900 },
            { ColorEnum.DeepPurpleA100, DeepPurpleA100 },
            { ColorEnum.DeepPurpleA200, DeepPurpleA200 },
            { ColorEnum.DeepPurpleA400, DeepPurpleA400 },
            { ColorEnum.DeepPurpleA700, DeepPurpleA700 },
        };

        public IEnumerable<Color> Hues => Lookup.Values;
    }
}
