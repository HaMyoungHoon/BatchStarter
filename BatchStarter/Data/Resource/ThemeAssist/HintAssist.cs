using System.Windows;
using System.Windows.Media;

namespace BatchStarter.Data.Resource.ThemeAssist
{
    internal static class HintAssist
    {
        #region UseFloating
        public static readonly DependencyProperty IsFloatingProperty = DependencyProperty.RegisterAttached(
            "IsFloating",
            typeof(bool),
            typeof(HintAssist),
            new FrameworkPropertyMetadata(default(bool), FrameworkPropertyMetadataOptions.Inherits));

        public static bool GetIsFloating(DependencyObject element)
        {
            return (bool)element.GetValue(IsFloatingProperty);
        }

        public static void SetIsFloating(DependencyObject element, bool value)
        {
            element.SetValue(IsFloatingProperty, value);
        }
        #endregion

        #region FloatingScale & FloatingOffset
        public static readonly DependencyProperty FloatingScaleProperty = DependencyProperty.RegisterAttached(
            "FloatingScale",
            typeof(double),
            typeof(HintAssist),
            new FrameworkPropertyMetadata(0.74d, FrameworkPropertyMetadataOptions.Inherits));

        public static double GetFloatingScale(DependencyObject element)
        {
            return (double)element.GetValue(FloatingScaleProperty);
        }

        public static void SetFloatingScale(DependencyObject element, double value)
        {
            element.SetValue(FloatingScaleProperty, value);
        }

        public static readonly DependencyProperty FloatingOffsetProperty = DependencyProperty.RegisterAttached(
            "FloatingOffset",
            typeof(Point),
            typeof(HintAssist),
            new FrameworkPropertyMetadata(new Point(1, -16), FrameworkPropertyMetadataOptions.Inherits));

        public static Point GetFloatingOffset(DependencyObject element)
        {
            return (Point)element.GetValue(FloatingOffsetProperty);
        }

        public static void SetFloatingOffset(DependencyObject element, Point value)
        {
            element.SetValue(FloatingOffsetProperty, value);
        }
        #endregion

        #region Hint
        public static readonly DependencyProperty HintProperty = DependencyProperty.RegisterAttached(
            "Hint",
            typeof(object),
            typeof(HintAssist),
            new FrameworkPropertyMetadata(default(string), FrameworkPropertyMetadataOptions.Inherits));

        public static void SetHint(DependencyObject element, object value)
        {
            element.SetValue(HintProperty, value);
        }

        public static object GetHint(DependencyObject element)
        {
            return element.GetValue(HintProperty);
        }
        #endregion

        #region HintOpacity
        public static readonly DependencyProperty HintOpacityProperty = DependencyProperty.RegisterAttached(
            "HintOpacity",
            typeof(double),
            typeof(HintAssist),
            new PropertyMetadata(.56));

        public static double GetHintOpacityProperty(DependencyObject element)
        {
            return (double)element.GetValue(HintOpacityProperty);
        }

        public static void SetHintOpacity(DependencyObject element, double value)
        {
            element.SetValue(HintOpacityProperty, value);
        }
        #endregion

        #region Brushes
        public static readonly DependencyProperty ForegroundProperty = DependencyProperty.RegisterAttached(
            "Foreground", typeof(Brush), typeof(HintAssist), new PropertyMetadata(null));

        public static Brush GetForeground(DependencyObject element)
        {
            return (Brush)element.GetValue(ForegroundProperty);
        }

        public static void SetForeground(DependencyObject element, Brush value)
        {
            element.SetValue(ForegroundProperty, value);
        }

        public static readonly DependencyProperty BackgroundProperty = DependencyProperty.RegisterAttached(
            "Background", typeof(Brush), typeof(HintAssist), new PropertyMetadata(new SolidColorBrush(Colors.Transparent)));

        public static Brush GetBackground(DependencyObject element)
        {
            return (Brush)element.GetValue(BackgroundProperty);
        }

        public static void SetBackground(DependencyObject element, Brush value)
        {
            element.SetValue(BackgroundProperty, value);
        }
        #endregion

        #region HelperText
        public static readonly DependencyProperty HelperTextProperty = DependencyProperty.RegisterAttached(
            "HelperText",
            typeof(string),
            typeof(HintAssist),
            new FrameworkPropertyMetadata(default(string), FrameworkPropertyMetadataOptions.Inherits));

        public static void SetHelperText(DependencyObject element, object value)
        {
            element.SetValue(HelperTextProperty, value);
        }

        public static object GetHelperText(DependencyObject element)
        {
            return element.GetValue(HelperTextProperty);
        }
        #endregion
    }
}