using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
        public bool hash = false;

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && (long)numericUpDown1.Value == 0) { MessageBox.Show("//type your password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (textBox1.Text != "" && (long)numericUpDown1.Value != 0) { MessageBox.Show("//only one password can be entered at a time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (textBox1.Text != "") { hash = true; }
            else { hash = false; }
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

        static string sha256(string randomString)
        {
            var crypt = new SHA256Managed();
            string hash = String.Empty;
            byte[] crypto = crypt.ComputeHash(Encoding.ASCII.GetBytes(randomString));
            foreach (byte theByte in crypto)
            {
                hash += theByte.ToString("x2");
            }
            return hash;
        }

        private void calc()
        {
            long pswd = 0;
            long numb = (long)numericUpDown1.Value;
            for (i = 0; i < 9999999999999999; i++)
            {
                if (hash) 
                {
                    if (sha256(i.ToString()) == textBox1.Text) 
                    {
                        
                        pswd = i;
                        timerRunTime.Stop();
                        if (runTime < 1) { buttonStart.BackColor = Color.Red; }
                        else if (runTime < 2) { buttonStart.BackColor = Color.Orange; }
                        else if (runTime < 8) { buttonStart.BackColor = Color.Blue; }
                        else if (runTime > 10) { buttonStart.BackColor = Color.Green; }
                        MessageBox.Show("//we have found the password\nyour password: " + pswd + "\nruntime: " + runTime.ToString() + "s", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        runTime = 0;
                        return;
                    }
                }
                else
                {
                    if (i == numb)
                    {
                        pswd = i;
                        timerRunTime.Stop();
                        if (runTime < 1) { buttonStart.BackColor = Color.Red; }
                        else if (runTime < 2) { buttonStart.BackColor = Color.Orange; }
                        else if (runTime < 8) { buttonStart.BackColor = Color.Blue; }
                        else if (runTime > 10) { buttonStart.BackColor = Color.Green; }
                        MessageBox.Show("//we have found the password\nyour password: " + pswd + "\nruntime: " + runTime.ToString() + "s", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        runTime = 0;
                        return;
                    }
                }
            }
        }

        private void timerRunTime_Tick(object sender, EventArgs e)
        {
            runTime++;
            labelRunTime.Text = "run time: " + runTime.ToString() + "s";
            long numb = (long)numericUpDown1.Value;
            if(hash) { progressBar1.Value = (int)((100 * i) / Math.Exp(20)); }
            else { progressBar1.Value = (int)((100 * i) / numb); }
            
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
