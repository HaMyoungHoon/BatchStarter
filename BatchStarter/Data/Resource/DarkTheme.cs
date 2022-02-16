using System.Windows.Media;

namespace BatchStarter.Data.Resource
{
    internal class DarkTheme : IBaseTheme
    {
        public Color ValidationErrorColor { get; } = (Color)ColorConverter.ConvertFromString("#f44336");
        public Color DefaultBackground { get; } = (Color)ColorConverter.ConvertFromString("#FF000000");
        public Color DefaultPaper { get; } = (Color)ColorConverter.ConvertFromString("#FF303030");
        public Color DefaultCardBackground { get; } = (Color)ColorConverter.ConvertFromString("#FF424242");
        public Color DefaultToolBarBackground { get; } = (Color)ColorConverter.ConvertFromString("#FF212121");
        public Color DefaultBody { get; } = (Color)ColorConverter.ConvertFromString("#DDFFFFFF");
        public Color DefaultBodyLight { get; } = (Color)ColorConverter.ConvertFromString("#89FFFFFF");
        public Color DefaultColumnHeader { get; } = (Color)ColorConverter.ConvertFromString("#BCFFFFFF");
        public Color DefaultCheckBoxOff { get; } = (Color)ColorConverter.ConvertFromString("#89FFFFFF");
        public Color DefaultCheckBoxDisabled { get; } = (Color)ColorConverter.ConvertFromString("#FF647076");
        public Color DefaultTextBoxBorder { get; } = (Color)ColorConverter.ConvertFromString("#89FFFFFF");
        public Color DefaultDivider { get; } = (Color)ColorConverter.ConvertFromString("#1FFFFFFF");
        public Color DefaultSelection { get; } = (Color)ColorConverter.ConvertFromString("#757575");
        public Color DefaultToolForeground { get; } = (Color)ColorConverter.ConvertFromString("#FF616161");
        public Color DefaultToolBackground { get; } = (Color)ColorConverter.ConvertFromString("#FFe0e0e0");
        public Color DefaultFlatButtonClick { get; } = (Color)ColorConverter.ConvertFromString("#19757575");
        public Color DefaultFlatButtonRipple { get; } = (Color)ColorConverter.ConvertFromString("#FFB6B6B6");
        public Color DefaultToolTipBackground { get; } = (Color)ColorConverter.ConvertFromString("#eeeeee");
        public Color DefaultChipBackground { get; } = (Color)ColorConverter.ConvertFromString("#FF2E3C43");
        public Color DefaultSnackbarBackground { get; } = (Color)ColorConverter.ConvertFromString("#FFCDCDCD");
        public Color DefaultSnackbarMouseOver { get; } = (Color)ColorConverter.ConvertFromString("#FFB9B9BD");
        public Color DefaultSnackbarRipple { get; } = (Color)ColorConverter.ConvertFromString("#FF494949");
        public Color DefaultTextFieldBoxBackground { get; } = (Color)ColorConverter.ConvertFromString("#1AFFFFFF");
        public Color DefaultTextFieldBoxHoverBackground { get; } = (Color)ColorConverter.ConvertFromString("#1FFFFFFF");
        public Color DefaultTextFieldBoxDisabledBackground { get; } = (Color)ColorConverter.ConvertFromString("#0DFFFFFF");
        public Color DefaultTextAreaBorder { get; } = (Color)ColorConverter.ConvertFromString("#BCFFFFFF");
        public Color DefaultTextAreaInactiveBorder { get; } = (Color)ColorConverter.ConvertFromString("#1AFFFFFF");
        public Color DefaultDataGridRowHoverBackground { get; } = (Color)ColorConverter.ConvertFromString("#14FFFFFF");
    }
}
