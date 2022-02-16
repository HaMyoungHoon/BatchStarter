using System;

namespace BatchStarter.Data.Resource.Helper
{
    internal interface IThemeManager
    {
        event EventHandler<ThemeChangedEventArgs> ThemeChanged;
    }
}
