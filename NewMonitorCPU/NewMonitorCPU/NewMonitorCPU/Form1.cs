//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Threading;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Threading;
using System.Windows.Forms;



namespace NewMonitorCPU
{
    public partial class Main_Form : System.Windows.Forms.Form
    {

        #region 共用變數
        private System.Threading.Timer threadTimer1;//顯示當下日期時間
        private System.Threading.Timer threadTimer2;//執行刪除Log檔作業
        private string SysLog = Application.StartupPath + "\\SysLog";
        private string sTxtCPUMessage = "";
        private string sTotalCPUMessage = "";
        private string sRecordLogType = "";
        private DataGridViewRowCollection TotalCPUDB;
        private DataGridViewRowCollection CPUDB;
        private static PerformanceCounter mTotalcpu = new PerformanceCounter("Processor", "% Idle Time", "_Total");
        private static PerformanceCounter mTotalmemory = new PerformanceCounter("Memory", "% Committed Bytes in Use");

        private delegate void TDShowMessage(string sData);
        private delegate void TDCPU(string sID, string name, string ViewCPU, string ViewRAM);
        private delegate void TDTotalCPU(string sID, string sMessage, string TotalCPUEfficacyA);
        bool stopThread = false;
        TDShowMessage tDShowMessage;
        TDTotalCPU tDTotalCPU;
        TDCPU tDCPU;
        Thread thread1;
        int ExecutionSeconds;
        #endregion 共用變數


        public Main_Form()
        {
            InitializeComponent();
            tDShowMessage = new TDShowMessage(SetLeftTicker);
            tDCPU = new TDCPU(CPU_DataGridViewAdd);
            tDTotalCPU = new TDTotalCPU(TotalCPU_DataGridViewAdd);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ThreadTimerInitial();
            this.ThreadTimerInitial2();
            initial();
            string tTotalCpu = $"{mTotalcpu.NextValue():F0}";
            string sMessage = FileHelper.SaveExeLog(SysLog + "\\" + DateTime.Now.ToString("yyyyMMdd") + "SysLog.txt", @DateTime.Now.ToString("HHmmss") + ":系統開始");
            Start();

        }

        #region 按鈕類

        private void Start_Button_Click(object sender, EventArgs e)
        {
            string sMessage = FileHelper.SaveExeLog(SysLog + "\\" + DateTime.Now.ToString("yyyyMMdd") + "SysLog.txt", @DateTime.Now.ToString("HHmmss") + ":系統重新啟動");
            SendrichTextBox("系統重新啟動", "");
            ButtonState("Start");
            Start();
        }

        private void Pause_Button_Click(object sender, EventArgs e)
        {
            string sMessage = FileHelper.SaveExeLog(SysLog + "\\" + DateTime.Now.ToString("yyyyMMdd") + "SysLog.txt", @DateTime.Now.ToString("HHmmss") + ":程式已暫停");
            SendrichTextBox("程式已暫停", "Red");
            ButtonState("Pause");

            try
            { 
               stopThread = true;

            }
            catch
            {
                ;
            }
            finally
            {
                if (thread1.IsAlive)
                {
                    thread1.Abort();
                }
            }

        }

