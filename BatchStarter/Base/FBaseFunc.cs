using System;
using System.Diagnostics;
using System.Windows;

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
        }

        public void InitSystem()
        {
            Cfg.LoadSettingFile();
            _log = new(Cfg.LogPath, Cfg.LogFile);

            for (int i = 0; i < Cfg.CmdCount; i++)
            {
                _process.Add(new());
                _cmd.Add(new());
                _isInit.Add(false);
                _isRun.Add(false);
            }
        }
        public void TerminateSystem()
        {
            bool ret;
            PrintF("terminate start");
            for (int i = 0; i < _cmd.Count; i++)
            {
                ret = CtrlCToCmd(i, out string err);
                if (!ret)
                {
                    PrintF(err);
                    MessageBox.Show(err);
                }
                else
                {
                    ret = CloseCmd(i, out err);
                    if (!ret)
                    {
                        PrintF(err);
                        MessageBox.Show(err);
                    }
                }
            }
            PrintF("terminate end");
        }

        public bool InitCmd(int index, DataReceivedEventHandler outputHandler, DataReceivedEventHandler errHandler, out string err)
        {
            err = "";
            if (_isRun.Count <= index)
            {
                err = "InitCmd : index err";
                return false;
            }
            if (_isInit[index])
            {
                err = "InitCmd : already init";
                return false;
            }
            if (_isRun[index])
            {
                err = "InitCmd : already run";
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

                if (_process[index] == null)
                {
                    _process[index] = new();
                }
                _process[index].OutputDataReceived += outputHandler;
                _process[index].ErrorDataReceived += errHandler;
                _process[index].StartInfo = _cmd[index];
            }
            catch (Exception ex)
            {
                err = "InitCmd : " + ex.Message;
                PrintF(err);
                return false;
            }

            _isInit[index] = true;
            return true;
        }
        public bool RunCmd(int index, out string err)
        {
            err = "";
            if (_isRun.Count <= index)
            {
                err = "RunCmd : index err";
                return false;
            }
            if (!_isInit[index])
            {
                err = "RunCmd : init not yet";
                return false;
            }
            if (_isRun[index])
            {
                err = "RunCmd : already run";
                return false;
            }

            try
            {
                _process[index].Start();
                _process[index].BeginOutputReadLine();
                _process[index].BeginErrorReadLine();
            }
            catch (Exception ex)
            {
                err = "RunCmd : " + ex.Message;
                PrintF(err);
                return false;
            }

            _isRun[index] = true;
            return true;
        }
        public bool BatchRun(int index, out string err)
        {
            err = "";
            if (_process.Count <= index)
            {
                err = "BatchRun : index err";
                return false;
            }

            if (_isInit[index] == false)
            {
                err = "BatchRun : init not yet";
                return false;
            }

            if (_isRun[index] == false)
            {
                err = "BatchRun : run not yet";
                return false;
            }

            _process[index].StandardInput.WriteLine(Cfg.BatchPath[index]);
            return true;
        }
        public bool SendToCmd(string data, int index, out string err)
        {
            err = "";
            if (_process.Count <= index)
            {
                err = "SendToCmd : index err";
                return false;
            }

            _process[index].StandardInput.WriteLine(data);
            return true;
        }
        public bool CtrlCToCmd(int index, out string err)
        {
            err = "";
            if (_process.Count <= index)
            {
                err = "CtrlCToCmd : index err";
                return false;
            }

            Process process = _process[index];
            if (AttachConsole((uint)process.Id))
            {
                SetConsoleCtrlHandler(null, true);
                try
                {
                    if (!GenerateConsoleCtrlEvent(CTRL_C_EVENT, 0))
                    {
                        err = "CtrlCToCmd : generate console err";
                        return false;
                    }
                }
                catch (Exception e)
                {
                    err = "CtrlCToCmd : " + e.Message;
                    PrintF(err);
                }
                finally
                {
//                    SetConsoleCtrlHandler(null, false);
                    FreeConsole();
                }
                if (err.Length > 0)
                {
                    return false;
                }
                else
                {
                    SendToCmd("Y", index, out err);
                }
                return true;
            }

            err = "CtrlCToCmd : cmd attach err";
            return false;
        }
        public bool CmdDataReceiveReset(int index, DataReceivedEventHandler outputHandler, DataReceivedEventHandler errHandler, out string err)
        {
            err = "";
            if (_process.Count <= index)
            {
                err = "CmdDataReceiveReset : index err";
                return false;
            }

            try
            {
                _process[index].OutputDataReceived -= outputHandler;
                _process[index].ErrorDataReceived -= errHandler;
            }
            catch (Exception ex)
            {
                err = "CmdDataReceiveReset : " + ex.Message;
                PrintF(err);
                return false;
            }

            return true;
        }
        public bool CloseCmd(int index, out string err)
        {
            err = "";
            if (_process.Count <= index)
            {
                err = "CloseCmd : index err";
                return false;
            }

            try
            {
                _process[index].StandardInput.Close();
                _process[index].CancelOutputRead();
                _process[index].CancelErrorRead();
                _process[index].WaitForExit();
                _process[index].Close();
                _isRun[index] = false;
                _isInit[index] = false;
            }
            catch (Exception ex)
            {
                err = "CloseCmd : " + ex.Message;
                PrintF(err);
                return false;
            }

            return true;
        }

        private void PrintF(string data)
        {
            _log?.PRINT_F(data);
        }
    }
}
