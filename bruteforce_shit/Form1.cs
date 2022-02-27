using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bruteforce_shit
{
    public partial class Bruteforce : Form
    {
        public Bruteforce()
        {
            InitializeComponent();
        }

        int estimatedTime = 0;

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //nevim jak ale 
            //pokud je heslo hodně slabý <0-25%>- buttonStart.BackColor = Color.Red;
            //slabý <26-50>- buttonStart.BackColor = Color.Orange;
            //slabý <51-75>- buttonStart.BackColor = Color.Blue;
            //najs <75-100>- buttonStart.BackColor = Color.Green;
            progressBar1.Visible = true;
            MessageBox.Show("//we have found the password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
  
            timerEstimatedTime = new Timer();//ESTIMATED TIME
            timerEstimatedTime.Tick += new EventHandler(timerEstimatedTime_Tick);
            timerEstimatedTime.Interval = 1000; // 1 s
            timerEstimatedTime.Start();
            labelEstimatedTime.Text = "estimated time: " + estimatedTime.ToString();
        }

        private void Bruteforce_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
            buttonStart.TabStop = false;
            buttonStart.FlatStyle = FlatStyle.Flat;
            buttonStart.FlatAppearance.BorderSize = 0;
        }

        private void timerEstimatedTime_Tick(object sender, EventArgs e)
        {
            estimatedTime++;
            if (estimatedTime==10) { timerEstimatedTime.Stop(); } //NASTAVIT KONEC TIMERU!!!
            labelEstimatedTime.Text = "estimated time: "+estimatedTime.ToString();
        }
    }
}