        private void Modify_Button_Click(object sender, EventArgs e)
        {
            string sMessage = FileHelper.SaveExeLog(SysLog + "\\" + DateTime.Now.ToString("yyyyMMdd") + "SysLog.txt", @DateTime.Now.ToString("HHmmss") + ":系統Ini檔編輯");
            SendrichTextBox("系統Ini檔編輯", "");

            LogTime_TextBox.Enabled = true;
            DirectoryPath_TextBox.Enabled = true;
            ProgramPerformance_TextBox.Enabled = true;
            ComputerPerformance_TextBox.Enabled = true;
            Start_Button.Enabled = false;
            Modify_Button.Enabled = false;
            Update_Button.Enabled = true;
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            string sMessage = FileHelper.SaveExeLog(SysLog + "\\" + DateTime.Now.ToString("yyyyMMdd") + "SysLog.txt", @DateTime.Now.ToString("HHmmss") + ":系統Ini檔更新");
            SendrichTextBox("系統Ini檔更新", "");
            sMessage = "";

            if (int.Parse(LogTime_TextBox.Text) > 100 || int.Parse(LogTime_TextBox.Text) <= 0)
            {
                sMessage += "偵測記錄秒數不可大於99秒或為0秒" + Environment.NewLine;
            }

            if (float.Parse(ProgramPerformance_TextBox.Text) < 0 || float.Parse(ProgramPerformance_TextBox.Text) > 100)
            {
                sMessage += "記錄程式CPU使用率不可小於0%或大於100%" + Environment.NewLine;
            }

            if (int.Parse(ComputerPerformance_TextBox.Text) < 0 || int.Parse(ComputerPerformance_TextBox.Text) > 100)
            {
                sMessage += "記錄程式CPU使用率不可小於0%或大於100%" + Environment.NewLine;
            }

            if (int.Parse(DeleteHour_TextBox.Text) < 0 || int.Parse(DeleteHour_TextBox.Text) > 23)
            {
                sMessage += "刪除Log小時不可以小於0小時或大於23小時" + Environment.NewLine;
            }

            if (int.Parse(DeleteMinute_TextBox.Text) < 0 || int.Parse(DeleteHour_TextBox.Text) > 60)
            {
                sMessage += "刪除Log分鐘不可以小於0分或大於59分" + Environment.NewLine;
            }

            if (int.Parse(DeleteDay_TextBox.Text) < 0 || int.Parse(DeleteDay_TextBox.Text) > 365)
            {
                sMessage += "刪除Log天數不可以小於0天或大於365天" + Environment.NewLine;
            }

            if (sMessage != "")
            {
                sMessage = "資料設定錯誤:" + Environment.NewLine + sMessage + "請重新設定!!";
                MessageBox.Show(sMessage);
            }
            else
            {
                LogTime_TextBox.Enabled = false;
                DirectoryPath_TextBox.Enabled = false;
                ProgramPerformance_TextBox.Enabled = false;
                ComputerPerformance_TextBox.Enabled = false;
                Start_Button.Enabled = true;
                Modify_Button.Enabled = true;
                Update_Button.Enabled = false;



                string RecordLogType = "Day";
                if (Hour_RadioButton.Checked == true)
                {
                    RecordLogType = "Hour";
                }
                string[] lines = { "[INI]",
                                   "LogTime=" + LogTime_TextBox.Text,
                                   "@DirectoryPath=" + DirectoryPath_TextBox.Text,
                                   "ProgramPerformance=" + ProgramPerformance_TextBox.Text,
                                   "ComputerPerformance=" + ComputerPerformance_TextBox.Text,
                                   "RecordLog="+RecordLogType,
                                   "DeleteDay="+DeleteDay_TextBox.Text,
                                   "DeleteHour="+DeleteHour_TextBox.Text+DeleteMinute_TextBox.Text,
                                 };
                sMessage = FileHelper.ModifyIni(@Application.StartupPath + "\\NewMonitorCPU.ini", lines);

                MessageBox.Show(sMessage);
                initial();

                sMessage = FileHelper.SaveExeLog(SysLog + "\\" + DateTime.Now.ToString("yyyyMMdd") + "SysLog.txt", @DateTime.Now.ToString("HHmmss") + ":系統重新啟動");
                SendrichTextBox("系統重新啟動", "");
                ButtonState("Start");
                Start();
            }
        }

        private void History_Button_Click(object sender, EventArgs e)
        {
            History_Form f2 = new History_Form();
            f2.strTextMsg = DirectoryPath_TextBox.Text;//把form1的值設定到form2
            f2.strComputerPerformance = ComputerPerformance_TextBox.Text;
            f2.Show();
        }

        #endregion 按鈕類

