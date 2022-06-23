
namespace TimeStackerForms
{
    partial class TimeStackerUI
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeStackerUI));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_timeLock = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pBar_weeklyProgressBar = new System.Windows.Forms.ProgressBar();
            this.tBar_stundenHeute = new System.Windows.Forms.TrackBar();
            this.lbl_counter = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_allTime = new System.Windows.Forms.Label();
            this.lbl_weeklyEvaluation = new System.Windows.Forms.Label();
            this.lbl_stackHistory = new System.Windows.Forms.Label();
            this.lbl_restTageBisEvent = new System.Windows.Forms.Label();
            this.lbl_bonusHours = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBar_stundenHeute)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Der Timestacker";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::TimeStackerForms.Properties.Resources.mAurelZitat_1;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(544, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 246);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_timeLock
            // 
            this.btn_timeLock.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timeLock.Location = new System.Drawing.Point(74, 171);
            this.btn_timeLock.Name = "btn_timeLock";
            this.btn_timeLock.Size = new System.Drawing.Size(112, 35);
            this.btn_timeLock.TabIndex = 2;
            this.btn_timeLock.Text = "Stacken";
            this.btn_timeLock.UseVisualStyleBackColor = true;
            this.btn_timeLock.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Menu;
            this.label2.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wie lange hast du heute programmiert?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pBar_weeklyProgressBar
            // 
            this.pBar_weeklyProgressBar.Location = new System.Drawing.Point(41, 544);
            this.pBar_weeklyProgressBar.Name = "pBar_weeklyProgressBar";
            this.pBar_weeklyProgressBar.Size = new System.Drawing.Size(837, 42);
            this.pBar_weeklyProgressBar.TabIndex = 4;
            this.pBar_weeklyProgressBar.Click += new System.EventHandler(this.pBar_weeklyProgressBar_Click);
            // 
            // tBar_stundenHeute
            // 
            this.tBar_stundenHeute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tBar_stundenHeute.Location = new System.Drawing.Point(74, 120);
            this.tBar_stundenHeute.Maximum = 8;
            this.tBar_stundenHeute.Name = "tBar_stundenHeute";
            this.tBar_stundenHeute.Size = new System.Drawing.Size(358, 45);
            this.tBar_stundenHeute.TabIndex = 5;
            this.tBar_stundenHeute.Value = 1;
            this.tBar_stundenHeute.Scroll += new System.EventHandler(this.stundenHeuteBar_Scroll);
            this.tBar_stundenHeute.ValueChanged += new System.EventHandler(this.tBar_stundenHeute_ValueChanged);
            // 
            // lbl_counter
            // 
            this.lbl_counter.AutoSize = true;
            this.lbl_counter.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_counter.Location = new System.Drawing.Point(333, 176);
            this.lbl_counter.Name = "lbl_counter";
            this.lbl_counter.Size = new System.Drawing.Size(95, 30);
            this.lbl_counter.TabIndex = 6;
            this.lbl_counter.Text = "Stunden";
            this.lbl_counter.Click += new System.EventHandler(this.lbl_counter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 516);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Wochenziel";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_allTime
            // 
            this.lbl_allTime.AutoSize = true;
            this.lbl_allTime.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_allTime.Location = new System.Drawing.Point(540, 320);
            this.lbl_allTime.Name = "lbl_allTime";
            this.lbl_allTime.Size = new System.Drawing.Size(123, 21);
            this.lbl_allTime.TabIndex = 8;
            this.lbl_allTime.Text = "Stunden Alltime";
            this.lbl_allTime.Click += new System.EventHandler(this.lbl_allTime_Click);
            // 
            // lbl_weeklyEvaluation
            // 
            this.lbl_weeklyEvaluation.AutoSize = true;
            this.lbl_weeklyEvaluation.Location = new System.Drawing.Point(142, 522);
            this.lbl_weeklyEvaluation.Name = "lbl_weeklyEvaluation";
            this.lbl_weeklyEvaluation.Size = new System.Drawing.Size(63, 13);
            this.lbl_weeklyEvaluation.TabIndex = 9;
            this.lbl_weeklyEvaluation.Text = "Evaluierung";
            // 
            // lbl_stackHistory
            // 
            this.lbl_stackHistory.AutoSize = true;
            this.lbl_stackHistory.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stackHistory.Location = new System.Drawing.Point(70, 320);
            this.lbl_stackHistory.Name = "lbl_stackHistory";
            this.lbl_stackHistory.Size = new System.Drawing.Size(108, 21);
            this.lbl_stackHistory.TabIndex = 10;
            this.lbl_stackHistory.Text = "Stack History";
            // 
            // lbl_restTageBisEvent
            // 
            this.lbl_restTageBisEvent.AutoSize = true;
            this.lbl_restTageBisEvent.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_restTageBisEvent.Location = new System.Drawing.Point(540, 361);
            this.lbl_restTageBisEvent.Name = "lbl_restTageBisEvent";
            this.lbl_restTageBisEvent.Size = new System.Drawing.Size(141, 21);
            this.lbl_restTageBisEvent.TabIndex = 11;
            this.lbl_restTageBisEvent.Text = "restTage bis Event";
            // 
            // lbl_bonusHours
            // 
            this.lbl_bonusHours.AutoSize = true;
            this.lbl_bonusHours.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bonusHours.Location = new System.Drawing.Point(540, 402);
            this.lbl_bonusHours.Name = "lbl_bonusHours";
            this.lbl_bonusHours.Size = new System.Drawing.Size(109, 21);
            this.lbl_bonusHours.TabIndex = 12;
            this.lbl_bonusHours.Text = "Bonusstunden";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(923, 636);
            this.Controls.Add(this.lbl_bonusHours);
            this.Controls.Add(this.lbl_restTageBisEvent);
            this.Controls.Add(this.lbl_stackHistory);
            this.Controls.Add(this.lbl_weeklyEvaluation);
            this.Controls.Add(this.lbl_allTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_counter);
            this.Controls.Add(this.tBar_stundenHeute);
            this.Controls.Add(this.pBar_weeklyProgressBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_timeLock);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBar_stundenHeute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_timeLock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar pBar_weeklyProgressBar;
        private System.Windows.Forms.TrackBar tBar_stundenHeute;
        private System.Windows.Forms.Label lbl_counter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_allTime;
        private System.Windows.Forms.Label lbl_weeklyEvaluation;
        private System.Windows.Forms.Label lbl_stackHistory;
        private System.Windows.Forms.Label lbl_restTageBisEvent;
        private System.Windows.Forms.Label lbl_bonusHours;
    }
}

