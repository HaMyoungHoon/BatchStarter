using System.Collections.Generic;
using System.Windows.Media;

namespace BatchStarter.Data.Resource.Helper
{
    internal class AmberSwatch : ISwatch
    {
        public static Color Amber50 { get; } = (Color)ColorConverter.ConvertFromString("#FFF8E1");
        public static Color Amber100 { get; } = (Color)ColorConverter.ConvertFromString("#FFECB3");
        public static Color Amber200 { get; } = (Color)ColorConverter.ConvertFromString("#FFE082");
        public static Color Amber300 { get; } = (Color)ColorConverter.ConvertFromString("#FFD54F");
        public static Color Amber400 { get; } = (Color)ColorConverter.ConvertFromString("#FFCA28");
        public static Color Amber500 { get; } = (Color)ColorConverter.ConvertFromString("#FFC107");
        public static Color Amber600 { get; } = (Color)ColorConverter.ConvertFromString("#FFB300");
        public static Color Amber700 { get; } = (Color)ColorConverter.ConvertFromString("#FFA000");
        public static Color Amber800 { get; } = (Color)ColorConverter.ConvertFromString("#FF8F00");
        public static Color Amber900 { get; } = (Color)ColorConverter.ConvertFromString("#FF6F00");
        public static Color AmberA100 { get; } = (Color)ColorConverter.ConvertFromString("#FFE57F");
        public static Color AmberA200 { get; } = (Color)ColorConverter.ConvertFromString("#FFD740");
        public static Color AmberA400 { get; } = (Color)ColorConverter.ConvertFromString("#FFC400");
        public static Color AmberA700 { get; } = (Color)ColorConverter.ConvertFromString("#FFAB00");

        public string Name { get; } = "Amber";

        public IDictionary<ColorEnum, Color> Lookup { get; } = new Dictionary<ColorEnum, Color>
        {
            { ColorEnum.Amber50, Amber50 },
            { ColorEnum.Amber100, Amber100 },
            { ColorEnum.Amber200, Amber200 },
            { ColorEnum.Amber300, Amber300 },
            { ColorEnum.Amber400, Amber400 },
            { ColorEnum.Amber500, Amber500 },
            { ColorEnum.Amber600, Amber600 },
            { ColorEnum.Amber700, Amber700 },
            { ColorEnum.Amber800, Amber800 },
            { ColorEnum.Amber900, Amber900 },
            { ColorEnum.AmberA100, AmberA100 },
            { ColorEnum.AmberA200, AmberA200 },
            { ColorEnum.AmberA400, AmberA400 },
            { ColorEnum.AmberA700, AmberA700 },
        };

        public IEnumerable<Color> Hues => Lookup.Values;
    }
}