        #region 多執行緒執行類

        void disp()
        {
            while (stopThread == false)
            {
                try
                { 
                   string s =  GETData();//取CPU的效能及記憶體
                   Message_richTextBox.Invoke(tDShowMessage, new object[] { s });

                    if (ExecutionSeconds > 1)
                    {
                        Thread.Sleep((ExecutionSeconds-1)*1000);
                    }
                        
                }
                catch
                {

                }
            }
        }

        private void SetLeftTicker(string sMessage)
        {
            SendrichTextBox(sMessage, "Blue");
        }

        private void CPU_DataGridViewAdd(string sID,string name,string ViewCPU,string ViewRAM)
        {
            CPUDB.Add(new Object[] { sID, name, ViewCPU , ViewRAM });
            this.CPU_DataGridView.FirstDisplayedScrollingRowIndex = this.CPU_DataGridView.RowCount - 1;
        }

        private void TotalCPU_DataGridViewAdd(string sID, string sMessage ,string TotalCPUEfficacyA)
        {
            TotalCPUDB.Add(new Object[] { sID, "CPU使用量為 " + (TotalCPUEfficacyA).ToString() + "%" });
            if (double.Parse(TotalCPUEfficacyA) >= double.Parse(ComputerPerformance_TextBox.Text))
            {
                this.TotalCPU_DataGridView.Rows[this.TotalCPU_DataGridView.RowCount - 2].DefaultCellStyle.ForeColor = Color.Red;
            }
            else
            {
                this.TotalCPU_DataGridView.Rows[this.TotalCPU_DataGridView.RowCount - 2].DefaultCellStyle.ForeColor = Color.Blue;
            }
            this.TotalCPU_DataGridView.FirstDisplayedScrollingRowIndex = this.TotalCPU_DataGridView.RowCount - 1;
        }



        private void Start()
        {
            SendrichTextBox("程式開始執行", "");
            stopThread = false;
            thread1 = new Thread(new ThreadStart(disp));
            thread1.Start();
        }

