using BatchStarter.Data.Resource.Helper;
using System.Collections.Generic;
using System.Windows.Media;

namespace BatchStarter.Data.Resource.ColorSwatch
{
    internal class PinkSwatch : ISwatch
    {
        public static Color Pink50 { get; } = (Color)ColorConverter.ConvertFromString("#FCE4EC");
        public static Color Pink100 { get; } = (Color)ColorConverter.ConvertFromString("#F8BBD0");
        public static Color Pink200 { get; } = (Color)ColorConverter.ConvertFromString("#F48FB1");
        public static Color Pink300 { get; } = (Color)ColorConverter.ConvertFromString("#F06292");
        public static Color Pink400 { get; } = (Color)ColorConverter.ConvertFromString("#EC407A");
        public static Color Pink500 { get; } = (Color)ColorConverter.ConvertFromString("#E91E63");
        public static Color Pink600 { get; } = (Color)ColorConverter.ConvertFromString("#D81B60");
        public static Color Pink700 { get; } = (Color)ColorConverter.ConvertFromString("#C2185B");
        public static Color Pink800 { get; } = (Color)ColorConverter.ConvertFromString("#AD1457");
        public static Color Pink900 { get; } = (Color)ColorConverter.ConvertFromString("#880E4F");
        public static Color PinkA100 { get; } = (Color)ColorConverter.ConvertFromString("#FF80AB");
        public static Color PinkA200 { get; } = (Color)ColorConverter.ConvertFromString("#FF4081");
        public static Color PinkA400 { get; } = (Color)ColorConverter.ConvertFromString("#F50057");
        public static Color PinkA700 { get; } = (Color)ColorConverter.ConvertFromString("#C51162");

        public string Name { get; } = "Pink";

        public IDictionary<ColorEnum, Color> Lookup { get; } = new Dictionary<ColorEnum, Color>
        {
            { ColorEnum.Pink50, Pink50 },
            { ColorEnum.Pink100, Pink100 },
            { ColorEnum.Pink200, Pink200 },
            { ColorEnum.Pink300, Pink300 },
            { ColorEnum.Pink400, Pink400 },
            { ColorEnum.Pink500, Pink500 },
            { ColorEnum.Pink600, Pink600 },
            { ColorEnum.Pink700, Pink700 },
            { ColorEnum.Pink800, Pink800 },
            { ColorEnum.Pink900, Pink900 },
            { ColorEnum.PinkA100, PinkA100 },
            { ColorEnum.PinkA200, PinkA200 },
            { ColorEnum.PinkA400, PinkA400 },
            { ColorEnum.PinkA700, PinkA700 },
        };

        public IEnumerable<Color> Hues => Lookup.Values;
    }
}
