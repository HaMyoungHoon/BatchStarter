﻿using BatchStarter.Data.Resource.Helper;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;

namespace BatchStarter.Data.Resource
{
    internal class SwatchHelper
    {
        public static IEnumerable<ISwatch> Swatches { get; } = new ISwatch[]
        {
            new RedSwatch(),
            new PinkSwatch(),
            new PurpleSwatch(),
            new DeepPurpleSwatch(),
            new IndigoSwatch(),
            new BlueSwatch(),
            new LightBlueSwatch(),
            new CyanSwatch(),
            new TealSwatch(),
            new GreenSwatch(),
            new LightGreenSwatch(),
            new LimeSwatch(),
            new YellowSwatch(),
            new AmberSwatch(),
            new OrangeSwatch(),
            new DeepOrangeSwatch(),
            new BrownSwatch(),
            new GreySwatch(),
            new BlueGreySwatch(),
        };

        public static IDictionary<ColorEnum, Color> Lookup { get; } = Swatches.SelectMany(o => o.Lookup).ToDictionary(o => o.Key, o => o.Value);
    }
}
