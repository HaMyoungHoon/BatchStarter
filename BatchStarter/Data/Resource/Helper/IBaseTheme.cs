using System.Windows.Media;

namespace BatchStarter.Data.Resource
{
    public interface IBaseTheme
    {
        Color ValidationErrorColor { get; }
        Color DefaultBackground { get; }
        Color DefaultPaper { get; }
        Color DefaultCardBackground { get; }
        Color DefaultToolBarBackground { get; }
        Color DefaultBody { get; }
        Color DefaultBodyLight { get; }
        Color DefaultColumnHeader { get; }
        Color DefaultCheckBoxOff { get; }
        Color DefaultCheckBoxDisabled { get; }
        Color DefaultTextBoxBorder { get; }
        Color DefaultDivider { get; }
        Color DefaultSelection { get; }
        Color DefaultToolForeground { get; }
        Color DefaultToolBackground { get; }
        Color DefaultFlatButtonClick { get; }
        Color DefaultFlatButtonRipple { get; }
        Color DefaultToolTipBackground { get; }
        Color DefaultChipBackground { get; }
        Color DefaultSnackbarBackground { get; }
        Color DefaultSnackbarMouseOver { get; }
        Color DefaultSnackbarRipple { get; }
        Color DefaultTextFieldBoxBackground { get; }
        Color DefaultTextFieldBoxHoverBackground { get; }
        Color DefaultTextFieldBoxDisabledBackground { get; }
        Color DefaultTextAreaBorder { get; }
        Color DefaultTextAreaInactiveBorder { get; }
        Color DefaultDataGridRowHoverBackground { get; }
    }
}
