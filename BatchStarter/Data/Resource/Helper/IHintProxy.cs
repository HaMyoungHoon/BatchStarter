using System;
using System.Windows.Controls;

namespace BatchStarter.Data.Resource.Helper
{
    internal interface IHintProxy : IDisposable
    {
        bool IsEmpty();
        bool IsFocused();

        [Obsolete]
        object? Content { get; }

        bool IsLoaded { get; }

        bool IsVisible { get; }

        event EventHandler ContentChanged;

        event EventHandler IsVisibleChanged;

        event EventHandler Loaded;

        event EventHandler FocusedChanged;
    }
}
