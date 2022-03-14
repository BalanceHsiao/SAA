using System;
using System.IO;

namespace NewMonitorCPU
{
    class FileHelper
    {

        /// <summary>
        /// 執行存入本執行各項操作記錄的方法
        /// </summary>SaveExeLog
        /// <param name="SavePathFileName">Log存檔的路徑及檔案名稱</param>
        /// <param name="SaveMessage">Log存檔的內容</param>
        /// <returns>回傳成功或件敗的訊息，成功會回傳OK,失敗會回傳錯誤訊息</returns>
        public static string SaveExeLog(string SavePathFileName, string SaveMessage)
        {

            try
            {
                using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter(SavePathFileName, true))
                {
                    file.WriteLine(SaveMessage);
                }
            }
            catch (Exception ex)
            {

                return "Ini檔異動異常，異常原因：" + Environment.NewLine + ex.ToString();
            }

            return "OK";

        }

        /// <summary>
        /// 執行參數異動的方法
        /// </summary>ModifyIni
        /// <param name="SavePathFileName">Log存檔的路徑及檔案名稱</param>
        /// <param name="SaveMessage">Log存檔的內容</param>
        /// <returns>回傳成功或件敗的訊息，成功會回傳OK"Ini檔異動成功!",失敗會回傳錯誤訊息</returns>
        public static string ModifyIni(string SavePathFileName, string[] SaveMessage)
        {
            try
            {
                using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter(SavePathFileName, false))
                {
                    foreach (string line in SaveMessage)
                    {
                        file.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {

                return "Ini檔異動異常，異常原因：" + Environment.NewLine + ex.ToString();
            }


            return "Ini檔異動成功!";

        }

        /// <summary>
        /// 執行存入Log檔的方法
        /// </summary>SaveCPULog
        /// <param name="SavePathFileName">存入的檔案</param>
        /// <param name="sSaveMessage">存入的訊息</param>
        /// <param name="sType">1=單體CPU效能,2=總體CPU效能</param>
        /// <param name="sSaveLogType">Day=檔案依yyyyMMdd格式存入,Hour=檔案依yyyyMMddHH格式存入,""=不處理</param>
        /// <returns>訊息</returns>
        public static string SaveCPULog(string SavePathFileName, string sSaveMessage, string sType, string sSaveLogType)
        {
            switch (sType)
            {
                case "TotalCPU":

                    var TotalCPUheader = String.Format("{0,-14};{1,10}\n",
                              "Log Time", "TotalCPU (%)");

                    SavePathFileName += "\\TotleCPU.CSV";

                    if (!File.Exists(@SavePathFileName))
                    {
                        sSaveMessage = TotalCPUheader + sSaveMessage;
                    }



                    break;
                case "CPU":

                    if (sSaveLogType == "Day")
                    {
                        SavePathFileName += "\\" + DateTime.Now.ToString("yyyyMMdd") + "_CPU.CSV";
                    }
                    else
                    {
                        SavePathFileName += "\\" + DateTime.Now.ToString("yyyyMMddHH") + "_CPU.CSV";
                    }

                    var CPUheader = String.Format("{0,-14};{1,-30};{2,10};{3,10}\n",
                                   "Log Time", "PG Name", "CPU (%)", "MEMORY (M)");

                    //SavePathFileName += "\\TotleCPU.CSV";

                    if (!File.Exists(@SavePathFileName))
                    {
                        sSaveMessage = CPUheader + sSaveMessage;
                    }

                    sSaveMessage = sSaveMessage.Substring(0, sSaveMessage.LastIndexOf("\n"));//截取文件流去掉最后一个换行

                    break;
                default:
                    break;
            }

            try
            {
                using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter(SavePathFileName, true))
                {
                    file.WriteLine(sSaveMessage);

                }
            }
            catch (Exception ex)
            {

                return "" + Environment.NewLine + ex.ToString();
            }

            return "";


        }

        /// <summary>
        /// 執行刪除Log檔的方法
        /// </summary>DeleteLog
        /// <param name="sDay">刪除多少天前的檔</param>
        /// <param name="sDeletePath">刪除的Log錄</param>
        /// <param name="SysLog">刪除的系統目錄</param>
        /// <returns>訊息</returns>
        public static void DeleteLog(string sDay, string sDeletePath, string SysLog)
        {

            int DeleteDay = int.Parse(DateTime.Now.AddDays(0 - int.Parse(sDay)).ToString("yyyyMMdd"));

            //刪除系統檔
            #region 刪除系統檔
            string[] filePaths = Directory.GetFiles(SysLog);
            foreach (string filePath in filePaths)
            {
                FileInfo f = new FileInfo(filePath);
                int FileCreateDay = int.Parse(f.CreationTime.ToString("yyyyMMdd"));
                if (FileCreateDay <= DeleteDay)
                {
                    File.Delete(filePath);
                }
            }
            #endregion 刪除系統檔 

            //刪除CPU記錄檔
            #region 刪除CPU及TotalCPU記錄檔
            string[] dirs = Directory.GetDirectories(sDeletePath);

            System.Collections.ArrayList dirlist = new System.Collections.ArrayList();/*用來儲存只有目錄名的集合*/

            foreach (string item in dirs)
            {
                dirlist.Add(Path.GetFileNameWithoutExtension(item));//走訪每個元素只取得目錄名稱(不含路徑)並加入dirlist集合中
            }

            foreach (var item in dirlist)
            {//顯示目錄名稱(不含路徑)

                string[] CPUfilePaths = Directory.GetFiles(sDeletePath + "\\" + item);

                foreach (string filePath in CPUfilePaths)
                {
                    FileInfo f = new FileInfo(filePath);
                    int FileCreateDay = int.Parse(f.CreationTime.ToString("yyyyMMdd"));
                    if (FileCreateDay <= DeleteDay)
                    {
                        File.Delete(filePath);
                    }
                }
            }

            #endregion 刪除CPU及TotalCPU記錄檔


        }


    }
}
