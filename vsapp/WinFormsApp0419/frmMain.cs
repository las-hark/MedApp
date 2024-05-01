namespace WinFormsApp0419
{

    public partial class FromMain : Form
    {
        int intFlg = 0;
        public FromMain()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FromMain_Load(object sender, EventArgs e)
        {

        }

        private void btnIn_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUser.Text == "Jean")
            {
                if (txtPassword.Text == "12345")
                {
                    frmPatient frmPj = new frmPatient();
                    MessageBox.Show("Log in successfully!");
                    frmPj.Show();
       
                }
                else 
                { 
                    intFlg++;
                    MessageBox.Show("ERROR!Please try again!");
                }
            }
            if (intFlg > 2)
            {
                MessageBox.Show("ERROR!Please conect with the administrators!");
                Application.Exit();
            }
        }
    }
}