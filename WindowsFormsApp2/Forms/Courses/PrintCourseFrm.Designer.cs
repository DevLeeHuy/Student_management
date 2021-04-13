namespace WindowsFormsApp2.Forms.Courses
{
    partial class PrintCourseFrm
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
            this.gvListCourse = new System.Windows.Forms.DataGridView();
            this.saveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvListCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // gvListCourse
            // 
            this.gvListCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListCourse.Location = new System.Drawing.Point(12, 12);
            this.gvListCourse.Name = "gvListCourse";
            this.gvListCourse.RowHeadersWidth = 51;
            this.gvListCourse.RowTemplate.Height = 24;
            this.gvListCourse.Size = new System.Drawing.Size(592, 364);
            this.gvListCourse.TabIndex = 0;
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(90, 396);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(405, 65);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "SAVE TO WORD";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // PrintCourseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 504);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.gvListCourse);
            this.Name = "PrintCourseFrm";
            this.Text = "PrintCourseFrm";
            this.Load += new System.EventHandler(this.PrintCourseFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvListCourse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvListCourse;
        private System.Windows.Forms.Button saveBtn;
    }
}