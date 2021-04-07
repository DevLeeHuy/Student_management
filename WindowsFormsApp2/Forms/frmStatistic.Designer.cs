namespace WindowsFormsApp2
{
    partial class frmStatistic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnTotal = new System.Windows.Forms.Panel();
            this.lbTotal = new System.Windows.Forms.Label();
            this.pnMale = new System.Windows.Forms.Panel();
            this.lbMale = new System.Windows.Forms.Label();
            this.pnFemale = new System.Windows.Forms.Panel();
            this.lbFemale = new System.Windows.Forms.Label();
            this.pnTotal.SuspendLayout();
            this.pnMale.SuspendLayout();
            this.pnFemale.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTotal
            // 
            this.pnTotal.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnTotal.Controls.Add(this.lbTotal);
            this.pnTotal.Location = new System.Drawing.Point(12, 12);
            this.pnTotal.Name = "pnTotal";
            this.pnTotal.Size = new System.Drawing.Size(776, 213);
            this.pnTotal.TabIndex = 0;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.Coral;
            this.lbTotal.Location = new System.Drawing.Point(227, 88);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(97, 40);
            this.lbTotal.TabIndex = 0;
            this.lbTotal.Text = "label1";
            // 
            // pnMale
            // 
            this.pnMale.BackColor = System.Drawing.Color.MediumAquamarine;
            this.pnMale.Controls.Add(this.lbMale);
            this.pnMale.Location = new System.Drawing.Point(12, 231);
            this.pnMale.Name = "pnMale";
            this.pnMale.Size = new System.Drawing.Size(387, 207);
            this.pnMale.TabIndex = 1;
            // 
            // lbMale
            // 
            this.lbMale.AutoSize = true;
            this.lbMale.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMale.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbMale.Location = new System.Drawing.Point(73, 79);
            this.lbMale.Name = "lbMale";
            this.lbMale.Size = new System.Drawing.Size(97, 40);
            this.lbMale.TabIndex = 1;
            this.lbMale.Text = "label1";
            // 
            // pnFemale
            // 
            this.pnFemale.BackColor = System.Drawing.Color.Violet;
            this.pnFemale.Controls.Add(this.lbFemale);
            this.pnFemale.Location = new System.Drawing.Point(405, 231);
            this.pnFemale.Name = "pnFemale";
            this.pnFemale.Size = new System.Drawing.Size(383, 207);
            this.pnFemale.TabIndex = 2;
            // 
            // lbFemale
            // 
            this.lbFemale.AutoSize = true;
            this.lbFemale.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFemale.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbFemale.Location = new System.Drawing.Point(82, 79);
            this.lbFemale.Name = "lbFemale";
            this.lbFemale.Size = new System.Drawing.Size(97, 40);
            this.lbFemale.TabIndex = 2;
            this.lbFemale.Text = "label1";
            // 
            // frmStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnFemale);
            this.Controls.Add(this.pnMale);
            this.Controls.Add(this.pnTotal);
            this.Name = "frmStatistic";
            this.Text = "frmStatistic";
            this.Load += new System.EventHandler(this.frmStatistic_Load);
            this.pnTotal.ResumeLayout(false);
            this.pnTotal.PerformLayout();
            this.pnMale.ResumeLayout(false);
            this.pnMale.PerformLayout();
            this.pnFemale.ResumeLayout(false);
            this.pnFemale.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTotal;
        private System.Windows.Forms.Panel pnMale;
        private System.Windows.Forms.Panel pnFemale;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbMale;
        private System.Windows.Forms.Label lbFemale;
    }
}