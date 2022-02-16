using System.Collections.Generic;
using System.Windows.Media;

namespace BatchStarter.Data.Resource.Helper
{
    internal class RedSwatch : ISwatch
    {
        public static Color Red50 { get; } = (Color)ColorConverter.ConvertFromString("#FFEBEE");
        public static Color Red100 { get; } = (Color)ColorConverter.ConvertFromString("#FFCDD2");
        public static Color Red200 { get; } = (Color)ColorConverter.ConvertFromString("#EF9A9A");
        public static Color Red300 { get; } = (Color)ColorConverter.ConvertFromString("#E57373");
        public static Color Red400 { get; } = (Color)ColorConverter.ConvertFromString("#EF5350");
        public static Color Red500 { get; } = (Color)ColorConverter.ConvertFromString("#F44336");
        public static Color Red600 { get; } = (Color)ColorConverter.ConvertFromString("#E53935");
        public static Color Red700 { get; } = (Color)ColorConverter.ConvertFromString("#D32F2F");
        public static Color Red800 { get; } = (Color)ColorConverter.ConvertFromString("#C62828");
        public static Color Red900 { get; } = (Color)ColorConverter.ConvertFromString("#B71C1C");
        public static Color RedA100 { get; } = (Color)ColorConverter.ConvertFromString("#FF8A80");
        public static Color RedA200 { get; } = (Color)ColorConverter.ConvertFromString("#FF5252");
        public static Color RedA400 { get; } = (Color)ColorConverter.ConvertFromString("#FF1744");
        public static Color RedA700 { get; } = (Color)ColorConverter.ConvertFromString("#D50000");

        public string Name { get; } = "Red";

        public IDictionary<ColorEnum, Color> Lookup { get; } = new Dictionary<ColorEnum, Color>
        {
            { ColorEnum.Red50, Red50 },
            { ColorEnum.Red100, Red100 },
            { ColorEnum.Red200, Red200 },
            { ColorEnum.Red300, Red300 },
            { ColorEnum.Red400, Red400 },
            { ColorEnum.Red500, Red500 },
            { ColorEnum.Red600, Red600 },
            { ColorEnum.Red700, Red700 },
            { ColorEnum.Red800, Red800 },
            { ColorEnum.Red900, Red900 },
            { ColorEnum.RedA100, RedA100 },
            { ColorEnum.RedA200, RedA200 },
            { ColorEnum.RedA400, RedA400 },
            { ColorEnum.RedA700, RedA700 },
        };

        public IEnumerable<Color> Hues => Lookup.Values;
    }
}
