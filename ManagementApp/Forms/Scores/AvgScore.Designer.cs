namespace ManagementApp.Forms.Scores
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
            this.gvAvgScore.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gvAvgScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAvgScore.Location = new System.Drawing.Point(9, 10);
            this.gvAvgScore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gvAvgScore.Name = "gvAvgScore";
            this.gvAvgScore.RowHeadersWidth = 51;
            this.gvAvgScore.RowTemplate.Height = 24;
            this.gvAvgScore.Size = new System.Drawing.Size(261, 336);
            this.gvAvgScore.TabIndex = 0;
            // 
            // AvgScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 358);
            this.Controls.Add(this.gvAvgScore);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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