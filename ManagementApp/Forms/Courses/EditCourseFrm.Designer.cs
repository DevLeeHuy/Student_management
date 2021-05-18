namespace ManagementApp.Forms.Courses
{
    partial class EditCourseFrm
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
            this.cboxCourse = new System.Windows.Forms.ComboBox();
            this.lbCouID = new System.Windows.Forms.Label();
            this.lbLb = new System.Windows.Forms.Label();
            this.lbPr = new System.Windows.Forms.Label();
            this.lbDes = new System.Windows.Forms.Label();
            this.txtLb = new System.Windows.Forms.TextBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.editBtn = new System.Windows.Forms.Button();
            this.nudPr = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSem = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPr)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxCourse
            // 
            this.cboxCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxCourse.FormattingEnabled = true;
            this.cboxCourse.Location = new System.Drawing.Point(297, 69);
            this.cboxCourse.Margin = new System.Windows.Forms.Padding(6);
            this.cboxCourse.Name = "cboxCourse";
            this.cboxCourse.Size = new System.Drawing.Size(238, 25);
            this.cboxCourse.TabIndex = 0;
            this.cboxCourse.SelectedIndexChanged += new System.EventHandler(this.cboxCourse_SelectedIndexChanged);
            // 
            // lbCouID
            // 
            this.lbCouID.AutoSize = true;
            this.lbCouID.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lbCouID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCouID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbCouID.Location = new System.Drawing.Point(132, 67);
            this.lbCouID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbCouID.Name = "lbCouID";
            this.lbCouID.Size = new System.Drawing.Size(153, 24);
            this.lbCouID.TabIndex = 1;
            this.lbCouID.Text = "Select Course: ";
            // 
            // lbLb
            // 
            this.lbLb.AutoSize = true;
            this.lbLb.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lbLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbLb.Location = new System.Drawing.Point(201, 168);
            this.lbLb.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbLb.Name = "lbLb";
            this.lbLb.Size = new System.Drawing.Size(61, 24);
            this.lbLb.TabIndex = 2;
            this.lbLb.Text = "Label";
            // 
            // lbPr
            // 
            this.lbPr.AutoSize = true;
            this.lbPr.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lbPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPr.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbPr.Location = new System.Drawing.Point(194, 220);
            this.lbPr.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbPr.Name = "lbPr";
            this.lbPr.Size = new System.Drawing.Size(83, 24);
            this.lbPr.TabIndex = 3;
            this.lbPr.Text = "Period: ";
            // 
            // lbDes
            // 
            this.lbDes.AutoSize = true;
            this.lbDes.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lbDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbDes.Location = new System.Drawing.Point(164, 300);
            this.lbDes.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbDes.Name = "lbDes";
            this.lbDes.Size = new System.Drawing.Size(115, 24);
            this.lbDes.TabIndex = 4;
            this.lbDes.Text = "Description";
            // 
            // txtLb
            // 
            this.txtLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLb.Location = new System.Drawing.Point(297, 170);
            this.txtLb.Margin = new System.Windows.Forms.Padding(6);
            this.txtLb.Name = "txtLb";
            this.txtLb.Size = new System.Drawing.Size(370, 24);
            this.txtLb.TabIndex = 5;
            // 
            // txtDes
            // 
            this.txtDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDes.Location = new System.Drawing.Point(297, 283);
            this.txtDes.Margin = new System.Windows.Forms.Padding(6);
            this.txtDes.Multiline = true;
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(344, 160);
            this.txtDes.TabIndex = 6;
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(297, 481);
            this.editBtn.Margin = new System.Windows.Forms.Padding(6);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(372, 46);
            this.editBtn.TabIndex = 7;
            this.editBtn.Text = "EDIT";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // nudPr
            // 
            this.nudPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPr.Location = new System.Drawing.Point(297, 220);
            this.nudPr.Margin = new System.Windows.Forms.Padding(6);
            this.nudPr.Name = "nudPr";
            this.nudPr.Size = new System.Drawing.Size(240, 24);
            this.nudPr.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(557, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select Semester: ";
            // 
            // cbSem
            // 
            this.cbSem.FormattingEnabled = true;
            this.cbSem.Location = new System.Drawing.Point(740, 67);
            this.cbSem.Name = "cbSem";
            this.cbSem.Size = new System.Drawing.Size(63, 34);
            this.cbSem.TabIndex = 10;
            // 
            // EditCourseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 614);
            this.Controls.Add(this.cbSem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudPr);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.txtLb);
            this.Controls.Add(this.lbDes);
            this.Controls.Add(this.lbPr);
            this.Controls.Add(this.lbLb);
            this.Controls.Add(this.lbCouID);
            this.Controls.Add(this.cboxCourse);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "EditCourseFrm";
            this.Text = "EditCourse";
            ((System.ComponentModel.ISupportInitialize)(this.nudPr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxCourse;
        private System.Windows.Forms.Label lbCouID;
        private System.Windows.Forms.Label lbLb;
        private System.Windows.Forms.Label lbPr;
        private System.Windows.Forms.Label lbDes;
        private System.Windows.Forms.TextBox txtLb;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.NumericUpDown nudPr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSem;
    }
}