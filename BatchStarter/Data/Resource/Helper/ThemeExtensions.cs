using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;

namespace BatchStarter.Data.Resource.Helper
{
    internal static class ThemeExtensions
    {
        internal static ColorPair ToPairedColor(this Hue hue)
            => new(hue.Color, hue.Foreground);

        internal static void SetPalette(this ITheme theme, Palette palette)
        {
            List<Hue> allHues = palette.PrimarySwatch.PrimaryHues.ToList();

            Hue lightHue = allHues[palette.PrimaryLightHueIndex];
            Hue midHue = allHues[palette.PrimaryMidHueIndex];
            Hue darkHue = allHues[palette.PrimaryDarkHueIndex];

            theme.PrimaryLight = lightHue.ToPairedColor();
            theme.PrimaryMid = midHue.ToPairedColor();
            theme.PrimaryDark = darkHue.ToPairedColor();
        }

        public static IBaseTheme GetBaseTheme(this BaseTheme baseTheme)
        {
            return baseTheme switch
            {
                BaseTheme.Dark => Theme.Dark,
                BaseTheme.Light => Theme.Light,
                BaseTheme.Inherit => Theme.GetSystemTheme() switch
                {
                    BaseTheme.Dark => Theme.Dark,
                    _ => Theme.Light
                },
                _ => throw new InvalidOperationException(),
            };
        }

        public static BaseTheme GetBaseTheme(this ITheme theme)
        {
            if (theme is null) throw new ArgumentNullException(nameof(theme));

            var foreground = theme.Background.ContrastingForegroundColor();
            return foreground == Colors.Black ? BaseTheme.Light : BaseTheme.Dark;
        }

        public static void SetBaseTheme(this ITheme theme, IBaseTheme baseTheme)
        {
            if (theme is null) throw new ArgumentNullException(nameof(theme));

            theme.ValidationError = baseTheme.ValidationErrorColor;
            theme.Background = baseTheme.DefaultBackground;
            theme.Foreground = baseTheme.DefaultForeground;
            theme.Paper = baseTheme.DefaultPaper;
            theme.CardBackground = baseTheme.DefaultCardBackground;
            theme.ToolBarBackground = baseTheme.DefaultToolBarBackground;
            theme.Body = baseTheme.DefaultBody;
            theme.BodyLight = baseTheme.DefaultBodyLight;
            theme.ColumnHeader = baseTheme.DefaultColumnHeader;
            theme.CheckBoxOff = baseTheme.DefaultCheckBoxOff;
            theme.CheckBoxDisabled = baseTheme.DefaultCheckBoxDisabled;
            theme.Divider = baseTheme.DefaultDivider;
            theme.Selection = baseTheme.DefaultSelection;
            theme.ToolForeground = baseTheme.DefaultToolForeground;
            theme.ToolBackground = baseTheme.DefaultToolBackground;
            theme.FlatButtonClick = baseTheme.DefaultFlatButtonClick;
            theme.FlatButtonRipple = baseTheme.DefaultFlatButtonRipple;
            theme.ToolTipBackground = baseTheme.DefaultToolTipBackground;
            theme.ChipBackground = baseTheme.DefaultChipBackground;
            theme.SnackbarBackground = baseTheme.DefaultSnackbarBackground;
            theme.SnackbarMouseOver = baseTheme.DefaultSnackbarMouseOver;
            theme.SnackbarRipple = baseTheme.DefaultSnackbarRipple;
            theme.TextBoxBorder = baseTheme.DefaultTextBoxBorder;
            theme.TextFieldBoxBackground = baseTheme.DefaultTextFieldBoxBackground;
            theme.TextFieldBoxHoverBackground = baseTheme.DefaultTextFieldBoxHoverBackground;
            theme.TextFieldBoxDisabledBackground = baseTheme.DefaultTextFieldBoxDisabledBackground;
            theme.TextAreaBorder = baseTheme.DefaultTextAreaBorder;
            theme.TextAreaInactiveBorder = baseTheme.DefaultTextAreaInactiveBorder;
            theme.DataGridRowHoverBackground = baseTheme.DefaultDataGridRowHoverBackground;
        }

        public static void SetPrimaryColor(this ITheme theme, Color primaryColor)
        {
            if (theme is null) throw new ArgumentNullException(nameof(theme));

            theme.PrimaryLight = primaryColor.Lighten();
            theme.PrimaryMid = primaryColor;
            theme.PrimaryDark = primaryColor.Darken();
        }

        public static void SetSecondaryColor(this ITheme theme, Color accentColor)
        {
            if (theme == null) throw new ArgumentNullException(nameof(theme));
            theme.SecondaryLight = accentColor.Lighten();
            theme.SecondaryMid = accentColor;
            theme.SecondaryDark = accentColor.Darken();
        }
    }
}
