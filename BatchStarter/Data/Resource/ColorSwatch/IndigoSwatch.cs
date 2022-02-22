using BatchStarter.Data.Resource.Helper;
using System.Collections.Generic;
using System.Windows.Media;

namespace BatchStarter.Data.Resource.ColorSwatch
{
    internal class IndigoSwatch : ISwatch
    {
        public static Color Indigo50 { get; } = (Color)ColorConverter.ConvertFromString("#E8EAF6");
        public static Color Indigo100 { get; } = (Color)ColorConverter.ConvertFromString("#C5CAE9");
        public static Color Indigo200 { get; } = (Color)ColorConverter.ConvertFromString("#9FA8DA");
        public static Color Indigo300 { get; } = (Color)ColorConverter.ConvertFromString("#7986CB");
        public static Color Indigo400 { get; } = (Color)ColorConverter.ConvertFromString("#5C6BC0");
        public static Color Indigo500 { get; } = (Color)ColorConverter.ConvertFromString("#3F51B5");
        public static Color Indigo600 { get; } = (Color)ColorConverter.ConvertFromString("#3949AB");
        public static Color Indigo700 { get; } = (Color)ColorConverter.ConvertFromString("#303F9F");
        public static Color Indigo800 { get; } = (Color)ColorConverter.ConvertFromString("#283593");
        public static Color Indigo900 { get; } = (Color)ColorConverter.ConvertFromString("#1A237E");
        public static Color IndigoA100 { get; } = (Color)ColorConverter.ConvertFromString("#8C9EFF");
        public static Color IndigoA200 { get; } = (Color)ColorConverter.ConvertFromString("#536DFE");
        public static Color IndigoA400 { get; } = (Color)ColorConverter.ConvertFromString("#3D5AFE");
        public static Color IndigoA700 { get; } = (Color)ColorConverter.ConvertFromString("#304FFE");

        public string Name { get; } = "Indigo";

        public IDictionary<ColorEnum, Color> Lookup { get; } = new Dictionary<ColorEnum, Color>
        {
            { ColorEnum.Indigo50, Indigo50 },
            { ColorEnum.Indigo100, Indigo100 },
            { ColorEnum.Indigo200, Indigo200 },
            { ColorEnum.Indigo300, Indigo300 },
            { ColorEnum.Indigo400, Indigo400 },
            { ColorEnum.Indigo500, Indigo500 },
            { ColorEnum.Indigo600, Indigo600 },
            { ColorEnum.Indigo700, Indigo700 },
            { ColorEnum.Indigo800, Indigo800 },
            { ColorEnum.Indigo900, Indigo900 },
            { ColorEnum.IndigoA100, IndigoA100 },
            { ColorEnum.IndigoA200, IndigoA200 },
            { ColorEnum.IndigoA400, IndigoA400 },
            { ColorEnum.IndigoA700, IndigoA700 },
        };

        public IEnumerable<Color> Hues => Lookup.Values;
    }
}
