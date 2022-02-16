using System.Windows;

namespace BatchStarter.Data.Resource.Converters
{
    internal class BooleanToVisibilityConverter : BooleanConverter<Visibility>
    {
        public BooleanToVisibilityConverter() : base(Visibility.Visible, Visibility.Collapsed)
        {
        }
    }
}
