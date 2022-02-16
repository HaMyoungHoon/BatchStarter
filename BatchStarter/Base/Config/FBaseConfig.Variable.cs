using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchStarter.Base.Config
{
    internal partial class FBaseConfig
    {
        private const string _cfgPath = "BatchStarterCfg.xml";
        public string LogPath { get; private set; } = @"Log\Main";
        public string LogFile { get; private set; } = "MainLog.log";

        public int CmdCount { get; set; } = 4;
        public List<string> BatchPath { get; set; }
    }
}
