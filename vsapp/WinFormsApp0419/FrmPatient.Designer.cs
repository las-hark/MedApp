namespace WinFormsApp0419
{
    partial class frmPatient
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
            this.components = new System.ComponentModel.Container();
            this.rbNeg = new System.Windows.Forms.RadioButton();
            this.rtbInformation = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbPos = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cobSex = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPatientInf = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.chkFever = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkAche = new System.Windows.Forms.CheckBox();
            this.chkCough = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cobDoctor = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbNeg
            // 
            this.rbNeg.AutoSize = true;
            this.rbNeg.Location = new System.Drawing.Point(24, 170);
            this.rbNeg.Name = "rbNeg";
            this.rbNeg.Size = new System.Drawing.Size(109, 28);
            this.rbNeg.TabIndex = 0;
            this.rbNeg.TabStop = true;
            this.rbNeg.Text = "negative";
            this.rbNeg.UseVisualStyleBackColor = true;
            this.rbNeg.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rtbInformation
            // 
            this.rtbInformation.Location = new System.Drawing.Point(565, 348);
            this.rtbInformation.Name = "rtbInformation";
            this.rtbInformation.Size = new System.Drawing.Size(437, 213);
            this.rtbInformation.TabIndex = 2;
            this.rtbInformation.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rbPos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cobSex);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.rbNeg);
            this.groupBox1.Location = new System.Drawing.Point(16, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 226);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "COVID19:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // rbPos
            // 
            this.rbPos.AutoSize = true;
            this.rbPos.Location = new System.Drawing.Point(157, 170);
            this.rbPos.Name = "rbPos";
            this.rbPos.Size = new System.Drawing.Size(102, 28);
            this.rbPos.TabIndex = 10;
            this.rbPos.TabStop = true;
            this.rbPos.Text = "positive";
            this.rbPos.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sex";
            // 
            // cobSex
            // 
            this.cobSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobSex.FormattingEnabled = true;
            this.cobSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cobSex.Location = new System.Drawing.Point(109, 94);
            this.cobSex.Name = "cobSex";
            this.cobSex.Size = new System.Drawing.Size(150, 32);
            this.cobSex.TabIndex = 1;
            this.cobSex.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(109, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 30);
            this.txtName.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 348);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(337, 213);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(329, 176);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(329, 176);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1024, 32);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpen,
            this.eXITToolStripMenuItem,
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(60, 28);
            this.menuFile.Text = "FILE";
            // 
            // menuOpen
            // 
            this.menuOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPatientInf});
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.Size = new System.Drawing.Size(161, 34);
            this.menuOpen.Text = "OPEN";
            this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
            // 
            // menuPatientInf
            // 
            this.menuPatientInf.Name = "menuPatientInf";
            this.menuPatientInf.Size = new System.Drawing.Size(291, 34);
            this.menuPatientInf.Text = "patient\'s information";
            this.menuPatientInf.Click += new System.EventHandler(this.patientsInformationToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(158, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(161, 34);
            this.menuExit.Text = "EXIT";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 601);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1024, 31);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // tssLabel
            // 
            this.tssLabel.Name = "tssLabel";
            this.tssLabel.Size = new System.Drawing.Size(195, 24);
            this.tssLabel.Text = "toolStripStatusLabel1";
            this.tssLabel.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // chkFever
            // 
            this.chkFever.AutoSize = true;
            this.chkFever.Location = new System.Drawing.Point(17, 82);
            this.chkFever.Name = "chkFever";
            this.chkFever.Size = new System.Drawing.Size(78, 28);
            this.chkFever.TabIndex = 7;
            this.chkFever.Text = "fever";
            this.chkFever.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkAche);
            this.groupBox2.Controls.Add(this.chkFever);
            this.groupBox2.Controls.Add(this.chkCough);
            this.groupBox2.Location = new System.Drawing.Point(372, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(131, 226);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Symptom";
            // 
            // chkAche
            // 
            this.chkAche.AutoSize = true;
            this.chkAche.Location = new System.Drawing.Point(17, 116);
            this.chkAche.Name = "chkAche";
            this.chkAche.Size = new System.Drawing.Size(76, 28);
            this.chkAche.TabIndex = 10;
            this.chkAche.Text = "ache";
            this.chkAche.UseVisualStyleBackColor = true;
            this.chkAche.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // chkCough
            // 
            this.chkCough.AutoSize = true;
            this.chkCough.Location = new System.Drawing.Point(17, 47);
            this.chkCough.Name = "chkCough";
            this.chkCough.Size = new System.Drawing.Size(90, 28);
            this.chkCough.TabIndex = 9;
            this.chkCough.Text = "cough";
            this.chkCough.UseVisualStyleBackColor = true;
            this.chkCough.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(890, 265);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 34);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cobDoctor);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtDepartment);
            this.groupBox3.Location = new System.Drawing.Point(565, 73);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 226);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Registration";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(127, 48);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(150, 30);
            this.txtDepartment.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Department";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Doctor";
            // 
            // cobDoctor
            // 
            this.cobDoctor.FormattingEnabled = true;
            this.cobDoctor.Location = new System.Drawing.Point(99, 94);
            this.cobDoctor.Name = "cobDoctor";
            this.cobDoctor.Size = new System.Drawing.Size(178, 32);
            this.cobDoctor.TabIndex = 6;
            // 
            // frmPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 632);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rtbInformation);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPatient";
            this.Text = "patient";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmPatient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton rbNeg;
        private RichTextBox rtbInformation;
        private GroupBox groupBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuFile;
        private ToolStripMenuItem menuOpen;
        private ToolStripSeparator eXITToolStripMenuItem;
        private ToolStripMenuItem menuExit;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem menuPatientInf;
        private CheckBox chkFever;
        private GroupBox groupBox2;
        private ComboBox cobSex;
        private TextBox txtName;
        private Label label2;
        private Label label1;
        private CheckBox chkCough;
        private RadioButton rbPos;
        private CheckBox chkAche;
        private ToolStripStatusLabel tssLabel;
        private System.Windows.Forms.Timer timer1;
        private Label label3;
        private Button btnOK;
        private GroupBox groupBox3;
        private ComboBox cobDoctor;
        private Label label5;
        private Label label4;
        private TextBox txtDepartment;
    }
}