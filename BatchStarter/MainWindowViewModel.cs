using BatchStarter.Base;
using BatchStarter.Data;
using BatchStarter.Screen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;

namespace BatchStarter
{
    internal class MainWindowViewModel : INotifyPropertyChanged
    {
        private readonly List<PageCmd> _pageCmd;
        public MainWindowViewModel()
        {
            _pageCmd = new();
            CloseCmd = new CommandImpl(CloseEvent);
        }

        public ICommand CloseCmd { get; }

        private void CloseEvent(object? obj)
        {
            if (MessageBox.Show("are you sure?", "close", MessageBoxButton.YesNo) != MessageBoxResult.Yes)
            {
                MessageBox.Show("no click");
                return;
            }

            FBaseFunc.Ins.TerminateSystem();

            if (obj is Window window)
            {
                App.WindowInstance.DestroyWPF();
                window.Close();
            }
        }

        public void PageInit()
        {
            int cmdCount = FBaseFunc.Ins.Cfg.CmdCount;
            if (cmdCount <= 0)
            {
                return;
            }

            int row = cmdCount / 2;
            int col = cmdCount / 2;
            if (row * col < cmdCount)
            {
                row++;
            }

            var grid = App.WindowInstance.mainGrid;

            for (int i = 0; i < col; i++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition());
            }

            for (int i = 0; i < row; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition());

                for (int j = 0; j < col; j++)
                {
                    int ij = i * col + j;
                    if (ij >= cmdCount)
                    {
                        continue;
                    }

                    _pageCmd.Add(new PageCmd(ij));
                    Frame frame = new();
                    Grid.SetColumn(frame, j);
                    Grid.SetRow(frame, i);
                    frame.Content = _pageCmd[ij];
                    grid.Children.Add(frame);
                }
            }
        }
        public void SetMessageHook(Window mother)
        {
            WindowInteropHelper helper = new(mother);
            HwndSource source = HwndSource.FromHwnd(helper.Handle);
            source.AddHook(HookingFunc);
        }
        public IntPtr HookingFunc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            if (msg == 0x10)
            {
                handled = true;
            }
            return IntPtr.Zero;
        }
        public void IHaveToCloseThis(object sender, MainWindow mother)
        {
            MainWindow? parent = FindParent<MainWindow>((Button)sender);
            if (parent == null)
            {
                parent = mother;
            }
            HwndSource hwndSource = (HwndSource)PresentationSource.FromVisual(parent as Visual);
            if (hwndSource != null)
            {
                hwndSource.RemoveHook(new HwndSourceHook(HookingFunc));
            }
            Window.GetWindow(mother).Close();
        }
        private static T? FindParent<T>(DependencyObject dependencyObject) where T : DependencyObject
        {
            var parent = VisualTreeHelper.GetParent(dependencyObject);
            if (parent == null)
            {
                return null;
            }

            var parentT = parent as T;
            return parentT ?? FindParent<T>(parent);
        }
        public void DestroyWPF(Visual mother)
        {
            HwndSource hwndSource = (HwndSource)PresentationSource.FromVisual(mother);
            if (hwndSource != null)
            {
                hwndSource.RemoveHook(new HwndSourceHook(HookingFunc));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
