using System.Collections.Generic;
using System.Windows.Media;

namespace BatchStarter.Data.Resource.Helper
{
    internal class CyanSwatch : ISwatch
    {
        public static Color Cyan50 { get; } = (Color)ColorConverter.ConvertFromString("#E0F7FA");
        public static Color Cyan100 { get; } = (Color)ColorConverter.ConvertFromString("#B2EBF2");
        public static Color Cyan200 { get; } = (Color)ColorConverter.ConvertFromString("#80DEEA");
        public static Color Cyan300 { get; } = (Color)ColorConverter.ConvertFromString("#4DD0E1");
        public static Color Cyan400 { get; } = (Color)ColorConverter.ConvertFromString("#26C6DA");
        public static Color Cyan500 { get; } = (Color)ColorConverter.ConvertFromString("#00BCD4");
        public static Color Cyan600 { get; } = (Color)ColorConverter.ConvertFromString("#00ACC1");
        public static Color Cyan700 { get; } = (Color)ColorConverter.ConvertFromString("#0097A7");
        public static Color Cyan800 { get; } = (Color)ColorConverter.ConvertFromString("#00838F");
        public static Color Cyan900 { get; } = (Color)ColorConverter.ConvertFromString("#006064");
        public static Color CyanA100 { get; } = (Color)ColorConverter.ConvertFromString("#84FFFF");
        public static Color CyanA200 { get; } = (Color)ColorConverter.ConvertFromString("#18FFFF");
        public static Color CyanA400 { get; } = (Color)ColorConverter.ConvertFromString("#00E5FF");
        public static Color CyanA700 { get; } = (Color)ColorConverter.ConvertFromString("#00B8D4");

        public string Name { get; } = "Cyan";

        public IDictionary<ColorEnum, Color> Lookup { get; } = new Dictionary<ColorEnum, Color>
        {
            { ColorEnum.Cyan50, Cyan50 },
            { ColorEnum.Cyan100, Cyan100 },
            { ColorEnum.Cyan200, Cyan200 },
            { ColorEnum.Cyan300, Cyan300 },
            { ColorEnum.Cyan400, Cyan400 },
            { ColorEnum.Cyan500, Cyan500 },
            { ColorEnum.Cyan600, Cyan600 },
            { ColorEnum.Cyan700, Cyan700 },
            { ColorEnum.Cyan800, Cyan800 },
            { ColorEnum.Cyan900, Cyan900 },
            { ColorEnum.CyanA100, CyanA100 },
            { ColorEnum.CyanA200, CyanA200 },
            { ColorEnum.CyanA400, CyanA400 },
            { ColorEnum.CyanA700, CyanA700 },
        };

        public IEnumerable<Color> Hues => Lookup.Values;
    }
}
