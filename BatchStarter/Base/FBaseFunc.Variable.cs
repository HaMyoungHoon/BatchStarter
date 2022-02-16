using BaseLib_Net6;
using BatchStarter.Base.Config;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BatchStarter.Base
{
    internal partial class FBaseFunc : FThread
    {
        private static FBaseFunc? _ins;
        public static FBaseFunc Ins
        {
            get { return _ins ??= new(); }
        }

        public FBaseConfig Cfg;

        private FPrintf? _log;

        private List<Process> _process;
        public List<Process> Process
        {
            get => _process;
        }
        private List<ProcessStartInfo> _cmd;

        public Queue<string> ResultMsg1;
        public Queue<string> ResultMsg2;
        public Queue<string> ResultMsg3;
        public Queue<string> ResultMsg4;

        private List<bool> _isInit;
        private List<bool> _isRun;

        internal const int CTRL_C_EVENT = 0;
        [DllImport("kernel32.dll")]
        internal static extern bool GenerateConsoleCtrlEvent(uint dwCtrlEvent, uint dwProcessGroupId);
        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern bool AttachConsole(uint dwProcessId);
        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        internal static extern bool FreeConsole();
        [DllImport("kernel32.dll")]
        static extern bool SetConsoleCtrlHandler(ConsoleCtrlDelegate? HandlerRoutine, bool Add);
        // Delegate type to be used as the Handler Routine for SCCH
        delegate Boolean ConsoleCtrlDelegate(uint CtrlType);
    }
}
