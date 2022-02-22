using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace BatchStarter.Data.Resource.Converters
{
    internal class FontSizeToHintOffsetConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var fontSize = System.Convert.ToDouble(value);
            var hintOffset = fontSize / 2 + 12;
            return new Point(0, -hintOffset);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
