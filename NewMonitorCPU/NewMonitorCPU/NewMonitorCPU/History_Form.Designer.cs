namespace NewMonitorCPU
{
    partial class History_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History_Form));
            this.LogImportS_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Start_Button = new System.Windows.Forms.Button();
            this.CPU_DataGridView = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCPU_DataGridView = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogImportE_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CPU_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalCPU_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LogImportS_DateTimePicker
            // 
            this.LogImportS_DateTimePicker.CustomFormat = "yyyyMMdd";
            this.LogImportS_DateTimePicker.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LogImportS_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.LogImportS_DateTimePicker.Location = new System.Drawing.Point(192, 24);
            this.LogImportS_DateTimePicker.Name = "LogImportS_DateTimePicker";
            this.LogImportS_DateTimePicker.Size = new System.Drawing.Size(142, 35);
            this.LogImportS_DateTimePicker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "匯入歷史日期";
            // 
            // Start_Button
            // 
            this.Start_Button.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Start_Button.Image = ((System.Drawing.Image)(resources.GetObject("Start_Button.Image")));
            this.Start_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Start_Button.Location = new System.Drawing.Point(549, 13);
            this.Start_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(117, 52);
            this.Start_Button.TabIndex = 36;
            this.Start_Button.Text = "匯入";
            this.Start_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Start_Button.UseVisualStyleBackColor = true;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
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
            this.CPU_DataGridView.Location = new System.Drawing.Point(761, 72);
            this.CPU_DataGridView.Name = "CPU_DataGridView";
            this.CPU_DataGridView.RowTemplate.Height = 27;
            this.CPU_DataGridView.Size = new System.Drawing.Size(781, 567);
            this.CPU_DataGridView.TabIndex = 38;
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
            this.TotalCPU_DataGridView.Location = new System.Drawing.Point(32, 72);
            this.TotalCPU_DataGridView.Name = "TotalCPU_DataGridView";
            this.TotalCPU_DataGridView.RowTemplate.Height = 27;
            this.TotalCPU_DataGridView.Size = new System.Drawing.Size(723, 567);
            this.TotalCPU_DataGridView.TabIndex = 37;
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
            // LogImportE_DateTimePicker
            // 
            this.LogImportE_DateTimePicker.CustomFormat = "yyyyMMdd";
            this.LogImportE_DateTimePicker.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LogImportE_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.LogImportE_DateTimePicker.Location = new System.Drawing.Point(390, 24);
            this.LogImportE_DateTimePicker.Name = "LogImportE_DateTimePicker";
            this.LogImportE_DateTimePicker.Size = new System.Drawing.Size(142, 35);
            this.LogImportE_DateTimePicker.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(345, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 24);
            this.label2.TabIndex = 40;
            this.label2.Text = "到";
            // 
            // History_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1554, 651);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LogImportE_DateTimePicker);
            this.Controls.Add(this.CPU_DataGridView);
            this.Controls.Add(this.TotalCPU_DataGridView);
            this.Controls.Add(this.Start_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogImportS_DateTimePicker);
            this.Name = "History_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "歷史查詢";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.History_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CPU_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalCPU_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker LogImportS_DateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.DataGridView CPU_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridView TotalCPU_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DateTimePicker LogImportE_DateTimePicker;
        private System.Windows.Forms.Label label2;
    }
}