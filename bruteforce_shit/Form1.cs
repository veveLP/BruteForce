using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            
  
            
            timerEstimatedTime.Start();
            labelEstimatedTime.Text = "estimated time: " + estimatedTime.ToString();
            long numb = (long)numericUpDown1.Value;
            String str = numericUpDown1.Value.ToString();
            if (str.Length > 16) { numericUpDown1.Value = 0; MessageBox.Show("Zadané heslo je příliš dlouhé!"); return; }
            Thread th = new Thread(new ThreadStart(calc));
            timerEstimatedTime.Start();
            th.Start();

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
            if (estimatedTime==100) { timerEstimatedTime.Stop(); } //NASTAVIT KONEC TIMERU!!!
            labelEstimatedTime.Text = "estimated time: "+estimatedTime.ToString();
            long numb = (long)numericUpDown1.Value;
            progressBar1.Value = (int)((100 * i) / numb);
            String remain = i.ToString();
            for (int i = remain.Length; i <= numb.ToString().Length; i++) { remain = "0" + remain; }
            /*int var = Int32.Parse(remain[0].ToString() + remain[1].ToString() + remain[2].ToString() + remain[3].ToString());
            progressBar1.Value = (int)var;*/
            //label3.Text = ((int)(i % 1000)).ToString();
            //label1.Text = (done / 1000000).ToString();

           
        }

        public long i;
        private void calc()
        {
            long numb = (long)numericUpDown1.Value;

            for (i = 0; i < 9999999999999999; i++)
            {

                if (i == numb) { MessageBox.Show("//we have found the password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); timerEstimatedTime.Stop(); return; }
                

            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
