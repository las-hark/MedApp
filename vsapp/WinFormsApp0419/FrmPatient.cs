using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp0419
{
    public partial class frmPatient : Form
    {
        public frmPatient()
        {
            InitializeComponent();
        }

        private void FrmPatient_Load(object sender, EventArgs e)
        {
            tssLabel.Text = "now:"+DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            timer1.Enabled= true;
            
        }

        private void menuOpen_Click(object sender, EventArgs e)
        {
            
        }

        private void patientsInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tssLabel.Text = "now:" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyPatient myPatient = new MyPatient();
            //姓名
            myPatient.strName = txtName.Text;
            //性别
            if (cobSex.SelectedIndex == 0)
            {
                myPatient.strGender = "male";
            }
            else if (cobSex.SelectedIndex == 1)
            {
                myPatient.strGender = "female";
            }
            else
            {
                myPatient.strGender = "male";
            }
            //症状
            myPatient.boolCough = chkCough.Checked;
            myPatient.boolAche = chkAche.Checked;
            myPatient.boolFever = chkFever.Checked;
            //核酸
            myPatient.boolNegative = rbNeg.Checked;
            myPatient.boolPositive = rbPos.Checked;
            rtbInformation.Text = myPatient.strName+','+myPatient.strGender+',';
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        public class MyPatient : Object
        {
            public string strName;
            public string strGender;
            public bool boolFever;
            public bool boolAche;
            public bool boolCough;
            public bool boolNegative;
            public bool boolPositive;
        }
    }
}
