using System.Collections.Generic;
using System.Windows.Media;

namespace BatchStarter.Data.Resource.Helper
{
    internal interface ISwatch
    {
        string Name { get; }
        IEnumerable<Color> Hues { get; }
        IDictionary<ColorEnum, Color> Lookup { get; }
    }
}
