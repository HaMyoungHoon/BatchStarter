using BatchStarter.Data.Resource.Helper;
using System.Collections.Generic;
using System.Windows.Media;

namespace BatchStarter.Data.Resource.ColorSwatch
{
    internal class LightBlueSwatch : ISwatch
    {
        public static Color LightBlue50 { get; } = (Color)ColorConverter.ConvertFromString("#E1F5FE");
        public static Color LightBlue100 { get; } = (Color)ColorConverter.ConvertFromString("#B3E5FC");
        public static Color LightBlue200 { get; } = (Color)ColorConverter.ConvertFromString("#81D4FA");
        public static Color LightBlue300 { get; } = (Color)ColorConverter.ConvertFromString("#4FC3F7");
        public static Color LightBlue400 { get; } = (Color)ColorConverter.ConvertFromString("#29B6F6");
        public static Color LightBlue500 { get; } = (Color)ColorConverter.ConvertFromString("#03A9F4");
        public static Color LightBlue600 { get; } = (Color)ColorConverter.ConvertFromString("#039BE5");
        public static Color LightBlue700 { get; } = (Color)ColorConverter.ConvertFromString("#0288D1");
        public static Color LightBlue800 { get; } = (Color)ColorConverter.ConvertFromString("#0277BD");
        public static Color LightBlue900 { get; } = (Color)ColorConverter.ConvertFromString("#01579B");
        public static Color LightBlueA100 { get; } = (Color)ColorConverter.ConvertFromString("#80D8FF");
        public static Color LightBlueA200 { get; } = (Color)ColorConverter.ConvertFromString("#40C4FF");
        public static Color LightBlueA400 { get; } = (Color)ColorConverter.ConvertFromString("#00B0FF");
        public static Color LightBlueA700 { get; } = (Color)ColorConverter.ConvertFromString("#0091EA");

        public string Name { get; } = "Light Blue";

        public IDictionary<ColorEnum, Color> Lookup { get; } = new Dictionary<ColorEnum, Color>
        {
            { ColorEnum.LightBlue50, LightBlue50 },
            { ColorEnum.LightBlue100, LightBlue100 },
            { ColorEnum.LightBlue200, LightBlue200 },
            { ColorEnum.LightBlue300, LightBlue300 },
            { ColorEnum.LightBlue400, LightBlue400 },
            { ColorEnum.LightBlue500, LightBlue500 },
            { ColorEnum.LightBlue600, LightBlue600 },
            { ColorEnum.LightBlue700, LightBlue700 },
            { ColorEnum.LightBlue800, LightBlue800 },
            { ColorEnum.LightBlue900, LightBlue900 },
            { ColorEnum.LightBlueA100, LightBlueA100 },
            { ColorEnum.LightBlueA200, LightBlueA200 },
            { ColorEnum.LightBlueA400, LightBlueA400 },
            { ColorEnum.LightBlueA700, LightBlueA700 },
        };

        public IEnumerable<Color> Hues => Lookup.Values;
    }
}
