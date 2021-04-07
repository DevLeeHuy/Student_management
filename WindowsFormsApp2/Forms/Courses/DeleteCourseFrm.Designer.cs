namespace WindowsFormsApp2.Forms.Courses
{
    partial class DeleteCourseFrm
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
            this.lbId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(46, 88);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(217, 32);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "Enter course ID:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(310, 98);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(287, 22);
            this.txtId.TabIndex = 1;
            // 
            // DeleteCourseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 233);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lbId);
            this.Name = "DeleteCourseFrm";
            this.Text = "DeleteCourseFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox txtId;
    }
}