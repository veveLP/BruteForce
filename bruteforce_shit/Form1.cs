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

        public long i;
        public int runTime = 0;

        private void buttonStart_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Visible = true;
            timerRunTime.Start();
            labelRunTime.Text = "run time: " + runTime.ToString() + "s";
            long numb = (long)numericUpDown1.Value;
            String str = numericUpDown1.Value.ToString();
            if (str.Length > 16) { numericUpDown1.Value = 0; MessageBox.Show("//your password is too long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            Thread th = new Thread(new ThreadStart(calc));
            timerRunTime.Start();
            th.Start();
        }

        private void Bruteforce_Load(object sender, EventArgs e)
        {
            labelVysvetlivky.Visible = false;
            progressBar1.Visible = false;
            buttonStart.TabStop = false;
            buttonStart.FlatStyle = FlatStyle.Flat;
            buttonStart.FlatAppearance.BorderSize = 0;
        }
        
        private void calc()
        {
            long numb = (long)numericUpDown1.Value;
            for (i = 0; i < 9999999999999999; i++)
            {
                if (i == numb) 
                { 
                    timerRunTime.Stop();
                    if (runTime < 1) { buttonStart.BackColor = Color.Red; }
                    else if (runTime < 2) { buttonStart.BackColor = Color.Orange; }
                    else if (runTime < 8) { buttonStart.BackColor = Color.Blue; }
                    else if (runTime > 10) { buttonStart.BackColor = Color.Green; }
                    MessageBox.Show("//we have found the password\n runtime: " + runTime.ToString() + "s", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    runTime = 0;
                    return; 
                } 
            }
        }

        private void timerRunTime_Tick(object sender, EventArgs e)
        {
            runTime++;
            labelRunTime.Text = "run time: " + runTime.ToString() + "s";
            long numb = (long)numericUpDown1.Value;
            progressBar1.Value = (int)((100 * i) / numb);
            String remain = i.ToString();
            for (int i = remain.Length; i <= numb.ToString().Length; i++) { remain = "0" + remain; }
        }

        private void pictureBoxQuestionMark_MouseEnter(object sender, EventArgs e)
        {
            labelVysvetlivky.Visible = true;
        }
        private void pictureBoxQuestionMark_MouseLeave(object sender, EventArgs e)
        {
            labelVysvetlivky.Visible = false;
        }
    }
}

    /*int var = Int32.Parse(remain[0].ToString() + remain[1].ToString() + remain[2].ToString() + remain[3].ToString());
                progressBar1.Value = (int)var;*/
    //label3.Text = ((int)(i % 1000)).ToString();
    //label1.Text = (done / 1000000).ToString();