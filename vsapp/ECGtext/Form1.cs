namespace ECGtext
{
    public partial class frmMain : Form
    {
        public class ECGDataGDI : Object
        {
            public int intNumPerLead = 2248;//每个导联数据数目
            public int intRealNumPerLead = 2880;//每个导联数据实际数目
            public int intDataOffset=61;
            public int intDataLen;
            public Int16[] intECGData = null;
            public int intBackDrawStep = 6; 
            public Graphics ECGBackGDI;
            public Graphics ECGGDI;
            public Color BackColor;
            public Color BackColor1;
            public Color ECGColor;
            private int m_intGDIWidth;
            public double douXTrans;//x方向转换系数25*6/250
            public double douYTrans;//y方向转换系数0.00195*10*69
            public int intGDIWidth
          {
              get{ return intGDIWidth; }
              set{ m_intGDIWidth=value; }
           }
            private int m_intGDIHeight;
            public int intGDIHeight
            {
               get{ return intGDIHeight; }
               set{ m_intGDIHeight = value; }
            }
            public int m_intCatchFeq=250;
            public int intCatchFeq//采样频率
            {
                get { return m_intCatchFeq; }
                set { m_intCatchFeq = value; }
            }
            public double m_douAmpT = 0.00195;
            public double douAmpT//采样频率
            {
                get { return m_douAmpT; }
                set { m_douAmpT = value; }
            }
            public void Filter()//信号滤波方法
            {

                for (int k = 0; k < 12; k++)
                {
                    int[] tmpECGData = new int[intNumPerLead];

                    for (int i = 2; i <= intNumPerLead - 2; i++)
                    {
                        tmpECGData[i] = intECGData[k * intRealNumPerLead + i];
                    }
                    for (int i = 2; i < intNumPerLead - 2; i++)
                    {
                        intECGData[k * intRealNumPerLead + i] = (Int16)((tmpECGData[i - 2] + tmpECGData[i - 1] + tmpECGData[i] + tmpECGData[i + 1] + tmpECGData[i + 2]) / 5);
                    }
                }
            }
                public void DrawECGBack()
            {
                // BackColor = Color.FromArgb(75, 255, 0, 0);
                Pen p = new Pen(BackColor,1);
                // Color BackColor1 = Color.FromArgb(150, 255, 0, 0);//linecolor r150b0g0 gray150
                Pen p1 = new Pen(BackColor1, 2);
                int intCol, intRol;
                ECGBackGDI.Clear(Color.Black);
                intCol = (int)m_intGDIWidth / intBackDrawStep;
                intRol = (int)m_intGDIHeight /intBackDrawStep;
                for(int i = 0; i < intRol; i++)
                {
                    int bx, by, ex, ey;
                    bx = 0; by = i * intBackDrawStep; ex = m_intGDIWidth; ey = by;
                    if (i % 5 != 0)
                    { ECGBackGDI.DrawLine(p, bx, by, ex, ey); }
                    else
                    { ECGBackGDI.DrawLine(p1, bx, by, ex, ey); }
                }
                for (int i = 0; i < intCol; i++)
                {
                    int bx, by, ex, ey;
                    bx = i * intBackDrawStep; by = 0; ex = bx; ey = m_intGDIHeight;
                    if (i % 5 != 0)
                    { ECGBackGDI.DrawLine(p, bx, by, ex, ey); }
                    else
                    { ECGBackGDI.DrawLine(p1, bx, by, ex, ey); }
                }
            }
            public void DrawECG()
            {
                int intDrawBase;
                //ECGColor = Color.FromArgb(200, 0, 255, 0);
                Pen p = new Pen(ECGColor, 1);
                intDrawBase = m_intGDIHeight / 24;
                for(int k=0;k<12;k++)
                {
                    int bx, by, ex, ey;
                    bx = 0; by = (2 * k + 1) *intDrawBase;
                    ex = (int)(0.05 * m_intCatchFeq * douXTrans); ey = (2 * k + 1) * intDrawBase;

                    ECGGDI.DrawLine(p, bx, by, ex, ey);//00-10
                    bx = ex; by = ey;
                    ex = bx; ey = (2 * k + 1) * intDrawBase - (int)(douYTrans); 

                    ECGGDI.DrawLine(p, bx, by, ex, ey);//10-11
                    bx = ex; by = ey;
                    ex = ex + (int)(0.05 * m_intCatchFeq * douXTrans); ey = by;

                    ECGGDI.DrawLine(p, bx, by, ex, ey);//11-21
                    bx = ex; by = ey;
                    ex = bx; ey = (2 * k + 1) * intDrawBase;

                    ECGGDI.DrawLine(p, bx, by, ex, ey);//21-20
                    int intStartX = ex;int intStartY = ey;
                    for (int i=0;i<=intNumPerLead;i++)
                    {
                        bx = ex;by = ey;
                        ex = (int)(intStartX+(i + 1) * douXTrans);
                        ey = (int)(intStartY - (intECGData[ i + k * intRealNumPerLead] * m_douAmpT * douYTrans));
                        ECGGDI.DrawLine(p,bx, by, ex, ey);
// 
                    } 
                }
                
            }

        }

        public ECGDataGDI ECGDataG = new ECGDataGDI();
        public frmMain()
        {
            InitializeComponent();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            tssDate.Text = DateTime.Now.ToString("当前日期为："+"yyyy-MM-dd");
            cbAmp.SelectedIndex = 0;
            cbZengyi.SelectedIndex = 0;
            rbBgRed.Checked = true;
            rbECGGreen.Checked = true;
            openFileDialog.Title = "打开心电图文件";
            openFileDialog.Filter = "心电图数据文件|*.ECG|所有文件|*.*";
            cbAmp.SelectedIndex = 0;
            cbZengyi.SelectedIndex=0;
            ECGDataG.douXTrans = 25 * (double)(ECGDataG.intBackDrawStep) / ECGDataG.intCatchFeq;
            ECGDataG.douYTrans = 10 * (double)(ECGDataG.intBackDrawStep);

            
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gbParameter_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileStream ECGF=File.OpenRead(openFileDialog.FileName);
                    tssFilename.Text = openFileDialog.FileName;
                    long lngDataSize;
                    lngDataSize = ECGF.Length;
                    byte[] tmpbyteBuff = new byte[lngDataSize];
                    ECGF.Read(tmpbyteBuff, 0, (int)lngDataSize);
                    ECGDataG.intECGData = new Int16[lngDataSize >> 1];
                    byte[] tmpb = new byte[2];
                    for (int i=0;i<(lngDataSize>>1)-61;i++)
                    {
                        tmpb[0]=tmpbyteBuff[i*2+ECGDataG.intDataOffset];
                        tmpb[1]=tmpbyteBuff[i*2+1 + ECGDataG.intDataOffset];
                        ECGDataG.intECGData[i] = BitConverter.ToInt16(tmpb, 0);
                    };
                };
            }
            catch (Exception EX)
            {
                MessageBox.Show("程序产生错误，错误类型为" + EX.Message);
            }

        }

        private void picECG_Click(object sender, EventArgs e)
        {

        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            ECGDataG.ECGBackGDI = picECG.CreateGraphics();
            ECGDataG.intGDIWidth = picECG.Width;
            ECGDataG.intGDIHeight = picECG.Height;
            ECGDataG.DrawECGBack();
            ECGDataG.ECGGDI=picECG.CreateGraphics();
            ECGDataG.DrawECG();
            

        }

        private void gbButton_Enter(object sender, EventArgs e)
        {

        }

        private void rbECGRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rbECGGreen.Checked == true)
            {
                ECGDataG.ECGColor = Color.FromArgb(200, 0, 255, 0);
            }
            
        }
        private void rbECGRed_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbECGRed.Checked == true)
            {
                ECGDataG.ECGColor = Color.FromArgb(200,255,0,0);
            }
        }

        private void cbAmp_SelectedIndexChanged(object sender, EventArgs e)
        { 
            //改变幅度增益
            if (cbAmp.SelectedIndex == 0)
            {
                   ECGDataG.douYTrans = 5 * (double)(ECGDataG.intBackDrawStep);
            }
            if (cbAmp.SelectedIndex == 1)
            {
                ECGDataG.douYTrans = 10 * (double)(ECGDataG.intBackDrawStep);
            }

        }

        private void cbZengyi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //改变时间增益
            if (cbZengyi.SelectedIndex == 0)
            {
                ECGDataG.douXTrans = 25 * (double)(ECGDataG.intBackDrawStep) / ECGDataG.intCatchFeq;
            }
            if (cbZengyi.SelectedIndex == 1)
            {
                ECGDataG.douXTrans = 10 * (double)(ECGDataG.intBackDrawStep) / ECGDataG.intCatchFeq;
            }
            if (cbZengyi.SelectedIndex == 2)
            {
                ECGDataG.douXTrans = 50 * (double)(ECGDataG.intBackDrawStep) / ECGDataG.intCatchFeq;
            }

        }

        private void rbBgGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBgRed.Checked == true)
            {
                ECGDataG.BackColor = Color.FromArgb(75, 255, 0,0);
                ECGDataG.BackColor1=Color.FromArgb(120, 255, 0, 0);
            }
        }

        private void rbBgGreen_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbBgGreen.Checked == true)
            {
                ECGDataG.BackColor = Color.FromArgb(75, 0, 255, 0);
                ECGDataG.BackColor1 = Color.FromArgb(120, 0, 255, 0);
            }
        }

        private void butFilter_Click(object sender, EventArgs e)
        {

            ECGDataG.Filter();

        }
    }
}