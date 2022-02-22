using BatchStarter.Data.Resource.Helper;
using System.Collections.Generic;
using System.Windows.Media;

namespace BatchStarter.Data.Resource.ColorSwatch
{
    internal class PurpleSwatch : ISwatch
    {
        public static Color Purple50 { get; } = (Color)ColorConverter.ConvertFromString("#F3E5F5");
        public static Color Purple100 { get; } = (Color)ColorConverter.ConvertFromString("#E1BEE7");
        public static Color Purple200 { get; } = (Color)ColorConverter.ConvertFromString("#CE93D8");
        public static Color Purple300 { get; } = (Color)ColorConverter.ConvertFromString("#BA68C8");
        public static Color Purple400 { get; } = (Color)ColorConverter.ConvertFromString("#AB47BC");
        public static Color Purple500 { get; } = (Color)ColorConverter.ConvertFromString("#9C27B0");
        public static Color Purple600 { get; } = (Color)ColorConverter.ConvertFromString("#8E24AA");
        public static Color Purple700 { get; } = (Color)ColorConverter.ConvertFromString("#7B1FA2");
        public static Color Purple800 { get; } = (Color)ColorConverter.ConvertFromString("#6A1B9A");
        public static Color Purple900 { get; } = (Color)ColorConverter.ConvertFromString("#4A148C");
        public static Color PurpleA100 { get; } = (Color)ColorConverter.ConvertFromString("#EA80FC");
        public static Color PurpleA200 { get; } = (Color)ColorConverter.ConvertFromString("#E040FB");
        public static Color PurpleA400 { get; } = (Color)ColorConverter.ConvertFromString("#D500F9");
        public static Color PurpleA700 { get; } = (Color)ColorConverter.ConvertFromString("#AA00FF");

        public string Name { get; } = "Purple";

        public IDictionary<ColorEnum, Color> Lookup { get; } = new Dictionary<ColorEnum, Color>
        {
            { ColorEnum.Purple50, Purple50 },
            { ColorEnum.Purple100, Purple100 },
            { ColorEnum.Purple200, Purple200 },
            { ColorEnum.Purple300, Purple300 },
            { ColorEnum.Purple400, Purple400 },
            { ColorEnum.Purple500, Purple500 },
            { ColorEnum.Purple600, Purple600 },
            { ColorEnum.Purple700, Purple700 },
            { ColorEnum.Purple800, Purple800 },
            { ColorEnum.Purple900, Purple900 },
            { ColorEnum.PurpleA100, PurpleA100 },
            { ColorEnum.PurpleA200, PurpleA200 },
            { ColorEnum.PurpleA400, PurpleA400 },
            { ColorEnum.PurpleA700, PurpleA700 },
        };

        public IEnumerable<Color> Hues => Lookup.Values;
    }
}
