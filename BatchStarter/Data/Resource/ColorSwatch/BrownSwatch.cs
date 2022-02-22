using BatchStarter.Data.Resource.Helper;
using System.Collections.Generic;
using System.Windows.Media;

namespace BatchStarter.Data.Resource.ColorSwatch
{
    internal class BrownSwatch : ISwatch
    {
        public static Color Brown50 { get; } = (Color)ColorConverter.ConvertFromString("#EFEBE9");
        public static Color Brown100 { get; } = (Color)ColorConverter.ConvertFromString("#D7CCC8");
        public static Color Brown200 { get; } = (Color)ColorConverter.ConvertFromString("#BCAAA4");
        public static Color Brown300 { get; } = (Color)ColorConverter.ConvertFromString("#A1887F");
        public static Color Brown400 { get; } = (Color)ColorConverter.ConvertFromString("#8D6E63");
        public static Color Brown500 { get; } = (Color)ColorConverter.ConvertFromString("#795548");
        public static Color Brown600 { get; } = (Color)ColorConverter.ConvertFromString("#6D4C41");
        public static Color Brown700 { get; } = (Color)ColorConverter.ConvertFromString("#5D4037");
        public static Color Brown800 { get; } = (Color)ColorConverter.ConvertFromString("#4E342E");
        public static Color Brown900 { get; } = (Color)ColorConverter.ConvertFromString("#3E2723");

        public string Name { get; } = "Brown";

        public IDictionary<ColorEnum, Color> Lookup { get; } = new Dictionary<ColorEnum, Color>
        {
            { ColorEnum.Brown50, Brown50 },
            { ColorEnum.Brown100, Brown100 },
            { ColorEnum.Brown200, Brown200 },
            { ColorEnum.Brown300, Brown300 },
            { ColorEnum.Brown400, Brown400 },
            { ColorEnum.Brown500, Brown500 },
            { ColorEnum.Brown600, Brown600 },
            { ColorEnum.Brown700, Brown700 },
            { ColorEnum.Brown800, Brown800 },
            { ColorEnum.Brown900, Brown900 },
        };

        public IEnumerable<Color> Hues => Lookup.Values;
    }
}
