using BatchStarter.Data.Resource.Helper;
using System.Collections.Generic;
using System.Windows.Media;

namespace BatchStarter.Data.Resource.ColorSwatch
{
    internal class GreySwatch : ISwatch
    {
        public static Color Grey50 { get; } = (Color)ColorConverter.ConvertFromString("#FAFAFA");
        public static Color Grey100 { get; } = (Color)ColorConverter.ConvertFromString("#F5F5F5");
        public static Color Grey200 { get; } = (Color)ColorConverter.ConvertFromString("#EEEEEE");
        public static Color Grey300 { get; } = (Color)ColorConverter.ConvertFromString("#E0E0E0");
        public static Color Grey400 { get; } = (Color)ColorConverter.ConvertFromString("#BDBDBD");
        public static Color Grey500 { get; } = (Color)ColorConverter.ConvertFromString("#9E9E9E");
        public static Color Grey600 { get; } = (Color)ColorConverter.ConvertFromString("#757575");
        public static Color Grey700 { get; } = (Color)ColorConverter.ConvertFromString("#616161");
        public static Color Grey800 { get; } = (Color)ColorConverter.ConvertFromString("#424242");
        public static Color Grey900 { get; } = (Color)ColorConverter.ConvertFromString("#212121");

        public string Name { get; } = "Grey";

        public IDictionary<ColorEnum, Color> Lookup { get; } = new Dictionary<ColorEnum, Color>
        {
            { ColorEnum.Grey50, Grey50 },
            { ColorEnum.Grey100, Grey100 },
            { ColorEnum.Grey200, Grey200 },
            { ColorEnum.Grey300, Grey300 },
            { ColorEnum.Grey400, Grey400 },
            { ColorEnum.Grey500, Grey500 },
            { ColorEnum.Grey600, Grey600 },
            { ColorEnum.Grey700, Grey700 },
            { ColorEnum.Grey800, Grey800 },
            { ColorEnum.Grey900, Grey900 },
        };

        public IEnumerable<Color> Hues => Lookup.Values;
    }
}
