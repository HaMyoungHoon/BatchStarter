using BatchStarter.Data.Resource.Helper;
using System.Collections.Generic;
using System.Windows.Media;

namespace BatchStarter.Data.Resource.ColorSwatch
{
    internal class BlueSwatch : ISwatch
    {
        public static Color Blue50 { get; } = (Color)ColorConverter.ConvertFromString("#E3F2FD");
        public static Color Blue100 { get; } = (Color)ColorConverter.ConvertFromString("#BBDEFB");
        public static Color Blue200 { get; } = (Color)ColorConverter.ConvertFromString("#90CAF9");
        public static Color Blue300 { get; } = (Color)ColorConverter.ConvertFromString("#64B5F6");
        public static Color Blue400 { get; } = (Color)ColorConverter.ConvertFromString("#42A5F5");
        public static Color Blue500 { get; } = (Color)ColorConverter.ConvertFromString("#2196F3");
        public static Color Blue600 { get; } = (Color)ColorConverter.ConvertFromString("#1E88E5");
        public static Color Blue700 { get; } = (Color)ColorConverter.ConvertFromString("#1976D2");
        public static Color Blue800 { get; } = (Color)ColorConverter.ConvertFromString("#1565C0");
        public static Color Blue900 { get; } = (Color)ColorConverter.ConvertFromString("#0D47A1");
        public static Color BlueA100 { get; } = (Color)ColorConverter.ConvertFromString("#82B1FF");
        public static Color BlueA200 { get; } = (Color)ColorConverter.ConvertFromString("#448AFF");
        public static Color BlueA400 { get; } = (Color)ColorConverter.ConvertFromString("#2979FF");
        public static Color BlueA700 { get; } = (Color)ColorConverter.ConvertFromString("#2962FF");

        public string Name { get; } = "Blue";

        public IDictionary<ColorEnum, Color> Lookup { get; } = new Dictionary<ColorEnum, Color>
        {
            { ColorEnum.Blue50, Blue50 },
            { ColorEnum.Blue100, Blue100 },
            { ColorEnum.Blue200, Blue200 },
            { ColorEnum.Blue300, Blue300 },
            { ColorEnum.Blue400, Blue400 },
            { ColorEnum.Blue500, Blue500 },
            { ColorEnum.Blue600, Blue600 },
            { ColorEnum.Blue700, Blue700 },
            { ColorEnum.Blue800, Blue800 },
            { ColorEnum.Blue900, Blue900 },
            { ColorEnum.BlueA100, BlueA100 },
            { ColorEnum.BlueA200, BlueA200 },
            { ColorEnum.BlueA400, BlueA400 },
            { ColorEnum.BlueA700, BlueA700 },
        };

        public IEnumerable<Color> Hues => Lookup.Values;
    }
}
