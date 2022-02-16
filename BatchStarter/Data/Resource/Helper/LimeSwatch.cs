using System.Collections.Generic;
using System.Windows.Media;

namespace BatchStarter.Data.Resource.Helper
{
    internal class LimeSwatch : ISwatch
    {
        public static Color Lime50 { get; } = (Color)ColorConverter.ConvertFromString("#F9FBE7");
        public static Color Lime100 { get; } = (Color)ColorConverter.ConvertFromString("#F0F4C3");
        public static Color Lime200 { get; } = (Color)ColorConverter.ConvertFromString("#E6EE9C");
        public static Color Lime300 { get; } = (Color)ColorConverter.ConvertFromString("#DCE775");
        public static Color Lime400 { get; } = (Color)ColorConverter.ConvertFromString("#D4E157");
        public static Color Lime500 { get; } = (Color)ColorConverter.ConvertFromString("#CDDC39");
        public static Color Lime600 { get; } = (Color)ColorConverter.ConvertFromString("#C0CA33");
        public static Color Lime700 { get; } = (Color)ColorConverter.ConvertFromString("#AFB42B");
        public static Color Lime800 { get; } = (Color)ColorConverter.ConvertFromString("#9E9D24");
        public static Color Lime900 { get; } = (Color)ColorConverter.ConvertFromString("#827717");
        public static Color LimeA100 { get; } = (Color)ColorConverter.ConvertFromString("#F4FF81");
        public static Color LimeA200 { get; } = (Color)ColorConverter.ConvertFromString("#EEFF41");
        public static Color LimeA400 { get; } = (Color)ColorConverter.ConvertFromString("#C6FF00");
        public static Color LimeA700 { get; } = (Color)ColorConverter.ConvertFromString("#AEEA00");

        public string Name { get; } = "Lime";

        public IDictionary<ColorEnum, Color> Lookup { get; } = new Dictionary<ColorEnum, Color>
        {
            { ColorEnum.Lime50, Lime50 },
            { ColorEnum.Lime100, Lime100 },
            { ColorEnum.Lime200, Lime200 },
            { ColorEnum.Lime300, Lime300 },
            { ColorEnum.Lime400, Lime400 },
            { ColorEnum.Lime500, Lime500 },
            { ColorEnum.Lime600, Lime600 },
            { ColorEnum.Lime700, Lime700 },
            { ColorEnum.Lime800, Lime800 },
            { ColorEnum.Lime900, Lime900 },
            { ColorEnum.LimeA100, LimeA100 },
            { ColorEnum.LimeA200, LimeA200 },
            { ColorEnum.LimeA400, LimeA400 },
            { ColorEnum.LimeA700, LimeA700 },
        };

        public IEnumerable<Color> Hues => Lookup.Values;
    }
}