        private string  GETData()
        {

            double TotalCPUEfficacy = 0;
            string sSaveFilePath = DirectoryPath_TextBox.Text + "\\" + DateTime.Now.ToString("yyyyMM");
            CreateDir(sSaveFilePath);
            string sFlg, sShowFlg;


            //若資料大於1萬則DataGridView清空重來
            if (this.CPU_DataGridView.Rows.Count >= 10000)
            {
                this.TotalCPU_DataGridView.DataSource = null;
                this.TotalCPU_DataGridView.Rows.Clear();
                this.CPU_DataGridView.DataSource = null;
                this.CPU_DataGridView.Rows.Clear();
            }

            string sID = DateTime.Now.ToString("yyyyMMddHHmmss");
            sShowFlg = "flase";

            sTxtCPUMessage = "";

            try
            {
                string tTotalCpu = $"{mTotalcpu.NextValue():F0}";
                ManagementObjectSearcher searcher = new ManagementObjectSearcher($"root\\CIMV2", "SELECT IDProcess,Name,PercentProcessorTime,WorkingSet FROM Win32_PerfFormattedData_PerfProc_Process where PercentProcessorTime > 0 ");
              
                Thread.Sleep(1000);
                    #region 明細資料
                    double ViewCPU = 0;
                 foreach (ManagementObject obj in searcher.Get())
                 {
                    ViewCPU = Math.Round((Convert.ToDouble($"{Convert.ToInt64(obj["PercentProcessorTime"]) / Environment.ProcessorCount:n0}")), 2);
                    string name = obj["Name"].ToString();
                    double ViewRAM = Math.Round((Convert.ToDouble($"{Convert.ToInt64(obj["WorkingSet"]):n0}") / 1024 / 1024), 2);

                    if (obj["IDProcess"].ToString() != "0")
                    {
                        TotalCPUEfficacy += ViewCPU;
                        if (ViewCPU >= float.Parse(ProgramPerformance_TextBox.Text))
                        { 
                            CPU_DataGridView.Invoke(tDCPU, new object[] { sID, name, ViewCPU + "%", ViewRAM + "MB" });
                            sTxtCPUMessage += String.Format("{0,-14};{1,-30};{2,10};{3,10}\n", sID, name, ViewCPU + "%", ViewRAM + "MB");
                            sShowFlg = "True";

                        }
                    }
                 }

                #endregion 明細資料

                if (sShowFlg == "True")
                {
                    sFlg = FileHelper.SaveCPULog(sSaveFilePath, sTxtCPUMessage, "CPU", sRecordLogType);
                    #region 總CPU資料

                    tTotalCpu = $"{mTotalcpu.NextValue():F0}";
                    string TotalCPUEfficacyA = (100 - int.Parse(tTotalCpu)).ToString().PadLeft(2, '0');

                    sTotalCPUMessage = String.Format("{0,-14};{1,10}",
                                                     sID, TotalCPUEfficacyA.ToString() + "%");

                    sFlg = FileHelper.SaveCPULog(sSaveFilePath, sTotalCPUMessage, "TotalCPU", "");


                    TotalCPU_DataGridView.Invoke(tDTotalCPU, new object[] { sID, "CPU使用量為 " + (TotalCPUEfficacyA).ToString() + "%", TotalCPUEfficacyA });

                    #endregion 總CPU資料
                }

            }
            catch (Exception ex)
            {
                if (ex.ToString().IndexOf("執行緒已經中止。")>-1)
                {
                    ;
                }
                else
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            return "程式執行中";
        }

        #endregion 多執行緒執行類

        #region 功能類

        #region  CreateDir
        private void CreateDir(string dir)
        {
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
        }
        #endregion

        private void ButtonState(string sType)
        {

            if (sType == "Start")
            {
                Start_Button.Enabled = false;
                Pause_Button.Enabled = true;
                Modify_Button.Enabled = false;
                History_Button.Enabled = false;
            }
            else
            {
                Start_Button.Enabled = true;
                Pause_Button.Enabled = false;
                Modify_Button.Enabled = true;
                History_Button.Enabled = true;
            }


        }

        private void initial()
        {
            Start_Button.Enabled = false;
            Pause_Button.Enabled = true;
            Update_Button.Enabled = false;
            Modify_Button.Enabled = false;
            Day_RadioButton.Enabled = false;
            Hour_RadioButton.Enabled = false;
            DeleteDay_TextBox.Enabled = false;
            DeleteHour_TextBox.Enabled = false;
            DeleteMinute_TextBox.Enabled = false;
            #region 取參數
            LogTime_TextBox.Text = Utility.GetLogTime();

            ExecutionSeconds = int.Parse(LogTime_TextBox.Text);

            string sSavePath = @Utility.DirectoryPath();

            if (sSavePath == "")
            {
                sSavePath = Application.StartupPath;
            }
            DirectoryPath_TextBox.Text = sSavePath + "\\Log";
            ProgramPerformance_TextBox.Text = Utility.ProgramPerformance();
            ComputerPerformance_TextBox.Text = Utility.ComputerPerformance();
            string RecordLogType = Utility.RecordLogType();

            Day_RadioButton.Checked = false;
            Hour_RadioButton.Checked = true;
            sRecordLogType = "Hour";
            if (RecordLogType == "" || RecordLogType == "Day")
            {
                Day_RadioButton.Checked = true;
                Hour_RadioButton.Checked = false;
                sRecordLogType = "Day";
            }

            string DeleteDay = Utility.DeleteDay();
            DeleteDay_TextBox.Text = DeleteDay;
            if (DeleteDay == "")
            {
                DeleteDay_TextBox.Text = "180";
            }

            string DeleteHour = Utility.DeleteHour();
            if (DeleteHour == "")
            {
                DeleteHour_TextBox.Text = "23";
                DeleteMinute_TextBox.Text = "00";
            }
            else
            {
                DeleteHour_TextBox.Text = DeleteHour.Substring(0, 2);
                DeleteMinute_TextBox.Text = DeleteHour.Substring(2, 2);
            }

            LogTime_TextBox.Enabled = false;
            DirectoryPath_TextBox.Enabled = false;
            ProgramPerformance_TextBox.Enabled = false;
            ComputerPerformance_TextBox.Enabled = false;

            TotalCPUDB = TotalCPU_DataGridView.Rows;
            TotalCPU_DataGridView.Rows.Clear();

            CPUDB = CPU_DataGridView.Rows;
            CPU_DataGridView.Rows.Clear();

           


            #endregion 取參數

            this.CreateDir(DirectoryPath_TextBox.Text);
            this.CreateDir(SysLog);
            //timer1.Enabled = false;
        }

        private void SendrichTextBox(string sMessage, string sColor)
        {
            Message_richTextBox.Focus();
            Message_richTextBox.Select(Message_richTextBox.TextLength, 0);
            Message_richTextBox.ScrollToCaret();

            Message_richTextBox.SelectionColor = Color.Black;
            if (sColor == "Red")
            {
                Message_richTextBox.SelectionColor = Color.Red;
            }
            else if (sColor == "Blue")
            {
                Message_richTextBox.SelectionColor = Color.Blue;
            }
            else if (sColor == "Purple")
            {
                Message_richTextBox.SelectionColor = Color.Purple;
            }

            Message_richTextBox.AppendText(DateTime.Now.ToString("HHmmss") + "：" + sMessage + Environment.NewLine);

        }

        #endregion 功能類

        #region 文字限制類


        private void LogTime_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void ProgramPerformance_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
            {
                e.Handled = true;
            }

            //小數點的處理。

            if (e.KeyChar == 46)
            {
                if (ProgramPerformance_TextBox.Text.Length == 0)
                    e.Handled = true;   //小數點不能在第一位
                else
                {
                    float f;
                    float oldf;
                    bool b1 = false, b2 = false;
                    b1 = float.TryParse(ProgramPerformance_TextBox.Text, out oldf);
                    b2 = float.TryParse(ProgramPerformance_TextBox.Text + e.KeyChar.ToString(), out f);
                    if (b2 == false)
                    {
                        if (b1 == true)
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                }
            }
        }

        private void ComputerPerformance_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void DeleteHour_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void DeleteMinute_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void DeleteDay_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        #endregion 文字限制類

        #region 背景執行類功能

        /// <summary>
        /// 顯示當下日期時間
        /// </summary>
        private void ThreadTimerInitial()
        {
            threadTimer1 = new System.Threading.Timer(threadTimer_Tick, null, 100, 1000);
        }


        /// <summary>
        /// 執行刪除Log檔作業
        /// </summary>
        private void ThreadTimerInitial2()
        {
            threadTimer2 = new System.Threading.Timer(threadTimer2_Tick, null, 100, 1000);
        }

        private void threadTimer2_Tick(object state)
        {
            if (DateTime.Now.ToString("HHmmss") == DeleteHour_TextBox.Text + DeleteMinute_TextBox.Text + "00")
            {

                this.BeginInvoke(new Action(() =>
                {
                    FileHelper.DeleteLog(DeleteDay_TextBox.Text, DirectoryPath_TextBox.Text, SysLog);
                }));
            }
        }

        /// <summary>
        /// 執行續Timer
        /// </summary>
        /// <param name="states"></param>
        private void threadTimer_Tick(object states)
        {
            try
            { 
               this.BeginInvoke(new Action(() =>
               {
                   this.toolLabelNowTime.Text = $"現在時間： {DateTime.Now.ToString("yyyyMMdd HH:mm:ss")}";
               }));
            }
            catch
            {

            }
        }


        #endregion 背景執行類功能

        #region 元件類
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.ShowInTaskbar == false)
                notifyIcon1.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            this.Show();
            this.Activate();
        }

