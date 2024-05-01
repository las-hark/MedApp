namespace ECGtext
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picECG = new System.Windows.Forms.PictureBox();
            this.gbParameter = new System.Windows.Forms.GroupBox();
            this.cbZengyi = new System.Windows.Forms.ComboBox();
            this.cbAmp = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbBgGreen = new System.Windows.Forms.RadioButton();
            this.rbBgRed = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbECGRed = new System.Windows.Forms.RadioButton();
            this.rbECGGreen = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbButton = new System.Windows.Forms.GroupBox();
            this.butExit = new System.Windows.Forms.Button();
            this.butFilter = new System.Windows.Forms.Button();
            this.butRefresh = new System.Windows.Forms.Button();
            this.butOpen = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssFilename = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picECG)).BeginInit();
            this.gbParameter.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbButton.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picECG
            // 
            this.picECG.Location = new System.Drawing.Point(12, 12);
            this.picECG.Name = "picECG";
            this.picECG.Size = new System.Drawing.Size(1299, 1170);
            this.picECG.TabIndex = 0;
            this.picECG.TabStop = false;
            this.picECG.Click += new System.EventHandler(this.picECG_Click);
            // 
            // gbParameter
            // 
            this.gbParameter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbParameter.Controls.Add(this.cbZengyi);
            this.gbParameter.Controls.Add(this.cbAmp);
            this.gbParameter.Controls.Add(this.panel2);
            this.gbParameter.Controls.Add(this.label4);
            this.gbParameter.Controls.Add(this.panel1);
            this.gbParameter.Controls.Add(this.label3);
            this.gbParameter.Controls.Add(this.label2);
            this.gbParameter.Controls.Add(this.label1);
            this.gbParameter.Location = new System.Drawing.Point(1317, 12);
            this.gbParameter.Name = "gbParameter";
            this.gbParameter.Size = new System.Drawing.Size(330, 399);
            this.gbParameter.TabIndex = 1;
            this.gbParameter.TabStop = false;
            this.gbParameter.Text = "参数设置";
            this.gbParameter.Enter += new System.EventHandler(this.gbParameter_Enter);
            // 
            // cbZengyi
            // 
            this.cbZengyi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbZengyi.FormattingEnabled = true;
            this.cbZengyi.Items.AddRange(new object[] {
            "25mm/s",
            "10mm/s",
            "50mm/s"});
            this.cbZengyi.Location = new System.Drawing.Point(110, 80);
            this.cbZengyi.Name = "cbZengyi";
            this.cbZengyi.Size = new System.Drawing.Size(182, 32);
            this.cbZengyi.TabIndex = 8;
            this.cbZengyi.SelectedIndexChanged += new System.EventHandler(this.cbZengyi_SelectedIndexChanged);
            // 
            // cbAmp
            // 
            this.cbAmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAmp.FormattingEnabled = true;
            this.cbAmp.Items.AddRange(new object[] {
            "5mV",
            "10mV"});
            this.cbAmp.Location = new System.Drawing.Point(110, 38);
            this.cbAmp.Name = "cbAmp";
            this.cbAmp.Size = new System.Drawing.Size(182, 32);
            this.cbAmp.TabIndex = 4;
            this.cbAmp.SelectedIndexChanged += new System.EventHandler(this.cbAmp_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbBgGreen);
            this.panel2.Controls.Add(this.rbBgRed);
            this.panel2.Location = new System.Drawing.Point(112, 254);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 100);
            this.panel2.TabIndex = 7;
            // 
            // rbBgGreen
            // 
            this.rbBgGreen.AutoSize = true;
            this.rbBgGreen.ForeColor = System.Drawing.Color.Green;
            this.rbBgGreen.Location = new System.Drawing.Point(12, 53);
            this.rbBgGreen.Name = "rbBgGreen";
            this.rbBgGreen.Size = new System.Drawing.Size(71, 28);
            this.rbBgGreen.TabIndex = 1;
            this.rbBgGreen.TabStop = true;
            this.rbBgGreen.Text = "绿色";
            this.rbBgGreen.UseVisualStyleBackColor = true;
            this.rbBgGreen.CheckedChanged += new System.EventHandler(this.rbBgGreen_CheckedChanged_1);
            // 
            // rbBgRed
            // 
            this.rbBgRed.AutoSize = true;
            this.rbBgRed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbBgRed.Location = new System.Drawing.Point(12, 19);
            this.rbBgRed.Name = "rbBgRed";
            this.rbBgRed.Size = new System.Drawing.Size(71, 28);
            this.rbBgRed.TabIndex = 0;
            this.rbBgRed.TabStop = true;
            this.rbBgRed.Text = "红色";
            this.rbBgRed.UseVisualStyleBackColor = true;
            this.rbBgRed.CheckedChanged += new System.EventHandler(this.rbBgGreen_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "背景颜色";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbECGRed);
            this.panel1.Controls.Add(this.rbECGGreen);
            this.panel1.Location = new System.Drawing.Point(110, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 97);
            this.panel1.TabIndex = 3;
            // 
            // rbECGRed
            // 
            this.rbECGRed.AutoSize = true;
            this.rbECGRed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbECGRed.Location = new System.Drawing.Point(14, 50);
            this.rbECGRed.Name = "rbECGRed";
            this.rbECGRed.Size = new System.Drawing.Size(71, 28);
            this.rbECGRed.TabIndex = 1;
            this.rbECGRed.TabStop = true;
            this.rbECGRed.Text = "红色";
            this.rbECGRed.UseVisualStyleBackColor = true;
            this.rbECGRed.CheckedChanged += new System.EventHandler(this.rbECGRed_CheckedChanged_1);
            // 
            // rbECGGreen
            // 
            this.rbECGGreen.AutoSize = true;
            this.rbECGGreen.ForeColor = System.Drawing.Color.Green;
            this.rbECGGreen.Location = new System.Drawing.Point(14, 16);
            this.rbECGGreen.Name = "rbECGGreen";
            this.rbECGGreen.Size = new System.Drawing.Size(71, 28);
            this.rbECGGreen.TabIndex = 0;
            this.rbECGGreen.TabStop = true;
            this.rbECGGreen.Text = "绿色";
            this.rbECGGreen.UseVisualStyleBackColor = true;
            this.rbECGGreen.CheckedChanged += new System.EventHandler(this.rbECGRed_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "信号颜色";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "增益";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "幅度";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gbButton
            // 
            this.gbButton.BackColor = System.Drawing.SystemColors.Menu;
            this.gbButton.Controls.Add(this.butExit);
            this.gbButton.Controls.Add(this.butFilter);
            this.gbButton.Controls.Add(this.butRefresh);
            this.gbButton.Controls.Add(this.butOpen);
            this.gbButton.Location = new System.Drawing.Point(1317, 417);
            this.gbButton.Name = "gbButton";
            this.gbButton.Size = new System.Drawing.Size(330, 211);
            this.gbButton.TabIndex = 2;
            this.gbButton.TabStop = false;
            this.gbButton.Text = "功能";
            this.gbButton.Enter += new System.EventHandler(this.gbButton_Enter);
            // 
            // butExit
            // 
            this.butExit.Location = new System.Drawing.Point(189, 113);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(112, 34);
            this.butExit.TabIndex = 3;
            this.butExit.Text = "退出";
            this.butExit.UseVisualStyleBackColor = true;
            // 
            // butFilter
            // 
            this.butFilter.Location = new System.Drawing.Point(22, 113);
            this.butFilter.Name = "butFilter";
            this.butFilter.Size = new System.Drawing.Size(112, 34);
            this.butFilter.TabIndex = 2;
            this.butFilter.Text = "滤波";
            this.butFilter.UseVisualStyleBackColor = true;
            this.butFilter.Click += new System.EventHandler(this.butFilter_Click);
            // 
            // butRefresh
            // 
            this.butRefresh.Location = new System.Drawing.Point(189, 53);
            this.butRefresh.Name = "butRefresh";
            this.butRefresh.Size = new System.Drawing.Size(112, 34);
            this.butRefresh.TabIndex = 1;
            this.butRefresh.Text = "刷新";
            this.butRefresh.UseVisualStyleBackColor = true;
            this.butRefresh.Click += new System.EventHandler(this.butRefresh_Click);
            // 
            // butOpen
            // 
            this.butOpen.Location = new System.Drawing.Point(22, 53);
            this.butOpen.Name = "butOpen";
            this.butOpen.Size = new System.Drawing.Size(112, 34);
            this.butOpen.TabIndex = 0;
            this.butOpen.Text = "打开";
            this.butOpen.UseVisualStyleBackColor = true;
            this.butOpen.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssFilename,
            this.toolStripStatusLabel2,
            this.tssDate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1185);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1661, 31);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssFilename
            // 
            this.tssFilename.Name = "tssFilename";
            this.tssFilename.Size = new System.Drawing.Size(84, 24);
            this.tssFilename.Text = "filename";
            this.tssFilename.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 24);
            // 
            // tssDate
            // 
            this.tssDate.Name = "tssDate";
            this.tssDate.Size = new System.Drawing.Size(51, 24);
            this.tssDate.Text = "Date";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "ECGfilename";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1661, 1216);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gbButton);
            this.Controls.Add(this.gbParameter);
            this.Controls.Add(this.picECG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Mainform";
            this.Load += new System.EventHandler(this.Mainform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picECG)).EndInit();
            this.gbParameter.ResumeLayout(false);
            this.gbParameter.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbButton.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picECG;
        private GroupBox gbParameter;
        private Panel panel2;
        private Label label4;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox gbButton;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tssFilename;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel tssDate;
        private RadioButton rbBgGreen;
        private RadioButton rbBgRed;
        private RadioButton rbECGRed;
        private RadioButton rbECGGreen;
        private Button butExit;
        private Button butFilter;
        private Button butRefresh;
        private Button butOpen;
        private ComboBox cbZengyi;
        private ComboBox cbAmp;
        private OpenFileDialog openFileDialog;
    }
}