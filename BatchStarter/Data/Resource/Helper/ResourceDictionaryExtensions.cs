using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace BatchStarter.Data.Resource.Helper
{
    internal static class ResourceDictionaryExtensions
    {
        private static Guid CurrentThemeKey { get; } = Guid.NewGuid();
        private static Guid ThemeManagerKey { get; } = Guid.NewGuid();

        public static void SetTheme(this ResourceDictionary resourceDictionary, ITheme theme)
        {
            if (resourceDictionary == null) throw new ArgumentNullException(nameof(resourceDictionary));

            SetSolidColorBrush(resourceDictionary, "PrimaryHueLightBrush", theme.PrimaryLight.Color);
            SetSolidColorBrush(resourceDictionary, "PrimaryHueLightForegroundBrush", theme.PrimaryLight.ForegroundColor ?? theme.PrimaryLight.Color.ContrastingForegroundColor());
            SetSolidColorBrush(resourceDictionary, "PrimaryHueMidBrush", theme.PrimaryMid.Color);
            SetSolidColorBrush(resourceDictionary, "PrimaryHueMidForegroundBrush", theme.PrimaryMid.ForegroundColor ?? theme.PrimaryMid.Color.ContrastingForegroundColor());
            SetSolidColorBrush(resourceDictionary, "PrimaryHueDarkBrush", theme.PrimaryDark.Color);
            SetSolidColorBrush(resourceDictionary, "PrimaryHueDarkForegroundBrush", theme.PrimaryDark.ForegroundColor ?? theme.PrimaryDark.Color.ContrastingForegroundColor());

            SetSolidColorBrush(resourceDictionary, "SecondaryHueLightBrush", theme.SecondaryLight.Color);
            SetSolidColorBrush(resourceDictionary, "SecondaryHueLightForegroundBrush", theme.SecondaryLight.ForegroundColor ?? theme.SecondaryLight.Color.ContrastingForegroundColor());
            SetSolidColorBrush(resourceDictionary, "SecondaryHueMidBrush", theme.SecondaryMid.Color);
            SetSolidColorBrush(resourceDictionary, "SecondaryHueMidForegroundBrush", theme.SecondaryMid.ForegroundColor ?? theme.SecondaryMid.Color.ContrastingForegroundColor());
            SetSolidColorBrush(resourceDictionary, "SecondaryHueDarkBrush", theme.SecondaryDark.Color);
            SetSolidColorBrush(resourceDictionary, "SecondaryHueDarkForegroundBrush", theme.SecondaryDark.ForegroundColor ?? theme.SecondaryDark.Color.ContrastingForegroundColor());


            //NB: These are here for backwards compatibility, and will be removed in a future version.
            SetSolidColorBrush(resourceDictionary, "SecondaryAccentBrush", theme.SecondaryMid.Color);
            SetSolidColorBrush(resourceDictionary, "SecondaryAccentForegroundBrush", theme.SecondaryMid.ForegroundColor ?? theme.SecondaryMid.Color.ContrastingForegroundColor());

            SetSolidColorBrush(resourceDictionary, "ValidationErrorBrush", theme.ValidationError);
            resourceDictionary["ValidationErrorColor"] = theme.ValidationError;

            SetSolidColorBrush(resourceDictionary, "DefaultBackground", theme.Background);
            SetSolidColorBrush(resourceDictionary, "DefaultForeground", theme.Foreground);
            SetSolidColorBrush(resourceDictionary, "DefaultPaper", theme.Paper);
            SetSolidColorBrush(resourceDictionary, "DefaultCardBackground", theme.CardBackground);
            SetSolidColorBrush(resourceDictionary, "DefaultToolBarBackground", theme.ToolBarBackground);
            SetSolidColorBrush(resourceDictionary, "DefaultBody", theme.Body);
            SetSolidColorBrush(resourceDictionary, "DefaultBodyLight", theme.BodyLight);
            SetSolidColorBrush(resourceDictionary, "DefaultColumnHeader", theme.ColumnHeader);
            SetSolidColorBrush(resourceDictionary, "DefaultCheckBoxOff", theme.CheckBoxOff);
            SetSolidColorBrush(resourceDictionary, "DefaultCheckBoxDisabled", theme.CheckBoxDisabled);
            SetSolidColorBrush(resourceDictionary, "DefaultTextBoxBorder", theme.TextBoxBorder);
            SetSolidColorBrush(resourceDictionary, "DefaultDivider", theme.Divider);
            SetSolidColorBrush(resourceDictionary, "DefaultSelection", theme.Selection);
            SetSolidColorBrush(resourceDictionary, "DefaultToolForeground", theme.ToolForeground);
            SetSolidColorBrush(resourceDictionary, "DefaultToolBackground", theme.ToolBackground);
            SetSolidColorBrush(resourceDictionary, "DefaultFlatButtonClick", theme.FlatButtonClick);
            SetSolidColorBrush(resourceDictionary, "DefaultFlatButtonRipple", theme.FlatButtonRipple);
            SetSolidColorBrush(resourceDictionary, "DefaultToolTipBackground", theme.ToolTipBackground);
            SetSolidColorBrush(resourceDictionary, "DefaultChipBackground", theme.ChipBackground);
            SetSolidColorBrush(resourceDictionary, "DefaultSnackbarBackground", theme.SnackbarBackground);
            SetSolidColorBrush(resourceDictionary, "DefaultSnackbarMouseOver", theme.SnackbarMouseOver);
            SetSolidColorBrush(resourceDictionary, "DefaultSnackbarRipple", theme.SnackbarRipple);
            SetSolidColorBrush(resourceDictionary, "DefaultTextFieldBoxBackground", theme.TextFieldBoxBackground);
            SetSolidColorBrush(resourceDictionary, "DefaultTextFieldBoxHoverBackground", theme.TextFieldBoxHoverBackground);
            SetSolidColorBrush(resourceDictionary, "DefaultTextFieldBoxDisabledBackground", theme.TextFieldBoxDisabledBackground);
            SetSolidColorBrush(resourceDictionary, "DefaultTextAreaBorder", theme.TextAreaBorder);
            SetSolidColorBrush(resourceDictionary, "DefaultTextAreaInactiveBorder", theme.TextAreaInactiveBorder);
            SetSolidColorBrush(resourceDictionary, "DefaultDataGridRowHoverBackground", theme.DataGridRowHoverBackground);

            if (resourceDictionary.GetThemeManager() is not ThemeManager themeManager)
            {
                resourceDictionary[ThemeManagerKey] = themeManager = new ThemeManager(resourceDictionary);
            }
            ITheme oldTheme = resourceDictionary.GetTheme();
            resourceDictionary[CurrentThemeKey] = theme;

            themeManager.OnThemeChange(oldTheme, theme);
        }

        public static ITheme GetTheme(this ResourceDictionary resourceDictionary)
        {
            if (resourceDictionary == null) throw new ArgumentNullException(nameof(resourceDictionary));
            if (resourceDictionary[CurrentThemeKey] is ITheme theme)
            {
                return theme;
            }

            Color secondaryMid = GetColor("SecondaryHueMidBrush", "SecondaryAccentBrush");
            Color secondaryMidForeground = GetColor("SecondaryHueMidForegroundBrush", "SecondaryAccentForegroundBrush");

            if (!TryGetColor("SecondaryHueLightBrush", out Color secondaryLight))
            {
                secondaryLight = secondaryMid.Lighten();
            }
            if (!TryGetColor("SecondaryHueLightForegroundBrush", out Color secondaryLightForeground))
            {
                secondaryLightForeground = secondaryLight.ContrastingForegroundColor();
            }

            if (!TryGetColor("SecondaryHueDarkBrush", out Color secondaryDark))
            {
                secondaryDark = secondaryMid.Darken();
            }
            if (!TryGetColor("SecondaryHueDarkForegroundBrush", out Color secondaryDarkForeground))
            {
                secondaryDarkForeground = secondaryDark.ContrastingForegroundColor();
            }

            //Attempt to simply look up the appropriate resources
            return new Theme
            {
                PrimaryLight = new ColorPair(GetColor("PrimaryHueLightBrush"), GetColor("PrimaryHueLightForegroundBrush")),
                PrimaryMid = new ColorPair(GetColor("PrimaryHueMidBrush"), GetColor("PrimaryHueMidForegroundBrush")),
                PrimaryDark = new ColorPair(GetColor("PrimaryHueDarkBrush"), GetColor("PrimaryHueDarkForegroundBrush")),

                SecondaryLight = new ColorPair(secondaryLight, secondaryLightForeground),
                SecondaryMid = new ColorPair(secondaryMid, secondaryMidForeground),
                SecondaryDark = new ColorPair(secondaryDark, secondaryDarkForeground),

                Background = GetColor("DefaultBackground"),
                Body = GetColor("DefaultBody"),
                BodyLight = GetColor("DefaultBodyLight"),
                CardBackground = GetColor("DefaultCardBackground"),
                CheckBoxDisabled = GetColor("DefaultCheckBoxDisabled"),
                CheckBoxOff = GetColor("DefaultCheckBoxOff"),
                ChipBackground = GetColor("DefaultChipBackground"),
                ColumnHeader = GetColor("DefaultColumnHeader"),
                DataGridRowHoverBackground = GetColor("DefaultDataGridRowHoverBackground"),
                Divider = GetColor("DefaultDivider"),
                FlatButtonClick = GetColor("DefaultFlatButtonClick"),
                FlatButtonRipple = GetColor("DefaultFlatButtonRipple"),
                Selection = GetColor("DefaultSelection"),
                SnackbarBackground = GetColor("DefaultSnackbarBackground"),
                SnackbarMouseOver = GetColor("DefaultSnackbarMouseOver"),
                SnackbarRipple = GetColor("DefaultSnackbarRipple"),
                TextAreaBorder = GetColor("DefaultTextAreaBorder"),
                TextAreaInactiveBorder = GetColor("DefaultTextAreaInactiveBorder"),
                TextBoxBorder = GetColor("DefaultTextBoxBorder"),
                TextFieldBoxBackground = GetColor("DefaultTextFieldBoxBackground"),
                TextFieldBoxDisabledBackground = GetColor("DefaultTextFieldBoxDisabledBackground"),
                TextFieldBoxHoverBackground = GetColor("DefaultTextFieldBoxHoverBackground"),
                ToolBackground = GetColor("DefaultToolBackground"),
                ToolBarBackground = GetColor("DefaultToolBarBackground"),
                ToolForeground = GetColor("DefaultToolForeground"),
                ToolTipBackground = GetColor("DefaultToolTipBackground"),
                Paper = GetColor("DefaultPaper"),
                ValidationError = GetColor("ValidationErrorBrush")
            };

            Color GetColor(params string[] keys)
            {
                foreach (string key in keys)
                {
                    if (TryGetColor(key, out Color color))
                    {
                        return color;
                    }
                }
                throw new InvalidOperationException($"Could not locate required resource with key(s) '{string.Join(", ", keys)}'");
            }

            bool TryGetColor(string key, out Color color)
            {
                if (resourceDictionary[key] is SolidColorBrush brush)
                {
                    color = brush.Color;
                    return true;
                }
                color = default;
                return false;
            }
        }

        public static IThemeManager? GetThemeManager(this ResourceDictionary resourceDictionary)
        {
            if (resourceDictionary == null) throw new ArgumentNullException(nameof(resourceDictionary));
            return resourceDictionary[ThemeManagerKey] as IThemeManager;
        }

        internal static void SetSolidColorBrush(this ResourceDictionary sourceDictionary, string name, Color value)
        {
            if (sourceDictionary == null) throw new ArgumentNullException(nameof(sourceDictionary));
            if (name == null) throw new ArgumentNullException(nameof(name));

            sourceDictionary[name + "Color"] = value;

            if (sourceDictionary[name] is SolidColorBrush brush)
            {
                if (brush.Color == value) return;

                if (!brush.IsFrozen)
                {
                    var animation = new ColorAnimation
                    {
                        From = brush.Color,
                        To = value,
                        Duration = new Duration(TimeSpan.FromMilliseconds(300))
                    };
                    brush.BeginAnimation(SolidColorBrush.ColorProperty, animation);
                    return;
                }
            }

            var newBrush = new SolidColorBrush(value);
            newBrush.Freeze();
            sourceDictionary[name] = newBrush;
        }

        private class ThemeManager : IThemeManager
        {
            private readonly ResourceDictionary _ResourceDictionary;

            public ThemeManager(ResourceDictionary resourceDictionary)
            {
                _ResourceDictionary = resourceDictionary ?? throw new ArgumentNullException(nameof(resourceDictionary));
            }

            public event EventHandler<ThemeChangedEventArgs>? ThemeChanged;

            public void OnThemeChange(ITheme oldTheme, ITheme newTheme)
            {
                ThemeChanged?.Invoke(this, new ThemeChangedEventArgs(_ResourceDictionary, oldTheme, newTheme));
            }
        }
    }
}