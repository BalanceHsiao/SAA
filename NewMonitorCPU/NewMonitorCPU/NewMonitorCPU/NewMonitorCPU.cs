using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace NewMonitorCPU
{
    class NewMonitorCPU
    {
    }

    class Utility
    {
        const string filename = "NewMonitorCPU.ini";

        #region 取得文字資料
        public static string GetIniString(string a, string b)
        {
            SetupIniIP ini = new SetupIniIP();
            try
            {
                if (File.Exists(Application.StartupPath + "\\" + filename))
                {
                    return ini.IniReadValue(a, b, filename);//連線字串 
                }
            }
            catch (Exception)
            {
                return "-1";
            }
            return "-1";
        }


        #endregion 取得文字資料

        #region 解析文字檔功能
        public class SetupIniIP
        {
            [DllImport("kernel32", CharSet = CharSet.Unicode)]
            private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
            [DllImport("kernel32", CharSet = CharSet.Unicode)]
            private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);




            public void IniWriteValue(string Section, string Key, string Value, string inipath)
            {
                WritePrivateProfileString(Section, Key, Value, Application.StartupPath + "\\" + inipath);
            }
            public string IniReadValue(string Section, string Key, string inipath)
            {
                //Byte[] temp = new Byte[128];//512 65535
                StringBuilder temp = new StringBuilder(4096);
                int i = GetPrivateProfileString(Section, Key, "", temp, 4096, Application.StartupPath + "\\" + inipath);

                return temp.ToString();
            }
        }
        #endregion 解析文字檔功能

        #region 取得每次存入記錄秒數
        public static string GetLogTime()
        {
            return GetIniString("INI", "LogTime");
        }
        #endregion 取得每次存入記錄秒數

        #region 取得存入記錄目錄
        public static string DirectoryPath()
        {
            return GetIniString("INI", "DirectoryPath");
        }
        #endregion 取得存入記錄目錄

        #region 取得程式效能比
        public static string ProgramPerformance()
        {
            return GetIniString("INI", "ProgramPerformance");
        }
        #endregion 取得程式效能比

        #region 取得電腦效能比
        public static string ComputerPerformance()
        {
            return GetIniString("INI", "ComputerPerformance");
        }
        #endregion 取得電腦效能比

        #region 取得記錄log的時間模式
        public static string RecordLogType()
        {
            return GetIniString("INI", "RecordLog");
        }
        #endregion 取得記錄log的時間模式

        #region 取得每天幾點刪除Log的時間點
        public static string DeleteHour()
        {
            return GetIniString("INI", "DeleteHour");
        }
        #endregion 取得每天幾點刪除Log的時間點

        #region 取得多少天前刪除Log檔的天數
        public static string DeleteDay()
        {
            return GetIniString("INI", "DeleteDay");
        }
        #endregion 取得多少天前刪除Log檔的天數

    }

}
