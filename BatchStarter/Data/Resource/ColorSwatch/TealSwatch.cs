using BatchStarter.Data.Resource.Helper;
using System.Collections.Generic;
using System.Windows.Media;

namespace BatchStarter.Data.Resource.ColorSwatch
{
    internal class TealSwatch : ISwatch
    {
        public static Color Teal50 { get; } = (Color)ColorConverter.ConvertFromString("#E0F2F1");
        public static Color Teal100 { get; } = (Color)ColorConverter.ConvertFromString("#B2DFDB");
        public static Color Teal200 { get; } = (Color)ColorConverter.ConvertFromString("#80CBC4");
        public static Color Teal300 { get; } = (Color)ColorConverter.ConvertFromString("#4DB6AC");
        public static Color Teal400 { get; } = (Color)ColorConverter.ConvertFromString("#26A69A");
        public static Color Teal500 { get; } = (Color)ColorConverter.ConvertFromString("#009688");
        public static Color Teal600 { get; } = (Color)ColorConverter.ConvertFromString("#00897B");
        public static Color Teal700 { get; } = (Color)ColorConverter.ConvertFromString("#00796B");
        public static Color Teal800 { get; } = (Color)ColorConverter.ConvertFromString("#00695C");
        public static Color Teal900 { get; } = (Color)ColorConverter.ConvertFromString("#004D40");
        public static Color TealA100 { get; } = (Color)ColorConverter.ConvertFromString("#A7FFEB");
        public static Color TealA200 { get; } = (Color)ColorConverter.ConvertFromString("#64FFDA");
        public static Color TealA400 { get; } = (Color)ColorConverter.ConvertFromString("#1DE9B6");
        public static Color TealA700 { get; } = (Color)ColorConverter.ConvertFromString("#00BFA5");

        public string Name { get; } = "Teal";

        public IDictionary<ColorEnum, Color> Lookup { get; } = new Dictionary<ColorEnum, Color>
        {
            { ColorEnum.Teal50, Teal50 },
            { ColorEnum.Teal100, Teal100 },
            { ColorEnum.Teal200, Teal200 },
            { ColorEnum.Teal300, Teal300 },
            { ColorEnum.Teal400, Teal400 },
            { ColorEnum.Teal500, Teal500 },
            { ColorEnum.Teal600, Teal600 },
            { ColorEnum.Teal700, Teal700 },
            { ColorEnum.Teal800, Teal800 },
            { ColorEnum.Teal900, Teal900 },
            { ColorEnum.TealA100, TealA100 },
            { ColorEnum.TealA200, TealA200 },
            { ColorEnum.TealA400, TealA400 },
            { ColorEnum.TealA700, TealA700 },
        };

        public IEnumerable<Color> Hues => Lookup.Values;
    }
}
