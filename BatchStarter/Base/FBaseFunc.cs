using System;
using System.Diagnostics;

namespace BatchStarter.Base
{
    internal partial class FBaseFunc
    {
        public FBaseFunc()
        {
            Cfg = new();
            _process = new();
            _cmd = new();
            _isInit = new();
            _isRun = new();
            ResultMsg1 = new();
            ResultMsg2 = new();
            ResultMsg3 = new();
            ResultMsg4 = new();
        }

        public void InitSystem()
        {
            Cfg.LoadSettingFile();
            _log = new(Cfg.LogPath, Cfg.LogFile);

            for (int i = 0; i < Cfg.CmdCount; i++)
            {
                Process.Add(new());
                _cmd.Add(new());
                _isInit.Add(false);
                _isRun.Add(false);
            }
        }
        public bool CanRun(int index, out string err)
        {
            err = "";
            if (_isInit.Count >= index)
            {
                err = "index err";
                return false;
            }
            if (!_isInit[index])
            {
                err = "init not yet";
                return false;
            }
            if (_isRun[index])
            {
                err = "already run";
                return false;
            }

            return true;
        }
        public void TerminateSystem()
        {
            PrintF("terminate start");
            for (int i = 0; i < _cmd.Count; i++)
            {

            }
            PrintF("terminate end");
        }

        public bool InitCmd(int index, DataReceivedEventHandler outputHandler, DataReceivedEventHandler errHandler, out string err)
        {
            err = "";
            if (_isRun.Count >= index)
            {
                err = "index err";
                return false;
            }
            if (_isInit[index])
            {
                err = "already init";
                return false;
            }
            if (_isRun[index])
            {
                err = "already run";
                return false;
            }

            PrintF("init cmd");
            try
            {
                if (_cmd[index] == null)
                {
                    _cmd[index] = new();
                }
                _cmd[index].FileName = @"cmd.exe";
                _cmd[index].WindowStyle = ProcessWindowStyle.Hidden;
                _cmd[index].CreateNoWindow = true;
                _cmd[index].UseShellExecute = false;
                _cmd[index].RedirectStandardOutput = true;
                _cmd[index].RedirectStandardInput = true;
                _cmd[index].RedirectStandardError = true;

                if (Process[index] == null)
                {
                    Process[index] = new();
                }
                Process[index].OutputDataReceived += outputHandler;
                Process[index].ErrorDataReceived += errHandler;
                Process[index].StartInfo = _cmd[index];
            }
            catch (Exception ex)
            {
                err = ex.Message;
                PrintF(err);
                return false;
            }

            _isInit[index] = true;
            return true;
        }
        public bool RunCmd(int index, out string err)
        {
            err = "";
            if (_isRun.Count >= index)
            {
                err = "index err";
                return false;
            }
            if (!_isInit[index])
            {
                err = "init not yet";
                return false;
            }
            if (_isRun[index])
            {
                err = "already run";
                return false;
            }

            eTHREAD th = eTHREAD.TH1 + index;
            CreateThread(th);
            try
            {
                Process[index].Start();
                Process[index].BeginOutputReadLine();
                Process[index].BeginErrorReadLine();
            }
            catch (Exception ex)
            {
                err = ex.Message;
                PrintF(err);
                return false;
            }

            _isRun[index] = true;
            return true;
        }
        public bool SendToCmd(string data, int index, out string err)
        {
            err = "";
            if (_process.Count >= index)
            {
                err = "index err";
                return false;
            }

            _process[index].StandardInput.WriteLine(data);
            return true;
        }
        public bool CtrlCToCmd(Process process)
        {
            if (AttachConsole((uint)process.Id))
            {
                SetConsoleCtrlHandler(null, true);
                try
                {
                    if (!GenerateConsoleCtrlEvent(CTRL_C_EVENT, 0))
                        return false;
                    process.WaitForExit();
                }
                finally
                {
                    SetConsoleCtrlHandler(null, false);
                    FreeConsole();
                }
                return true;
            }

            return false;
        }

        public override bool ProcThread1()
        {
            return base.ProcThread1();
        }
        public override bool ProcThread2()
        {
            return base.ProcThread2();
        }
        public override bool ProcThread3()
        {
            return base.ProcThread3();
        }
        public override bool ProcThread4()
        {
            return base.ProcThread4();
        }

        private void PrintF(string data)
        {
            _log?.PRINT_F(data);
        }
    }
}
