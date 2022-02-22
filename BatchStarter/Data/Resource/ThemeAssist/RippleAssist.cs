using System.Windows;
using System.Windows.Media;

namespace BatchStarter.Data.Resource.ThemeAssist
{
    internal static class RippleAssist
    {
        #region ClipToBound
        public static readonly DependencyProperty ClipToBoundsProperty = DependencyProperty.RegisterAttached(
            "ClipToBounds", typeof(bool), typeof(RippleAssist), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.Inherits));

        public static void SetClipToBounds(DependencyObject element, bool value)
        {
            element.SetValue(ClipToBoundsProperty, value);
        }

        public static bool GetClipToBounds(DependencyObject element)
        {
            return (bool)element.GetValue(ClipToBoundsProperty);
        }

        #endregion

        #region StayOnCenter
        public static readonly DependencyProperty IsCenteredProperty = DependencyProperty.RegisterAttached(
            "IsCentered", typeof(bool), typeof(RippleAssist), new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.Inherits));

        public static void SetIsCentered(DependencyObject element, bool value)
        {
            element.SetValue(IsCenteredProperty, value);
        }

        public static bool GetIsCentered(DependencyObject element)
        {
            return (bool)element.GetValue(IsCenteredProperty);
        }
        #endregion

        #region IsDisabled
        public static readonly DependencyProperty IsDisabledProperty = DependencyProperty.RegisterAttached(
            "IsDisabled", typeof(bool), typeof(RippleAssist), new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.Inherits));

        public static void SetIsDisabled(DependencyObject element, bool value)
        {
            element.SetValue(IsDisabledProperty, value);
        }

        public static bool GetIsDisabled(DependencyObject element)
        {
            return (bool)element.GetValue(IsDisabledProperty);
        }
        #endregion

        #region RippleSizeMultiplier

        public static readonly DependencyProperty RippleSizeMultiplierProperty = DependencyProperty.RegisterAttached(
            "RippleSizeMultiplier", typeof(double), typeof(RippleAssist), new FrameworkPropertyMetadata(1.0, FrameworkPropertyMetadataOptions.Inherits));

        public static void SetRippleSizeMultiplier(DependencyObject element, double value)
        {
            element.SetValue(RippleSizeMultiplierProperty, value);
        }

        public static double GetRippleSizeMultiplier(DependencyObject element)
        {
            return (double)element.GetValue(RippleSizeMultiplierProperty);
        }
        #endregion

        #region Feedback

        public static readonly DependencyProperty FeedbackProperty = DependencyProperty.RegisterAttached(
            "Feedback", typeof(Brush), typeof(RippleAssist), new FrameworkPropertyMetadata(default(Brush), FrameworkPropertyMetadataOptions.Inherits | FrameworkPropertyMetadataOptions.AffectsRender));

        public static void SetFeedback(DependencyObject element, Brush value)
        {
            element.SetValue(FeedbackProperty, value);
        }

        public static Brush GetFeedback(DependencyObject element)
        {
            return (Brush)element.GetValue(FeedbackProperty);
        }
        #endregion

        #region RippleOnTop
        public static readonly DependencyProperty RippleOnTopProperty = DependencyProperty.RegisterAttached(
            "RippleOnTop", typeof(bool), typeof(RippleAssist),
            new FrameworkPropertyMetadata(default(bool), FrameworkPropertyMetadataOptions.Inherits | FrameworkPropertyMetadataOptions.AffectsRender));

        public static void SetRippleOnTop(DependencyObject element, bool value)
        {
            element.SetValue(RippleOnTopProperty, value);
        }

        public static bool GetRippleOnTop(DependencyObject element)
        {
            return (bool)element.GetValue(RippleOnTopProperty);
        }
        #endregion
    }
}