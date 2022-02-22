using BatchStarter.Data.Resource.Helper;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Media;

namespace BatchStarter.Data.Resource.ThemeAssist
{
    internal static class TextFieldAssist
    {
        public static readonly DependencyProperty TextBoxViewMarginProperty = DependencyProperty.RegisterAttached(
            "TextBoxViewMargin",
            typeof(Thickness),
            typeof(TextFieldAssist),
            new FrameworkPropertyMetadata(new Thickness(double.NegativeInfinity), FrameworkPropertyMetadataOptions.Inherits, TextBoxViewMarginPropertyChangedCallback));

        public static void SetTextBoxViewMargin(DependencyObject element, Thickness value)
        {
            element.SetValue(TextBoxViewMarginProperty, value);
        }

        public static Thickness GetTextBoxViewMargin(DependencyObject element)
        {
            return (Thickness)element.GetValue(TextBoxViewMarginProperty);
        }

        public static readonly DependencyProperty DecorationVisibilityProperty = DependencyProperty.RegisterAttached(
            "DecorationVisibility", typeof(Visibility), typeof(TextFieldAssist), new PropertyMetadata(default(Visibility)));

        public static void SetDecorationVisibility(DependencyObject element, Visibility value)
        {
            element.SetValue(DecorationVisibilityProperty, value);
        }

        public static Visibility GetDecorationVisibility(DependencyObject element)
        {
            return (Visibility)element.GetValue(DecorationVisibilityProperty);
        }

        public static readonly DependencyProperty UnderlineBrushProperty = DependencyProperty.RegisterAttached(
            "UnderlineBrush", typeof(Brush), typeof(TextFieldAssist), new PropertyMetadata(Brushes.Transparent));

        public static void SetUnderlineBrush(DependencyObject element, Brush value)
        {
            element.SetValue(UnderlineBrushProperty, value);
        }

        public static Brush GetUnderlineBrush(DependencyObject element)
        {
            return (Brush)element.GetValue(UnderlineBrushProperty);
        }

        public static readonly DependencyProperty HasFilledTextFieldProperty = DependencyProperty.RegisterAttached(
            "HasFilledTextField", typeof(bool), typeof(TextFieldAssist), new PropertyMetadata(false));

        public static void SetHasFilledTextField(DependencyObject element, bool value)
        {
            element.SetValue(HasFilledTextFieldProperty, value);
        }

        public static bool GetHasFilledTextField(DependencyObject element)
        {
            return (bool)element.GetValue(HasFilledTextFieldProperty);
        }

        public static readonly DependencyProperty HasOutlinedTextFieldProperty = DependencyProperty.RegisterAttached(
            "HasOutlinedTextField", typeof(bool), typeof(TextFieldAssist), new PropertyMetadata(false));

        public static void SetHasOutlinedTextField(DependencyObject element, bool value)
        {
            element.SetValue(HasOutlinedTextFieldProperty, value);
        }

        public static bool GetHasOutlinedTextField(DependencyObject element)
        {
            return (bool)element.GetValue(HasOutlinedTextFieldProperty);
        }

        public static readonly DependencyProperty TextFieldCornerRadiusProperty = DependencyProperty.RegisterAttached(
            "TextFieldCornerRadius", typeof(CornerRadius), typeof(TextFieldAssist), new PropertyMetadata(new CornerRadius(0.0)));

        public static void SetTextFieldCornerRadius(DependencyObject element, CornerRadius value)
        {
            element.SetValue(TextFieldCornerRadiusProperty, value);
        }

        public static CornerRadius GetTextFieldCornerRadius(DependencyObject element)
        {
            return (CornerRadius)element.GetValue(TextFieldCornerRadiusProperty);
        }

        public static readonly DependencyProperty UnderlineCornerRadiusProperty = DependencyProperty.RegisterAttached(
            "UnderlineCornerRadius", typeof(CornerRadius), typeof(TextFieldAssist), new PropertyMetadata(new CornerRadius(0.0)));

        public static void SetUnderlineCornerRadius(DependencyObject element, CornerRadius value)
        {
            element.SetValue(UnderlineCornerRadiusProperty, value);
        }

        public static CornerRadius GetUnderlineCornerRadius(DependencyObject element)
        {
            return (CornerRadius)element.GetValue(UnderlineCornerRadiusProperty);
        }

