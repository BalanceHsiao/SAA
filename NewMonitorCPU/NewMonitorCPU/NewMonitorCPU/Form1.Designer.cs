namespace NewMonitorCPU
{
    partial class Main_Form
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.History_Button = new System.Windows.Forms.Button();
            this.Pause_Button = new System.Windows.Forms.Button();
            this.Start_Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Hour_RadioButton = new System.Windows.Forms.RadioButton();
            this.Day_RadioButton = new System.Windows.Forms.RadioButton();
            this.Update_Button = new System.Windows.Forms.Button();
            this.DeleteMinute_TextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DeleteHour_TextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DeleteDay_TextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ComputerPerformance_TextBox = new System.Windows.Forms.TextBox();
            this.lb_InvMsg = new System.Windows.Forms.Label();
            this.Modify_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ProgramPerformance_TextBox = new System.Windows.Forms.TextBox();
            this.lbRefreshTime = new System.Windows.Forms.Label();
            this.SelectDirectory_Button = new System.Windows.Forms.Button();
            this.DirectoryPath_TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LogTime_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.Message_richTextBox = new System.Windows.Forms.RichTextBox();
            this.CPU_DataGridView = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCPU_DataGridView = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolLabelNowTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.開啟ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.離開ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPU_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalCPU_DataGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // History_Button
            // 
            this.History_Button.Enabled = false;
            this.History_Button.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.History_Button.Image = ((System.Drawing.Image)(resources.GetObject("History_Button.Image")));
            this.History_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.History_Button.Location = new System.Drawing.Point(256, 10);
            this.History_Button.Margin = new System.Windows.Forms.Padding(4);
            this.History_Button.Name = "History_Button";
            this.History_Button.Size = new System.Drawing.Size(150, 52);
            this.History_Button.TabIndex = 57;
            this.History_Button.Text = "歷史查詢";
            this.History_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.History_Button.UseVisualStyleBackColor = true;
            this.History_Button.Click += new System.EventHandler(this.History_Button_Click);
            // 
            // Pause_Button
            // 
            this.Pause_Button.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Pause_Button.Image = ((System.Drawing.Image)(resources.GetObject("Pause_Button.Image")));
            this.Pause_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Pause_Button.Location = new System.Drawing.Point(131, 10);
            this.Pause_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Pause_Button.Name = "Pause_Button";
            this.Pause_Button.Size = new System.Drawing.Size(117, 52);
            this.Pause_Button.TabIndex = 56;
            this.Pause_Button.Text = "暫停";
            this.Pause_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Pause_Button.UseVisualStyleBackColor = true;
            this.Pause_Button.Click += new System.EventHandler(this.Pause_Button_Click);
            // 
            // Start_Button
            // 
            this.Start_Button.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Start_Button.Image = ((System.Drawing.Image)(resources.GetObject("Start_Button.Image")));
            this.Start_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Start_Button.Location = new System.Drawing.Point(6, 10);
            this.Start_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(117, 52);
            this.Start_Button.TabIndex = 55;
            this.Start_Button.Text = "啟動";
            this.Start_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Start_Button.UseVisualStyleBackColor = true;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Hour_RadioButton);
            this.panel1.Controls.Add(this.Day_RadioButton);
            this.panel1.Controls.Add(this.Update_Button);
            this.panel1.Controls.Add(this.DeleteMinute_TextBox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.DeleteHour_TextBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.DeleteDay_TextBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ComputerPerformance_TextBox);
            this.panel1.Controls.Add(this.lb_InvMsg);
            this.panel1.Controls.Add(this.Modify_Button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ProgramPerformance_TextBox);
            this.panel1.Controls.Add(this.lbRefreshTime);
            this.panel1.Controls.Add(this.SelectDirectory_Button);
            this.panel1.Controls.Add(this.DirectoryPath_TextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.LogTime_TextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label55);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1511, 166);
            this.panel1.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(851, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 15);
            this.label2.TabIndex = 81;
            this.label2.Text = "/";
            this.label2.Visible = false;
            // 
            // Hour_RadioButton
            // 
            this.Hour_RadioButton.AutoSize = true;
            this.Hour_RadioButton.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Hour_RadioButton.ForeColor = System.Drawing.Color.Red;
            this.Hour_RadioButton.Location = new System.Drawing.Point(881, 171);
            this.Hour_RadioButton.Name = "Hour_RadioButton";
            this.Hour_RadioButton.Size = new System.Drawing.Size(73, 19);
            this.Hour_RadioButton.TabIndex = 80;
            this.Hour_RadioButton.TabStop = true;
            this.Hour_RadioButton.Text = "每小時";
            this.Hour_RadioButton.UseVisualStyleBackColor = true;
            this.Hour_RadioButton.Visible = false;
            // 
            // Day_RadioButton
            // 
            this.Day_RadioButton.AutoSize = true;
            this.Day_RadioButton.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Day_RadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Day_RadioButton.Location = new System.Drawing.Point(761, 171);
            this.Day_RadioButton.Name = "Day_RadioButton";
            this.Day_RadioButton.Size = new System.Drawing.Size(58, 19);
            this.Day_RadioButton.TabIndex = 79;
            this.Day_RadioButton.TabStop = true;
            this.Day_RadioButton.Text = "每天";
            this.Day_RadioButton.UseVisualStyleBackColor = true;
            this.Day_RadioButton.Visible = false;
            // 
            // Update_Button
            // 
            this.Update_Button.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Update_Button.Image = ((System.Drawing.Image)(resources.GetObject("Update_Button.Image")));
            this.Update_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Update_Button.Location = new System.Drawing.Point(1314, 71);
            this.Update_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(123, 52);
            this.Update_Button.TabIndex = 78;
            this.Update_Button.Text = "更新";
            this.Update_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Update_Button.UseVisualStyleBackColor = true;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // DeleteMinute_TextBox
            // 
            this.DeleteMinute_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DeleteMinute_TextBox.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DeleteMinute_TextBox.Location = new System.Drawing.Point(263, 168);
            this.DeleteMinute_TextBox.MaxLength = 2;
            this.DeleteMinute_TextBox.Name = "DeleteMinute_TextBox";
            this.DeleteMinute_TextBox.Size = new System.Drawing.Size(63, 25);
            this.DeleteMinute_TextBox.TabIndex = 77;
            this.DeleteMinute_TextBox.Text = "30";
            this.DeleteMinute_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DeleteMinute_TextBox.Visible = false;
            this.DeleteMinute_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DeleteMinute_TextBox_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(226, 173);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 15);
            this.label10.TabIndex = 76;
            this.label10.Text = "：";
            this.label10.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(333, 173);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 15);
            this.label9.TabIndex = 75;
            this.label9.Text = "點(24小時制)，刪除";
            this.label9.Visible = false;
            // 
            // DeleteHour_TextBox
            // 
            this.DeleteHour_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DeleteHour_TextBox.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DeleteHour_TextBox.Location = new System.Drawing.Point(163, 168);
            this.DeleteHour_TextBox.MaxLength = 2;
            this.DeleteHour_TextBox.Name = "DeleteHour_TextBox";
            this.DeleteHour_TextBox.Size = new System.Drawing.Size(63, 25);
            this.DeleteHour_TextBox.TabIndex = 74;
            this.DeleteHour_TextBox.Text = "23";
            this.DeleteHour_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DeleteHour_TextBox.Visible = false;
            this.DeleteHour_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DeleteHour_TextBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(659, 173);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 15);
            this.label8.TabIndex = 73;
            this.label8.Text = "天前的Log檔";
            this.label8.Visible = false;
            // 
            // DeleteDay_TextBox
            // 
            this.DeleteDay_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DeleteDay_TextBox.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DeleteDay_TextBox.Location = new System.Drawing.Point(575, 168);
            this.DeleteDay_TextBox.MaxLength = 3;
            this.DeleteDay_TextBox.Name = "DeleteDay_TextBox";
            this.DeleteDay_TextBox.Size = new System.Drawing.Size(77, 25);
            this.DeleteDay_TextBox.TabIndex = 72;
            this.DeleteDay_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DeleteDay_TextBox.Visible = false;
            this.DeleteDay_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DeleteDay_TextBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(38, 173);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 71;
            this.label7.Text = "系統每天";
            this.label7.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(446, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(542, 24);
            this.label4.TabIndex = 70;
            this.label4.Text = "%的資訊存成TotleCPU.CSV檔，每月產生一個Log檔";
            // 
            // ComputerPerformance_TextBox
            // 
            this.ComputerPerformance_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ComputerPerformance_TextBox.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ComputerPerformance_TextBox.Location = new System.Drawing.Point(354, 116);
            this.ComputerPerformance_TextBox.MaxLength = 3;
            this.ComputerPerformance_TextBox.Name = "ComputerPerformance_TextBox";
            this.ComputerPerformance_TextBox.Size = new System.Drawing.Size(63, 35);
            this.ComputerPerformance_TextBox.TabIndex = 69;
            this.ComputerPerformance_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ComputerPerformance_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComputerPerformance_TextBox_KeyPress);
            // 
            // lb_InvMsg
            // 
            this.lb_InvMsg.AutoSize = true;
            this.lb_InvMsg.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_InvMsg.Location = new System.Drawing.Point(37, 124);
            this.lb_InvMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_InvMsg.Name = "lb_InvMsg";
            this.lb_InvMsg.Size = new System.Drawing.Size(294, 24);
            this.lb_InvMsg.TabIndex = 68;
            this.lb_InvMsg.Text = "記錄電腦CPU總使用率大於";
            // 
            // Modify_Button
            // 
            this.Modify_Button.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Modify_Button.Image = ((System.Drawing.Image)(resources.GetObject("Modify_Button.Image")));
            this.Modify_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Modify_Button.Location = new System.Drawing.Point(1170, 71);
            this.Modify_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Modify_Button.Name = "Modify_Button";
            this.Modify_Button.Size = new System.Drawing.Size(123, 52);
            this.Modify_Button.TabIndex = 67;
            this.Modify_Button.Text = "編輯";
            this.Modify_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Modify_Button.UseVisualStyleBackColor = true;
            this.Modify_Button.Click += new System.EventHandler(this.Modify_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(446, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(642, 24);
            this.label1.TabIndex = 66;
            this.label1.Text = "%的資訊存成YYYYMMDD_CPU.CSV檔，每天產生一個Log檔";
            // 
            // ProgramPerformance_TextBox
            // 
            this.ProgramPerformance_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ProgramPerformance_TextBox.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ProgramPerformance_TextBox.Location = new System.Drawing.Point(354, 67);
            this.ProgramPerformance_TextBox.MaxLength = 5;
            this.ProgramPerformance_TextBox.Name = "ProgramPerformance_TextBox";
            this.ProgramPerformance_TextBox.Size = new System.Drawing.Size(63, 35);
            this.ProgramPerformance_TextBox.TabIndex = 65;
            this.ProgramPerformance_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProgramPerformance_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProgramPerformance_TextBox_KeyPress);
            // 
            // lbRefreshTime
            // 
            this.lbRefreshTime.AutoSize = true;
            this.lbRefreshTime.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbRefreshTime.Location = new System.Drawing.Point(13, 71);
            this.lbRefreshTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRefreshTime.Name = "lbRefreshTime";
            this.lbRefreshTime.Size = new System.Drawing.Size(318, 24);
            this.lbRefreshTime.TabIndex = 64;
            this.lbRefreshTime.Text = "記錄程式CPU使用率大於等於";
            // 
            // SelectDirectory_Button
            // 
            this.SelectDirectory_Button.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SelectDirectory_Button.Location = new System.Drawing.Point(1147, 12);
            this.SelectDirectory_Button.Name = "SelectDirectory_Button";
            this.SelectDirectory_Button.Size = new System.Drawing.Size(58, 38);
            this.SelectDirectory_Button.TabIndex = 63;
            this.SelectDirectory_Button.Text = "...";
            this.SelectDirectory_Button.UseVisualStyleBackColor = true;
            // 
            // DirectoryPath_TextBox
            // 
            this.DirectoryPath_TextBox.BackColor = System.Drawing.Color.White;
            this.DirectoryPath_TextBox.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DirectoryPath_TextBox.Location = new System.Drawing.Point(527, 14);
            this.DirectoryPath_TextBox.Name = "DirectoryPath_TextBox";
            this.DirectoryPath_TextBox.Size = new System.Drawing.Size(609, 35);
            this.DirectoryPath_TextBox.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(132, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(370, 24);
            this.label5.TabIndex = 61;
            this.label5.Text = "秒進行偵測並記錄，並將檔案存入";
            // 
            // LogTime_TextBox
            // 
            this.LogTime_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LogTime_TextBox.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LogTime_TextBox.Location = new System.Drawing.Point(58, 14);
            this.LogTime_TextBox.MaxLength = 2;
            this.LogTime_TextBox.Name = "LogTime_TextBox";
            this.LogTime_TextBox.Size = new System.Drawing.Size(63, 35);
            this.LogTime_TextBox.TabIndex = 60;
            this.LogTime_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LogTime_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LogTime_TextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(1216, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 24);
            this.label3.TabIndex = 59;
            this.label3.Text = "下的YYYYMM目錄中";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label55.Location = new System.Drawing.Point(13, 19);
            this.label55.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(34, 24);
            this.label55.TabIndex = 58;
            this.label55.Text = "每";
            // 
            // Message_richTextBox
            // 
            this.Message_richTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.Message_richTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Message_richTextBox.Location = new System.Drawing.Point(0, 166);
            this.Message_richTextBox.Name = "Message_richTextBox";
            this.Message_richTextBox.Size = new System.Drawing.Size(1511, 102);
            this.Message_richTextBox.TabIndex = 59;
            this.Message_richTextBox.Text = "";
            // 
            // CPU_DataGridView
            // 
            this.CPU_DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CPU_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CPU_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CPU_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.dataGridViewTextBoxColumn1,
            this.Column4,
            this.Column5});
            this.CPU_DataGridView.Location = new System.Drawing.Point(668, 343);
            this.CPU_DataGridView.Name = "CPU_DataGridView";
            this.CPU_DataGridView.RowTemplate.Height = 27;
            this.CPU_DataGridView.Size = new System.Drawing.Size(843, 330);
            this.CPU_DataGridView.TabIndex = 61;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "項次";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "程式名稱";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "CPU效能";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "記憶體";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // TotalCPU_DataGridView
            // 
            this.TotalCPU_DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TotalCPU_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TotalCPU_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TotalCPU_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1});
            this.TotalCPU_DataGridView.Location = new System.Drawing.Point(6, 343);
            this.TotalCPU_DataGridView.Name = "TotalCPU_DataGridView";
            this.TotalCPU_DataGridView.RowTemplate.Height = 27;
            this.TotalCPU_DataGridView.Size = new System.Drawing.Size(662, 330);
            this.TotalCPU_DataGridView.TabIndex = 60;
            this.TotalCPU_DataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TotalCPU_DataGridView_CellContentDoubleClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "項次";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "CPU總效能";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolLabelNowTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 676);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1511, 35);
            this.statusStrip1.TabIndex = 62;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(283, 30);
            this.toolStripStatusLabel1.Text = "                                             ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(1141, 30);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.Text = "         ";
            // 
            // toolLabelNowTime
            // 
            this.toolLabelNowTime.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolLabelNowTime.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.toolLabelNowTime.Name = "toolLabelNowTime";
            this.toolLabelNowTime.Size = new System.Drawing.Size(67, 30);
            this.toolLabelNowTime.Text = "         ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.History_Button);
            this.panel2.Controls.Add(this.Start_Button);
            this.panel2.Controls.Add(this.Pause_Button);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 268);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1511, 69);
            this.panel2.TabIndex = 71;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "V2022版";
            this.notifyIcon1.BalloonTipTitle = "CPU效能監控";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "CPU效能監控";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            this.notifyIcon1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseMove);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開啟ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.離開ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 76);
            // 
            // 開啟ToolStripMenuItem
            // 
            this.開啟ToolStripMenuItem.Name = "開啟ToolStripMenuItem";
            this.開啟ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.開啟ToolStripMenuItem.Text = "開啟";
            this.開啟ToolStripMenuItem.Click += new System.EventHandler(this.開啟ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(168, 24);
            this.toolStripMenuItem1.Text = "開啟文件目錄";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 離開ToolStripMenuItem
            // 
            this.離開ToolStripMenuItem.Name = "離開ToolStripMenuItem";
            this.離開ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.離開ToolStripMenuItem.Text = "離開";
            this.離開ToolStripMenuItem.Click += new System.EventHandler(this.離開ToolStripMenuItem_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1511, 711);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.CPU_DataGridView);
            this.Controls.Add(this.TotalCPU_DataGridView);
            this.Controls.Add(this.Message_richTextBox);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Form";
            this.Text = "CPU效能監控長駐程式V20220307V1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Form_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_Form_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Main_Form_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPU_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalCPU_DataGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button History_Button;
        private System.Windows.Forms.Button Pause_Button;
        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox Message_richTextBox;
        private System.Windows.Forms.DataGridView CPU_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridView TotalCPU_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolLabelNowTime;
        private System.Windows.Forms.Button Modify_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProgramPerformance_TextBox;
        private System.Windows.Forms.Label lbRefreshTime;
        private System.Windows.Forms.Button SelectDirectory_Button;
        private System.Windows.Forms.TextBox DirectoryPath_TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LogTime_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Hour_RadioButton;
        private System.Windows.Forms.RadioButton Day_RadioButton;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.TextBox DeleteMinute_TextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DeleteHour_TextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DeleteDay_TextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ComputerPerformance_TextBox;
        private System.Windows.Forms.Label lb_InvMsg;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 開啟ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 離開ToolStripMenuItem;
    }
}

