using System;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;

namespace BatchStarter.Data.Resource.Converters
{
    internal class HintProxyFabricConverter : IValueConverter
    {
        private static readonly Lazy<HintProxyFabricConverter> _instance = new();

        public static HintProxyFabricConverter Instance => _instance.Value;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return HintProxyFabric.Get((Control)value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }
}