        public static readonly DependencyProperty NewSpecHighlightingEnabledProperty = DependencyProperty.RegisterAttached(
            "NewSpecHighlightingEnabled", typeof(bool), typeof(TextFieldAssist), new PropertyMetadata(false));

        public static void SetNewSpecHighlightingEnabled(DependencyObject element, bool value)
        {
            element.SetValue(NewSpecHighlightingEnabledProperty, value);
        }

        public static bool GetNewSpecHighlightingEnabled(DependencyObject element)
        {
            return (bool)element.GetValue(NewSpecHighlightingEnabledProperty);
        }

        public static readonly DependencyProperty RippleOnFocusEnabledProperty = DependencyProperty.RegisterAttached(
            "RippleOnFocusEnabled", typeof(bool), typeof(TextFieldAssist), new PropertyMetadata(false));

        public static void SetRippleOnFocusEnabled(DependencyObject element, bool value)
        {
            element.SetValue(RippleOnFocusEnabledProperty, value);
        }

        public static bool GetRippleOnFocusEnabled(DependencyObject element)
        {
            return (bool)element.GetValue(RippleOnFocusEnabledProperty);
        }

        public static readonly DependencyProperty IncludeSpellingSuggestionsProperty = DependencyProperty.RegisterAttached(
            "IncludeSpellingSuggestions", typeof(bool), typeof(TextFieldAssist), new PropertyMetadata(default(bool), IncludeSpellingSuggestionsChanged));

        public static void SetIncludeSpellingSuggestions(TextBoxBase element, bool value)
        {
            element.SetValue(IncludeSpellingSuggestionsProperty, value);
        }

        public static bool GetIncludeSpellingSuggestions(TextBoxBase element)
        {
            return (bool)element.GetValue(IncludeSpellingSuggestionsProperty);
        }

        private static void IncludeSpellingSuggestionsChanged(DependencyObject element, DependencyPropertyChangedEventArgs e)
        {
            if (element is TextBoxBase textBox)
            {
                if ((bool)e.NewValue)
                {
                    textBox.ContextMenuOpening += TextBoxOnContextMenuOpening;
                    textBox.ContextMenuClosing += TextBoxOnContextMenuClosing;
                }
                else
                {
                    textBox.ContextMenuOpening -= TextBoxOnContextMenuOpening;
                    textBox.ContextMenuClosing -= TextBoxOnContextMenuClosing;
                }
            }
        }

        private static void TextBoxOnContextMenuOpening(object sender, ContextMenuEventArgs e)
        {
            var textBoxBase = sender as TextBoxBase;

            ContextMenu? contextMenu = textBoxBase?.ContextMenu;
            if (contextMenu == null) return;

            RemoveSpellingSuggestions(contextMenu);

            if (!SpellCheck.GetIsEnabled(textBoxBase)) return;

            SpellingError? spellingError = GetSpellingError(textBoxBase);
            if (spellingError != null)
            {
                Style? spellingSuggestionStyle = contextMenu.TryFindResource(Spelling.SuggestionMenuItemStyleKey) as Style;

                int insertionIndex = 0;
                bool hasSuggestion = false;
                foreach (string suggestion in spellingError.Suggestions)
                {
                    hasSuggestion = true;
                    var menuItem = new MenuItem
                    {
                        CommandTarget = textBoxBase,
                        Command = EditingCommands.CorrectSpellingError,
                        CommandParameter = suggestion,
                        Style = spellingSuggestionStyle,
                        Tag = typeof(Spelling)
                    };
                    contextMenu.Items.Insert(insertionIndex++, menuItem);
                }
                if (!hasSuggestion)
                {
                    contextMenu.Items.Insert(insertionIndex++, new MenuItem
                    {
                        Style = contextMenu.TryFindResource(Spelling.NoSuggestionsMenuItemStyleKey) as Style,
                        Tag = typeof(Spelling)
                    });
                }

                contextMenu.Items.Insert(insertionIndex++, new Separator
                {
                    Style = contextMenu.TryFindResource(Spelling.SeparatorStyleKey) as Style,
                    Tag = typeof(Spelling)
                });

                contextMenu.Items.Insert(insertionIndex++, new MenuItem
                {
                    Command = EditingCommands.IgnoreSpellingError,
                    CommandTarget = textBoxBase,
                    Style = contextMenu.TryFindResource(Spelling.IgnoreAllMenuItemStyleKey) as Style,
                    Tag = typeof(Spelling)
                });

                contextMenu.Items.Insert(insertionIndex, new Separator
                {
                    Style = contextMenu.TryFindResource(Spelling.SeparatorStyleKey) as Style,
                    Tag = typeof(Spelling)
                });
            }
        }