        private void Main_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.notifyIcon1.Visible = false;
        }

        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("是否要關閉程式 ?", "警告訊息", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {

                string sMessage = FileHelper.SaveExeLog(SysLog + "\\" + DateTime.Now.ToString("yyyyMMdd") + "SysLog.txt", @DateTime.Now.ToString("HHmmss") + ":結束系統");
                try
                {
                    threadTimer1.Dispose();
                    threadTimer2.Dispose();
                }
                catch
                {
                    ;
                }
                finally
                {
                    if (thread1.IsAlive)
                    {
                        thread1.Abort();
                    }
                }
                Environment.Exit(0);
            }
            else
            {
                string sMessage = FileHelper.SaveExeLog(SysLog + "\\" + DateTime.Now.ToString("yyyyMMdd") + "SysLog.txt", @DateTime.Now.ToString("HHmmss") + ":結束系統");
                this.WindowState = FormWindowState.Normal;
                notifyIcon1.Visible = true;
                this.ShowInTaskbar = false;
                e.Cancel = true;
            }
        }

        private void notifyIcon1_MouseMove(object sender, MouseEventArgs e)
        {
            //notifyIcon1.ShowBalloonTip(3000);
        }

        private void Main_Form_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.notifyIcon1.Visible = true;
                this.Hide();
            }
            else
            {
                this.notifyIcon1.Visible = false;
            }
        }

        private void 開啟ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sMessage = FileHelper.SaveExeLog(SysLog + "\\" + DateTime.Now.ToString("yyyyMMdd") + "SysLog.txt", @DateTime.Now.ToString("HHmmss") + ":系統開啟畫面");
            SendrichTextBox("系統開啟畫面", "");
            if (this.ShowInTaskbar == false)
                notifyIcon1.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            this.Show();
            this.Activate();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string sMessage = FileHelper.SaveExeLog(SysLog + "\\" + DateTime.Now.ToString("yyyyMMdd") + "SysLog.txt", @DateTime.Now.ToString("HHmmss") + ":開啟Log檔案目錄");
            SendrichTextBox("開啟Log檔案目錄", "");
            Process.Start(DirectoryPath_TextBox.Text);
        }

        private void 離開ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("是否要關閉程式 ?", "警告訊息", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {

                string sMessage = FileHelper.SaveExeLog(SysLog + "\\" + DateTime.Now.ToString("yyyyMMdd") + "SysLog.txt", @DateTime.Now.ToString("HHmmss") + ":結束系統");
                try
                {
                    threadTimer1.Dispose();
                    threadTimer2.Dispose();
                }
                catch
                {
                    ;
                }
                finally
                {
                    if (thread1.IsAlive)
                    {
                        thread1.Abort();
                    }
                }
                Environment.Exit(0);
            }
            else
            {
                ;
            }
        }


        #endregion 元件類

        private void TotalCPU_DataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
                string value = "false";

                for (int i = 0; i < CPU_DataGridView.Rows.Count - 1; i++)
                {
                    if (TotalCPU_DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString() == CPU_DataGridView.Rows[i].Cells[0].Value.ToString())
                    {
                        if (value == "false")
                        {
                            this.CPU_DataGridView.FirstDisplayedScrollingRowIndex = i;
                        }
                        this.CPU_DataGridView.Rows[i].DefaultCellStyle.ForeColor = Color.Maroon;
                        DataGridViewCellStyle style = this.CPU_DataGridView.Rows[i].DefaultCellStyle;
                        style.Font = new Font(this.CPU_DataGridView.Font, FontStyle.Bold);

                        value = "true";

                    }
                    else
                    {
                        this.CPU_DataGridView.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                        DataGridViewCellStyle style = this.CPU_DataGridView.Rows[i].DefaultCellStyle;
                        style.Font = new Font(this.CPU_DataGridView.Font, FontStyle.Regular);
                    }

                }
            }
    }
}
