using BatchStarter.Base;
using BatchStarter.Data;
using Microsoft.Win32;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Input;

namespace BatchStarter.Screen
{
    internal class PageCmdViewModel : INotifyPropertyChanged
    {
        private int _index;
        private string _cmdRet;
        public PageCmdViewModel(int index)
        {
            _index = index;
            _cmdRet = "";
            CmdPathSet = new CommandImpl(PathSetEvent);
            CmdCmdReset = new CommandImpl(CmdResetEvent);
            CmdBatchStart = new CommandImpl(BatchStartEvent);
            CmdBatchClose = new CommandImpl(BatchCloseEvent);
            InitCmd(index);
        }

        public string CmdRet
        {
            get => _cmdRet;
            set
            {
                _cmdRet = value;
                OnPropertyChanged();
            }
        }

        private void Cmd_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            AddRet(e.Data);
        }
        private void Cmd_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            AddRet(e.Data);
        }

        public ICommand CmdPathSet { get; }
        public ICommand CmdCmdReset { get; }
        public ICommand CmdBatchStart { get; }
        public ICommand CmdBatchClose { get; }

        private void PathSetEvent(object? obj)
        {
            OpenFileDialog ofd = new();
            ofd.Filter = "batch file (*.bat)|*.bat";
            ofd.FilterIndex = 1;
            if (ofd.ShowDialog() == true)
            {
                FBaseFunc.Ins.Cfg.SetBatchPath(_index, ofd.FileName);
                AddRet(ofd.FileName);
            }
        }
        private void CmdResetEvent(object? obj)
        {
            bool ret = FBaseFunc.Ins.CtrlCToCmd(_index, out string err);
            if (!ret)
            {
                AddRet(err);
                return;
            }

            ret = FBaseFunc.Ins.CmdDataReceiveReset(_index, Cmd_OutputDataReceived, Cmd_ErrorDataReceived, out err);

            ret = FBaseFunc.Ins.CloseCmd(_index, out err);
            if (!ret)
            {
                AddRet(err);
                return;
            }

            ret = FBaseFunc.Ins.InitCmd(_index, Cmd_OutputDataReceived, Cmd_ErrorDataReceived, out err);
            if (!ret)
            {
                AddRet(err);
                return;
            }

            ret = FBaseFunc.Ins.RunCmd(_index, out err);
            if (!ret)
            {
                AddRet(err);
                return;
            }
        }
        private void BatchStartEvent(object? obj)
        {
            bool ret = FBaseFunc.Ins.BatchRun(_index, out string err);
            if (!ret)
            {
                AddRet(err);
            }
        }
        private void BatchCloseEvent(object? obj)
        {
            bool ret = FBaseFunc.Ins.CtrlCToCmd(_index, out string err);
            if (!ret)
            {
                AddRet(err);
            }
        }

        public void InitCmd(int index)
        {
            bool ret = FBaseFunc.Ins.InitCmd(index, Cmd_OutputDataReceived, Cmd_ErrorDataReceived, out string err);
            if (!ret)
            {
                AddRet(err);
            }
            else
            {
                ret = FBaseFunc.Ins.RunCmd(index, out err);
                if (!ret)
                {
                    AddRet(err);
                }
            }
        }
        private void AddRet(string? data)
        {
            if (data == null)
            {
                return;
            }

            if (Regex.Matches(CmdRet, "\n").Count > 1000)
            {
                CmdRet = "";
            }
            CmdRet += data + "\n";
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}