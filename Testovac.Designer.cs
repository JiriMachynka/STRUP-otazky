namespace STRUP_Otázky
{
    partial class Testovac
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
            this.lblQ = new System.Windows.Forms.Label();
            this.lblAns0 = new System.Windows.Forms.Label();
            this.lblAns1 = new System.Windows.Forms.Label();
            this.lblAns2 = new System.Windows.Forms.Label();
            this.lblAns3 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.gbAns = new System.Windows.Forms.GroupBox();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.lblQCount = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.gbAns.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblQ.Location = new System.Drawing.Point(12, 9);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(71, 23);
            this.lblQ.TabIndex = 0;
            this.lblQ.Text = "Otázka:";
            // 
            // lblAns0
            // 
            this.lblAns0.AutoSize = true;
            this.lblAns0.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAns0.Location = new System.Drawing.Point(31, 19);
            this.lblAns0.Name = "lblAns0";
            this.lblAns0.Size = new System.Drawing.Size(47, 23);
            this.lblAns0.TabIndex = 2;
            this.lblAns0.Text = "ans1";
            this.lblAns0.Click += new System.EventHandler(this.ans_click);
            // 
            // lblAns1
            // 
            this.lblAns1.AutoSize = true;
            this.lblAns1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAns1.Location = new System.Drawing.Point(31, 61);
            this.lblAns1.Name = "lblAns1";
            this.lblAns1.Size = new System.Drawing.Size(51, 23);
            this.lblAns1.TabIndex = 3;
            this.lblAns1.Text = "ans2";
            this.lblAns1.Click += new System.EventHandler(this.ans_click);
            // 
            // lblAns2
            // 
            this.lblAns2.AutoSize = true;
            this.lblAns2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAns2.Location = new System.Drawing.Point(31, 106);
            this.lblAns2.Name = "lblAns2";
            this.lblAns2.Size = new System.Drawing.Size(51, 23);
            this.lblAns2.TabIndex = 4;
            this.lblAns2.Text = "ans3";
            this.lblAns2.Click += new System.EventHandler(this.ans_click);
            // 
            // lblAns3
            // 
            this.lblAns3.AutoSize = true;
            this.lblAns3.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAns3.Location = new System.Drawing.Point(31, 153);
            this.lblAns3.Name = "lblAns3";
            this.lblAns3.Size = new System.Drawing.Size(52, 23);
            this.lblAns3.TabIndex = 5;
            this.lblAns3.Text = "ans4";
            this.lblAns3.Click += new System.EventHandler(this.ans_click);
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSend.Location = new System.Drawing.Point(42, 315);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(846, 63);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "Odeslat odpoveď";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // gbAns
            // 
            this.gbAns.Controls.Add(this.lblAns0);
            this.gbAns.Controls.Add(this.lblAns1);
            this.gbAns.Controls.Add(this.lblAns3);
            this.gbAns.Controls.Add(this.lblAns2);
            this.gbAns.Location = new System.Drawing.Point(42, 87);
            this.gbAns.Name = "gbAns";
            this.gbAns.Size = new System.Drawing.Size(846, 222);
            this.gbAns.TabIndex = 11;
            this.gbAns.TabStop = false;
            this.gbAns.Text = "Odpovědi";
            // 
            // tbQuestion
            // 
            this.tbQuestion.Location = new System.Drawing.Point(42, 35);
            this.tbQuestion.Multiline = true;
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.ReadOnly = true;
            this.tbQuestion.Size = new System.Drawing.Size(846, 46);
            this.tbQuestion.TabIndex = 12;
            // 
            // lblQCount
            // 
            this.lblQCount.AutoSize = true;
            this.lblQCount.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblQCount.Location = new System.Drawing.Point(486, 9);
            this.lblQCount.Name = "lblQCount";
            this.lblQCount.Size = new System.Drawing.Size(125, 23);
            this.lblQCount.TabIndex = 13;
            this.lblQCount.Text = "Počet otázek: ";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPoints.Location = new System.Drawing.Point(718, 9);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(59, 23);
            this.lblPoints.TabIndex = 14;
            this.lblPoints.Text = "Body: ";
            // 
            // Testovac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(901, 383);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblQCount);
            this.Controls.Add(this.tbQuestion);
            this.Controls.Add(this.gbAns);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblQ);
            this.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Testovac";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Testovač";
            this.gbAns.ResumeLayout(false);
            this.gbAns.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.Label lblAns0;
        private System.Windows.Forms.Label lblAns1;
        private System.Windows.Forms.Label lblAns2;
        private System.Windows.Forms.Label lblAns3;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox gbAns;
        private System.Windows.Forms.TextBox tbQuestion;
        private System.Windows.Forms.Label lblQCount;
        private System.Windows.Forms.Label lblPoints;
    }
}

