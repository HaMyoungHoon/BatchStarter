using System.Windows.Media;

namespace BatchStarter.Data.Resource.Helper
{
    internal class LightTheme : IBaseTheme
    {
        public Color ValidationErrorColor { get; } = (Color)ColorConverter.ConvertFromString("#f44336");
        public Color DefaultBackground { get; } = (Color)ColorConverter.ConvertFromString("#FFFFFFFF");
        public Color DefaultForeground { get; } = (Color)ColorConverter.ConvertFromString("#FF000000");
        public Color DefaultPaper { get; } = (Color)ColorConverter.ConvertFromString("#FFfafafa");
        public Color DefaultCardBackground { get; } = (Color)ColorConverter.ConvertFromString("#FFFFFFFF");
        public Color DefaultToolBarBackground { get; } = (Color)ColorConverter.ConvertFromString("#FFF5F5F5");
        public Color DefaultBody { get; } = (Color)ColorConverter.ConvertFromString("#DD000000");
        public Color DefaultBodyLight { get; } = (Color)ColorConverter.ConvertFromString("#89000000");
        public Color DefaultColumnHeader { get; } = (Color)ColorConverter.ConvertFromString("#BC000000");
        public Color DefaultCheckBoxOff { get; } = (Color)ColorConverter.ConvertFromString("#89000000");
        public Color DefaultCheckBoxDisabled { get; } = (Color)ColorConverter.ConvertFromString("#FFBDBDBD");
        public Color DefaultTextBoxBorder { get; } = (Color)ColorConverter.ConvertFromString("#89000000");
        public Color DefaultDivider { get; } = (Color)ColorConverter.ConvertFromString("#1F000000");
        public Color DefaultSelection { get; } = (Color)ColorConverter.ConvertFromString("#FFDeDeDe");
        public Color DefaultToolForeground { get; } = (Color)ColorConverter.ConvertFromString("#FF616161");
        public Color DefaultToolBackground { get; } = (Color)ColorConverter.ConvertFromString("#FFe0e0e0");
        public Color DefaultFlatButtonClick { get; } = (Color)ColorConverter.ConvertFromString("#FFDeDeDe");
        public Color DefaultFlatButtonRipple { get; } = (Color)ColorConverter.ConvertFromString("#FFB6B6B6");
        public Color DefaultToolTipBackground { get; } = (Color)ColorConverter.ConvertFromString("#757575");
        public Color DefaultChipBackground { get; } = (Color)ColorConverter.ConvertFromString("#12000000");
        public Color DefaultSnackbarBackground { get; } = (Color)ColorConverter.ConvertFromString("#FF323232");
        public Color DefaultSnackbarMouseOver { get; } = (Color)ColorConverter.ConvertFromString("#FF464642");
        public Color DefaultSnackbarRipple { get; } = (Color)ColorConverter.ConvertFromString("#FFB6B6B6");
        public Color DefaultTextFieldBoxBackground { get; } = (Color)ColorConverter.ConvertFromString("#0F000000");
        public Color DefaultTextFieldBoxHoverBackground { get; } = (Color)ColorConverter.ConvertFromString("#14000000");
        public Color DefaultTextFieldBoxDisabledBackground { get; } = (Color)ColorConverter.ConvertFromString("#08000000");
        public Color DefaultTextAreaBorder { get; } = (Color)ColorConverter.ConvertFromString("#BC000000");
        public Color DefaultTextAreaInactiveBorder { get; } = (Color)ColorConverter.ConvertFromString("#0F000000");
        public Color DefaultDataGridRowHoverBackground { get; } = (Color)ColorConverter.ConvertFromString("#0A000000");
    }
}
