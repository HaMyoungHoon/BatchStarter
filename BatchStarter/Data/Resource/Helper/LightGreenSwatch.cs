using System.Collections.Generic;
using System.Windows.Media;

namespace BatchStarter.Data.Resource.Helper
{
    internal class LightGreenSwatch : ISwatch
    {
        public static Color LightGreen50 { get; } = (Color)ColorConverter.ConvertFromString("#F1F8E9");
        public static Color LightGreen100 { get; } = (Color)ColorConverter.ConvertFromString("#DCEDC8");
        public static Color LightGreen200 { get; } = (Color)ColorConverter.ConvertFromString("#C5E1A5");
        public static Color LightGreen300 { get; } = (Color)ColorConverter.ConvertFromString("#AED581");
        public static Color LightGreen400 { get; } = (Color)ColorConverter.ConvertFromString("#9CCC65");
        public static Color LightGreen500 { get; } = (Color)ColorConverter.ConvertFromString("#8BC34A");
        public static Color LightGreen600 { get; } = (Color)ColorConverter.ConvertFromString("#7CB342");
        public static Color LightGreen700 { get; } = (Color)ColorConverter.ConvertFromString("#689F38");
        public static Color LightGreen800 { get; } = (Color)ColorConverter.ConvertFromString("#558B2F");
        public static Color LightGreen900 { get; } = (Color)ColorConverter.ConvertFromString("#33691E");
        public static Color LightGreenA100 { get; } = (Color)ColorConverter.ConvertFromString("#CCFF90");
        public static Color LightGreenA200 { get; } = (Color)ColorConverter.ConvertFromString("#B2FF59");
        public static Color LightGreenA400 { get; } = (Color)ColorConverter.ConvertFromString("#76FF03");
        public static Color LightGreenA700 { get; } = (Color)ColorConverter.ConvertFromString("#64DD17");

        public string Name { get; } = "Light Green";

        public IDictionary<ColorEnum, Color> Lookup { get; } = new Dictionary<ColorEnum, Color>
        {
            { ColorEnum.LightGreen50, LightGreen50 },
            { ColorEnum.LightGreen100, LightGreen100 },
            { ColorEnum.LightGreen200, LightGreen200 },
            { ColorEnum.LightGreen300, LightGreen300 },
            { ColorEnum.LightGreen400, LightGreen400 },
            { ColorEnum.LightGreen500, LightGreen500 },
            { ColorEnum.LightGreen600, LightGreen600 },
            { ColorEnum.LightGreen700, LightGreen700 },
            { ColorEnum.LightGreen800, LightGreen800 },
            { ColorEnum.LightGreen900, LightGreen900 },
            { ColorEnum.LightGreenA100, LightGreenA100 },
            { ColorEnum.LightGreenA200, LightGreenA200 },
            { ColorEnum.LightGreenA400, LightGreenA400 },
            { ColorEnum.LightGreenA700, LightGreenA700 },
        };

        public IEnumerable<Color> Hues => Lookup.Values;
    }
}
