
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
            this.textBoxVstup = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelYourPswd = new System.Windows.Forms.Label();
            this.labelMadeBy = new System.Windows.Forms.Label();
            this.labelEstimatedTime = new System.Windows.Forms.Label();
            this.timerEstimatedTime = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progressBar1.Location = new System.Drawing.Point(108, 254);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(327, 10);
            this.progressBar1.TabIndex = 0;
            // 
            // textBoxVstup
            // 
            this.textBoxVstup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxVstup.Font = new System.Drawing.Font("Ubuntu Mono", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxVstup.ForeColor = System.Drawing.Color.White;
            this.textBoxVstup.Location = new System.Drawing.Point(192, 31);
            this.textBoxVstup.Name = "textBoxVstup";
            this.textBoxVstup.Size = new System.Drawing.Size(161, 24);
            this.textBoxVstup.TabIndex = 1;
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
            // labelEstimatedTime
            // 
            this.labelEstimatedTime.AutoSize = true;
            this.labelEstimatedTime.BackColor = System.Drawing.Color.Transparent;
            this.labelEstimatedTime.Font = new System.Drawing.Font("Ubuntu Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEstimatedTime.ForeColor = System.Drawing.Color.White;
            this.labelEstimatedTime.Location = new System.Drawing.Point(28, 143);
            this.labelEstimatedTime.Name = "labelEstimatedTime";
            this.labelEstimatedTime.Size = new System.Drawing.Size(113, 16);
            this.labelEstimatedTime.TabIndex = 5;
            this.labelEstimatedTime.Text = "estimated time:";
            // 
            // timerEstimatedTime
            // 
            this.timerEstimatedTime.Tick += new System.EventHandler(this.timerEstimatedTime_Tick);
            // 
            // Bruteforce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(540, 271);
            this.Controls.Add(this.labelEstimatedTime);
            this.Controls.Add(this.labelMadeBy);
            this.Controls.Add(this.labelYourPswd);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxVstup);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Bruteforce";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BruteForce | Application";
            this.Load += new System.EventHandler(this.Bruteforce_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBoxVstup;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelYourPswd;
        private System.Windows.Forms.Label labelMadeBy;
        private System.Windows.Forms.Label labelEstimatedTime;
        private System.Windows.Forms.Timer timerEstimatedTime;
    }
}

