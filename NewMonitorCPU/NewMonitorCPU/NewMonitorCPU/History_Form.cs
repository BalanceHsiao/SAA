using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewMonitorCPU
{
    public partial class History_Form : Form
    {


        public string sLogFilePath = "";
        public string sComputerPerformance = "";
        private DataGridViewRowCollection TotalCPUDB;
        private DataGridViewRowCollection CPUDB;


        public History_Form()
        {
            InitializeComponent();
        }

        public History_Form(string strTextMsg)
        {
            InitializeComponent();
            sLogFilePath = strTextMsg;
        }

        public string strTextMsg
        {
            set
            {
                sLogFilePath = value; ;
            }
            get
            {

                return sLogFilePath;
            }

        }


        public string strComputerPerformance
        {
            set
            {
                sComputerPerformance = value; ;
            }
            get
            {

                return sComputerPerformance;
            }
        }


        private void Start_Button_Click(object sender, EventArgs e)
        {

            TotalCPUDB = TotalCPU_DataGridView.Rows;
            this.TotalCPU_DataGridView.DataSource = null;
            this.TotalCPU_DataGridView.Rows.Clear();

            CPUDB = CPU_DataGridView.Rows;
            this.CPU_DataGridView.DataSource = null;
            this.CPU_DataGridView.Rows.Clear();

            #region 確認日期是否正確
            DateTime dateTimeS = Convert.ToDateTime($"{long.Parse(LogImportS_DateTimePicker.Text):0000-00-00}");
            DateTime dateTimeE = Convert.ToDateTime($"{long.Parse(LogImportE_DateTimePicker.Text):0000-00-00}");
            DataTable dataTable = new DataTable();
            int num = ((TimeSpan)(dateTimeE - dateTimeS)).Days + 1;


            if (dateTimeS > dateTimeE)
            {
                MessageBox.Show("結束日不可大於開始日本，請重新選取！！");
                return;
            }
            #endregion 確認日期是否正確

            string nextLine;
            FileStream fileStream;
            StreamReader str;


            for (int i = 0; i < num; i++)
            {
                #region 匯入資料
                string LogImportDate = dateTimeS.AddDays(i).ToString("yyyyMMdd");
                string LoadCPUFilePath = string.Format("{0}\\{1}\\{2}_CPU.CSV", sLogFilePath, LogImportDate.Substring(0, 6), LogImportDate);
                string LoadTotalCPUFilePath = string.Format("{0}\\{1}\\TotleCPU.CSV", sLogFilePath, LogImportDate.Substring(0, 6));


                if (File.Exists(LoadTotalCPUFilePath))
                {
                     fileStream = new FileStream(LoadTotalCPUFilePath, FileMode.Open, FileAccess.Read);
                     str = new StreamReader(fileStream, Encoding.UTF8);

                    while ((nextLine = str.ReadLine()) != null)
                    {
                        string[] TotalCPUList = Regex.Split(nextLine, ";", RegexOptions.IgnoreCase);

                        if (TotalCPUList[0].ToString().Trim().Substring(0, 8) == LogImportDate)
                        {
                            TotalCPUDB.Add(new Object[] { TotalCPUList[0].ToString().Trim(), TotalCPUList[1].ToString().Trim() });
                            if (float.Parse(TotalCPUList[1].ToString().Replace("CPU使用量為 ", "").Replace("%", "").Trim()) > float.Parse(sComputerPerformance))
                            {
                                this.TotalCPU_DataGridView.Rows[this.TotalCPU_DataGridView.RowCount - 2].DefaultCellStyle.ForeColor = Color.Red;
                            }
                            else
                            {
                                this.TotalCPU_DataGridView.Rows[this.TotalCPU_DataGridView.RowCount - 2].DefaultCellStyle.ForeColor = Color.Blue;
                            }
                        }
                        else if (TotalCPUList[0].ToString().Trim().Substring(0, 8) == LogImportDate)
                        {
                            break;
                        }

                    }
                    str.Close();
                }

                if (File.Exists(LoadCPUFilePath))
                {
                     fileStream = new FileStream(LoadCPUFilePath, FileMode.Open, FileAccess.Read);
                     str = new StreamReader(fileStream, Encoding.UTF8);
                    while ((nextLine = str.ReadLine()) != null)
                    {
                        if (nextLine!="")
                        { 
                            string[] CPUList = Regex.Split(nextLine, ";", RegexOptions.IgnoreCase);
                            CPUDB.Add(new Object[] { CPUList[0].ToString().Trim(), CPUList[1].ToString().Trim().Replace("PID:", ""), CPUList[2].ToString().Trim().Replace("CPU:", ""), CPUList[3].ToString().Trim().Replace("RAM:", "") });
                        }
                    }
                    str.Close();
                }
                #endregion 匯入資料

            }

        }

        private void History_Form_Load(object sender, EventArgs e)
        {
            LogImportS_DateTimePicker.MaxDate = DateTime.Now.Date;
            LogImportE_DateTimePicker.MaxDate = DateTime.Now.Date;
        }

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
