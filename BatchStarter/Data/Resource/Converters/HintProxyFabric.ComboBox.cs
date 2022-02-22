﻿using BatchStarter.Data.Resource.Helper;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace BatchStarter.Data.Resource.Converters
{
    internal static partial class HintProxyFabric
    {
        private sealed class ComboBoxHintProxy : IHintProxy
        {
            private readonly ComboBox _comboBox;
            private readonly TextChangedEventHandler _comboBoxTextChangedEventHandler;

            public ComboBoxHintProxy(ComboBox comboBox)
            {
                _comboBox = comboBox ?? throw new ArgumentNullException(nameof(comboBox));
                _comboBoxTextChangedEventHandler = ComboBoxTextChanged;
                _comboBox.AddHandler(TextBoxBase.TextChangedEvent, _comboBoxTextChangedEventHandler);
                _comboBox.SelectionChanged += ComboBoxSelectionChanged;
                _comboBox.Loaded += ComboBoxLoaded;
                _comboBox.IsVisibleChanged += ComboBoxIsVisibleChanged;
                _comboBox.IsKeyboardFocusWithinChanged += ComboBoxIsKeyboardFocusWithinChanged;
            }

            public object Content
            {
                get
                {
                    if (_comboBox.IsEditable)
                    {
                        return _comboBox.Text;
                    }

                    return _comboBox.SelectedItem is ComboBoxItem comboBoxItem
                        ? comboBoxItem.Content
                        : _comboBox.SelectedItem;
                }
            }

            public bool IsLoaded => _comboBox.IsLoaded;

            public bool IsVisible => _comboBox.IsVisible;

            public bool IsEmpty() => string.IsNullOrEmpty(_comboBox.Text);

            public bool IsFocused() => _comboBox.IsEditable && _comboBox.IsKeyboardFocusWithin;

            public event EventHandler? ContentChanged;
            public event EventHandler? IsVisibleChanged;
            public event EventHandler? Loaded;
            public event EventHandler? FocusedChanged;

            private void ComboBoxSelectionChanged(object sender, SelectionChangedEventArgs e)
            {
                _comboBox.Dispatcher.InvokeAsync(() => ContentChanged?.Invoke(sender, EventArgs.Empty));
            }

            private void ComboBoxIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
            {
                IsVisibleChanged?.Invoke(sender, EventArgs.Empty);
            }

            private void ComboBoxLoaded(object sender, RoutedEventArgs e)
            {
                Loaded?.Invoke(sender, EventArgs.Empty);
            }

            private void ComboBoxTextChanged(object sender, TextChangedEventArgs e)
            {
                ContentChanged?.Invoke(sender, EventArgs.Empty);
            }

            private void ComboBoxIsKeyboardFocusWithinChanged(object sender, DependencyPropertyChangedEventArgs e)
            {
                FocusedChanged?.Invoke(sender, EventArgs.Empty);
            }

            public void Dispose()
            {
                _comboBox.RemoveHandler(TextBoxBase.TextChangedEvent, _comboBoxTextChangedEventHandler);
                _comboBox.Loaded -= ComboBoxLoaded;
                _comboBox.IsVisibleChanged -= ComboBoxIsVisibleChanged;
                _comboBox.SelectionChanged -= ComboBoxSelectionChanged;
                _comboBox.IsKeyboardFocusWithinChanged -= ComboBoxIsKeyboardFocusWithinChanged;
            }
        }
    }
}