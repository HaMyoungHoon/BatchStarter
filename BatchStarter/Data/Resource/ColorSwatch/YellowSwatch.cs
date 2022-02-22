using BatchStarter.Data.Resource.Helper;
using System.Collections.Generic;
using System.Windows.Media;

namespace BatchStarter.Data.Resource.ColorSwatch
{
    internal class YellowSwatch : ISwatch
    {
        public static Color Yellow50 { get; } = (Color)ColorConverter.ConvertFromString("#FFFDE7");
        public static Color Yellow100 { get; } = (Color)ColorConverter.ConvertFromString("#FFF9C4");
        public static Color Yellow200 { get; } = (Color)ColorConverter.ConvertFromString("#FFF59D");
        public static Color Yellow300 { get; } = (Color)ColorConverter.ConvertFromString("#FFF176");
        public static Color Yellow400 { get; } = (Color)ColorConverter.ConvertFromString("#FFEE58");
        public static Color Yellow500 { get; } = (Color)ColorConverter.ConvertFromString("#FFEB3B");
        public static Color Yellow600 { get; } = (Color)ColorConverter.ConvertFromString("#FDD835");
        public static Color Yellow700 { get; } = (Color)ColorConverter.ConvertFromString("#FBC02D");
        public static Color Yellow800 { get; } = (Color)ColorConverter.ConvertFromString("#F9A825");
        public static Color Yellow900 { get; } = (Color)ColorConverter.ConvertFromString("#F57F17");
        public static Color YellowA100 { get; } = (Color)ColorConverter.ConvertFromString("#FFFF8D");
        public static Color YellowA200 { get; } = (Color)ColorConverter.ConvertFromString("#FFFF00");
        public static Color YellowA400 { get; } = (Color)ColorConverter.ConvertFromString("#FFEA00");
        public static Color YellowA700 { get; } = (Color)ColorConverter.ConvertFromString("#FFD600");

        public string Name { get; } = "Yellow";

        public IDictionary<ColorEnum, Color> Lookup { get; } = new Dictionary<ColorEnum, Color>
        {
            { ColorEnum.Yellow50, Yellow50 },
            { ColorEnum.Yellow100, Yellow100 },
            { ColorEnum.Yellow200, Yellow200 },
            { ColorEnum.Yellow300, Yellow300 },
            { ColorEnum.Yellow400, Yellow400 },
            { ColorEnum.Yellow500, Yellow500 },
            { ColorEnum.Yellow600, Yellow600 },
            { ColorEnum.Yellow700, Yellow700 },
            { ColorEnum.Yellow800, Yellow800 },
            { ColorEnum.Yellow900, Yellow900 },
            { ColorEnum.YellowA100, YellowA100 },
            { ColorEnum.YellowA200, YellowA200 },
            { ColorEnum.YellowA400, YellowA400 },
            { ColorEnum.YellowA700, YellowA700 },
        };

        public IEnumerable<Color> Hues => Lookup.Values;
    }
}
