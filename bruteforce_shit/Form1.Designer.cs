
namespace bruteforce_shit
{
    partial class Bruteforce
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bruteforce));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelYourPswd = new System.Windows.Forms.Label();
            this.labelMadeBy = new System.Windows.Forms.Label();
            this.labelRunTime = new System.Windows.Forms.Label();
            this.timerRunTime = new System.Windows.Forms.Timer(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelVysvetlivky = new System.Windows.Forms.Label();
            this.pictureBoxQuestionMark = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuestionMark)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progressBar1.Location = new System.Drawing.Point(117, 254);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(305, 11);
            this.progressBar1.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonStart.Font = new System.Drawing.Font("Ubuntu Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStart.ForeColor = System.Drawing.Color.White;
            this.buttonStart.Location = new System.Drawing.Point(207, 211);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(125, 37);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "BruteForce";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelYourPswd
            // 
            this.labelYourPswd.AutoSize = true;
            this.labelYourPswd.BackColor = System.Drawing.Color.Transparent;
            this.labelYourPswd.Font = new System.Drawing.Font("Ubuntu Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelYourPswd.ForeColor = System.Drawing.Color.White;
            this.labelYourPswd.Location = new System.Drawing.Point(27, 31);
            this.labelYourPswd.Name = "labelYourPswd";
            this.labelYourPswd.Size = new System.Drawing.Size(135, 20);
            this.labelYourPswd.TabIndex = 3;
            this.labelYourPswd.Text = "your password:";
            // 
            // labelMadeBy
            // 
            this.labelMadeBy.AutoSize = true;
            this.labelMadeBy.BackColor = System.Drawing.Color.Transparent;
            this.labelMadeBy.Font = new System.Drawing.Font("Ubuntu Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMadeBy.ForeColor = System.Drawing.Color.White;
            this.labelMadeBy.Location = new System.Drawing.Point(419, 9);
            this.labelMadeBy.Name = "labelMadeBy";
            this.labelMadeBy.Size = new System.Drawing.Size(109, 60);
            this.labelMadeBy.TabIndex = 4;
            this.labelMadeBy.Text = "//made by \r\n//kolackasimon\r\n//houzarlukas\r\n//kristofcakrobin";
            // 
            // labelRunTime
            // 
            this.labelRunTime.AutoSize = true;
            this.labelRunTime.BackColor = System.Drawing.Color.Transparent;
            this.labelRunTime.Font = new System.Drawing.Font("Ubuntu Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRunTime.ForeColor = System.Drawing.Color.White;
            this.labelRunTime.Location = new System.Drawing.Point(28, 140);
            this.labelRunTime.Name = "labelRunTime";
            this.labelRunTime.Size = new System.Drawing.Size(71, 16);
            this.labelRunTime.TabIndex = 5;
            this.labelRunTime.Text = "run time:";
            // 
            // timerRunTime
            // 
            this.timerRunTime.Interval = 1000;
            this.timerRunTime.Tick += new System.EventHandler(this.timerRunTime_Tick);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDown1.Font = new System.Drawing.Font("Ubuntu Mono", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.White;
            this.numericUpDown1.Location = new System.Drawing.Point(191, 30);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(161, 24);
            this.numericUpDown1.TabIndex = 6;
            // 
            // labelVysvetlivky
            // 
            this.labelVysvetlivky.AutoSize = true;
            this.labelVysvetlivky.BackColor = System.Drawing.Color.Transparent;
            this.labelVysvetlivky.Font = new System.Drawing.Font("Ubuntu Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVysvetlivky.ForeColor = System.Drawing.Color.White;
            this.labelVysvetlivky.Location = new System.Drawing.Point(419, 162);
            this.labelVysvetlivky.Name = "labelVysvetlivky";
            this.labelVysvetlivky.Size = new System.Drawing.Size(91, 60);
            this.labelVysvetlivky.TabIndex = 7;
            this.labelVysvetlivky.Text = "//red=superbad\r\n//orange=bad\r\n//blue=good\r\n//green=nice";
            // 
            // pictureBoxQuestionMark
            // 
            this.pictureBoxQuestionMark.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxQuestionMark.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxQuestionMark.Image")));
            this.pictureBoxQuestionMark.Location = new System.Drawing.Point(491, 225);
            this.pictureBoxQuestionMark.Name = "pictureBoxQuestionMark";
            this.pictureBoxQuestionMark.Size = new System.Drawing.Size(28, 34);
            this.pictureBoxQuestionMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxQuestionMark.TabIndex = 8;
            this.pictureBoxQuestionMark.TabStop = false;
            this.pictureBoxQuestionMark.MouseEnter += new System.EventHandler(this.pictureBoxQuestionMark_MouseEnter);
            this.pictureBoxQuestionMark.MouseLeave += new System.EventHandler(this.pictureBoxQuestionMark_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ubuntu Mono", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(492, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 40);
            this.label1.TabIndex = 9;
            this.label1.Text = ".";
            // 
            // Bruteforce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(540, 271);
            this.Controls.Add(this.pictureBoxQuestionMark);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelVysvetlivky);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.labelRunTime);
            this.Controls.Add(this.labelMadeBy);
            this.Controls.Add(this.labelYourPswd);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Bruteforce";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BruteForce | Application";
            this.Load += new System.EventHandler(this.Bruteforce_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuestionMark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelYourPswd;
        private System.Windows.Forms.Label labelMadeBy;
        private System.Windows.Forms.Label labelRunTime;
        private System.Windows.Forms.Timer timerRunTime;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelVysvetlivky;
        private System.Windows.Forms.PictureBox pictureBoxQuestionMark;
        private System.Windows.Forms.Label label1;
    }
}

