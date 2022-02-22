using BaseLib_Net6;
using System.IO;

namespace BatchStarter.Base.Config
{
    internal partial class FBaseConfig
    {
        public FBaseConfig()
        {
            BatchPath = new();
        }

        private static bool CheckFolder(string path)
        {
            string temp = path;
            DirectoryInfo filePath = new(path);
            DirectoryInfo di = new(temp.Replace(filePath.Name, ""));

            if (di.Exists == false)
            {
                di.Create();
                return false;
            }

            return true;
        }
        private static bool CheckFile(string path)
        {
            if (File.Exists(path) == false)
            {
                using (File.Create(path))
                {

                }

                return false;
            }

            return true;
        }
        private void CreateSettingFile()
        {
            string filePath = $@"{Directory.GetCurrentDirectory()}\Setting\{_cfgPath}";
            CheckFolder(filePath);
            if (CheckFile(filePath))
            {
                return;
            }

            File.WriteAllText(filePath, "<?xml version='1.0' encoding='UTF-8'?>\n<BATCH>\n</BATCH>");
            FFileParser xmlData = new(filePath, FFileParser.FILE_TYPE.XML);
            CreateUtil(xmlData);
            CreateBatchDetail(xmlData);
        }
        private void CreateUtil(FFileParser data)
        {
            data.SetInt("BATCH,UTIL,COUNT", 4);
        }
        private void CreateBatchDetail(FFileParser data)
        {
            data.SetString($@"BATCH,PATH{0}", "");
            data.SetString($@"BATCH,PATH{1}", "");
            data.SetString($@"BATCH,PATH{2}", "");
            data.SetString($@"BATCH,PATH{3}", "");
        }
        public void LoadSettingFile()
        {
            CreateSettingFile();
            string filePath = $@"{Directory.GetCurrentDirectory()}\Setting\{_cfgPath}";
            FFileParser xmlData = new(filePath, FFileParser.FILE_TYPE.XML);
            LoadUtil(xmlData);
            LoadBatchDetail(xmlData);
        }
        public void LoadUtil(FFileParser data)
        {
            CmdCount = data.GetInt("BATCH,UTIL,COUNT", 0);
        }
        public void LoadBatchDetail(FFileParser data)
        {
            for (int i = 0; i < CmdCount; i++)
            {
                BatchPath.Add(data.GetString($@"BATCH,PATH{i}", ""));
            }    
        }

        public void SetCmdCount(int count)
        {
            string filePath = $@"{Directory.GetCurrentDirectory()}\Setting\{_cfgPath}";
            FFileParser xmlData = new(filePath, FFileParser.FILE_TYPE.XML);
            xmlData.SetInt("BATCH,UTIL,COUNT", count);
        }
        public void SetBatchPath(int index, string path)
        {
            string filePath = $@"{Directory.GetCurrentDirectory()}\Setting\{_cfgPath}";
            FFileParser xmlData = new(filePath, FFileParser.FILE_TYPE.XML);
            xmlData.SetString($@"BATCH,PATH{index}", path);
            BatchPath[index] = path;
        }
    }
}
