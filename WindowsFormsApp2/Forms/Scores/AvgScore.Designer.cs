namespace WindowsFormsApp2.Forms.Scores
{
    partial class AvgScore
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
            this.gvAvgScore = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvAvgScore)).BeginInit();
            this.SuspendLayout();
            // 
            // gvAvgScore
            // 
            this.gvAvgScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAvgScore.Location = new System.Drawing.Point(12, 12);
            this.gvAvgScore.Name = "gvAvgScore";
            this.gvAvgScore.RowHeadersWidth = 51;
            this.gvAvgScore.RowTemplate.Height = 24;
            this.gvAvgScore.Size = new System.Drawing.Size(348, 414);
            this.gvAvgScore.TabIndex = 0;
            // 
            // AvgScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 440);
            this.Controls.Add(this.gvAvgScore);
            this.Name = "AvgScore";
            this.Text = "AvgScore";
            this.Load += new System.EventHandler(this.AvgScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvAvgScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvAvgScore;
    }
}