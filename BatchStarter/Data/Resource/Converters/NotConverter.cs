using System;
using System.Globalization;
using System.Windows.Data;

namespace BatchStarter.Data.Resource.Converters
{
    internal class NotConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !(value as bool?) ?? !bool.Parse(value.ToString() ?? "false");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !(value as bool?) ?? !bool.Parse(value.ToString() ?? "false");
        }
    }
}