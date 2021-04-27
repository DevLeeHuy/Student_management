namespace WindowsFormsApp2.Forms
{
    partial class RemoveScore
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
            this.gvListScore = new System.Windows.Forms.DataGridView();
            this.removeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvListScore)).BeginInit();
            this.SuspendLayout();
            // 
            // gvListScore
            // 
            this.gvListScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListScore.Location = new System.Drawing.Point(12, 12);
            this.gvListScore.Name = "gvListScore";
            this.gvListScore.RowHeadersWidth = 51;
            this.gvListScore.RowTemplate.Height = 24;
            this.gvListScore.Size = new System.Drawing.Size(591, 316);
            this.gvListScore.TabIndex = 0;
            this.gvListScore.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvListScore_CellClick);
            this.gvListScore.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvListScore_CellDoubleClick);
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.Color.Red;
            this.removeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.Location = new System.Drawing.Point(203, 349);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(203, 77);
            this.removeBtn.TabIndex = 1;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // RemoveScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 459);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.gvListScore);
            this.Name = "RemoveScore";
            this.Text = "RemoveScore";
            ((System.ComponentModel.ISupportInitialize)(this.gvListScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvListScore;
        private System.Windows.Forms.Button removeBtn;
    }
}