        private static SpellingError? GetSpellingError(TextBoxBase? textBoxBase)
        {
            if (textBoxBase is TextBox textBox)
            {
                return textBox.GetSpellingError(textBox.CaretIndex);
            }

            if (textBoxBase is RichTextBox richTextBox)
            {
                return richTextBox.GetSpellingError(richTextBox.CaretPosition);
            }
            return null;
        }

        private static void TextBoxOnContextMenuClosing(object sender, ContextMenuEventArgs e)
        {
            var contextMenu = (sender as TextBoxBase)?.ContextMenu;
            if (contextMenu != null)
            {
                RemoveSpellingSuggestions(contextMenu);
            }
        }

        private static void RemoveSpellingSuggestions(ContextMenu menu)
        {
            foreach (FrameworkElement item in (from item in menu.Items.OfType<FrameworkElement>()
                                               where ReferenceEquals(item.Tag, typeof(Spelling))
                                               select item).ToList())
            {
                menu.Items.Remove(item);
            }
        }

        public static readonly DependencyProperty HasClearButtonProperty = DependencyProperty.RegisterAttached(
            "HasClearButton", typeof(bool), typeof(TextFieldAssist), new PropertyMetadata(false, HasClearButtonChanged));

        private static void HasClearButtonChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is not Control box)
            {
                return;
            }

            if (box.IsLoaded)
                SetClearHandler(box);
            else
                box.Loaded += (sender, args) =>
                    SetClearHandler(box);

        }

        private static void SetClearHandler(Control box)
        {
            var bValue = GetHasClearButton(box);
            if (box.Template.FindName("PART_ClearButton", box) is Button clearButton)
            {
                void handler(object sender, RoutedEventArgs args)
                {
                    (box as TextBox)?.SetCurrentValue(TextBox.TextProperty, null);
                    (box as ComboBox)?.SetCurrentValue(ComboBox.TextProperty, null);
                    if (box is PasswordBox box1)
                        box1.Password = null;
                }
                if (bValue)
                    clearButton.Click += handler;
                else
                    clearButton.Click -= handler;
            }
        }

        public static void SetHasClearButton(DependencyObject element, bool value)
        {
            element.SetValue(HasClearButtonProperty, value);
        }

        public static bool GetHasClearButton(DependencyObject element)
        {
            return (bool)element.GetValue(HasClearButtonProperty);
        }

        public static readonly DependencyProperty SuffixTextProperty = DependencyProperty.RegisterAttached(
            "SuffixText", typeof(string), typeof(TextFieldAssist), new PropertyMetadata(default(string)));

        public static void SetSuffixText(DependencyObject element, string value)
        {
            element.SetValue(SuffixTextProperty, value);
        }

        public static string GetSuffixText(DependencyObject element)
        {
            return (string)element.GetValue(SuffixTextProperty);
        }

        public static readonly DependencyProperty PrefixTextProperty = DependencyProperty.RegisterAttached(
            "PrefixText", typeof(string), typeof(TextFieldAssist), new PropertyMetadata(default(string)));

        public static void SetPrefixText(DependencyObject element, string value) => element.SetValue(PrefixTextProperty, value);

        public static string GetPrefixText(DependencyObject element) => (string)element.GetValue(PrefixTextProperty);

        #region Methods
        private static void ApplyTextBoxViewMargin(Control textBox, Thickness margin)
        {
            if (margin.Equals(new Thickness(double.NegativeInfinity)))
            {
                return;
            }

            if ((textBox.Template?.FindName("PART_ContentHost", textBox) as ScrollViewer)?.Content is FrameworkElement frameworkElement)
            {
                frameworkElement.Margin = margin;
            }
        }

        private static void TextBoxViewMarginPropertyChangedCallback(
            DependencyObject dependencyObject,
            DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
        {
            if (dependencyObject is not Control box)
            {
                return;
            }

            if (box.IsLoaded)
            {
                ApplyTextBoxViewMargin(box, (Thickness)dependencyPropertyChangedEventArgs.NewValue);
            }

            box.Loaded += (sender, args) =>
            {
                var textBox = (Control)sender;
                ApplyTextBoxViewMargin(textBox, GetTextBoxViewMargin(textBox));
            };
        }
        #endregion
    }
}
