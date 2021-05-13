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
            ((System.ComponentModel.ISupportInitialize)(this.nudPr)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxCourse
            // 
            this.cboxCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxCourse.FormattingEnabled = true;
            this.cboxCourse.Location = new System.Drawing.Point(297, 65);
            this.cboxCourse.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboxCourse.Name = "cboxCourse";
            this.cboxCourse.Size = new System.Drawing.Size(238, 30);
            this.cboxCourse.TabIndex = 0;
            this.cboxCourse.SelectedIndexChanged += new System.EventHandler(this.cboxCourse_SelectedIndexChanged);
            // 
            // lbCouID
            // 
            this.lbCouID.AutoSize = true;
            this.lbCouID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCouID.Location = new System.Drawing.Point(126, 70);
            this.lbCouID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbCouID.Name = "lbCouID";
            this.lbCouID.Size = new System.Drawing.Size(147, 25);
            this.lbCouID.TabIndex = 1;
            this.lbCouID.Text = "Select Course: ";
            // 
            // lbLb
            // 
            this.lbLb.AutoSize = true;
            this.lbLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLb.Location = new System.Drawing.Point(201, 147);
            this.lbLb.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbLb.Name = "lbLb";
            this.lbLb.Size = new System.Drawing.Size(60, 25);
            this.lbLb.TabIndex = 2;
            this.lbLb.Text = "Label";
            // 
            // lbPr
            // 
            this.lbPr.AutoSize = true;
            this.lbPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPr.Location = new System.Drawing.Point(194, 223);
            this.lbPr.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbPr.Name = "lbPr";
            this.lbPr.Size = new System.Drawing.Size(79, 25);
            this.lbPr.TabIndex = 3;
            this.lbPr.Text = "Period: ";
            // 
            // lbDes
            // 
            this.lbDes.AutoSize = true;
            this.lbDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDes.Location = new System.Drawing.Point(164, 303);
            this.lbDes.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbDes.Name = "lbDes";
            this.lbDes.Size = new System.Drawing.Size(109, 25);
            this.lbDes.TabIndex = 4;
            this.lbDes.Text = "Description";
            // 
            // txtLb
            // 
            this.txtLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLb.Location = new System.Drawing.Point(297, 146);
            this.txtLb.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtLb.Name = "txtLb";
            this.txtLb.Size = new System.Drawing.Size(370, 28);
            this.txtLb.TabIndex = 5;
            // 
            // txtDes
            // 
            this.txtDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDes.Location = new System.Drawing.Point(297, 283);
            this.txtDes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtDes.Multiline = true;
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(344, 160);
            this.txtDes.TabIndex = 6;
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(297, 481);
            this.editBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.nudPr.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nudPr.Name = "nudPr";
            this.nudPr.Size = new System.Drawing.Size(240, 28);
            this.nudPr.TabIndex = 8;
            // 
            // EditCourseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 614);
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
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "EditCourseFrm";
            this.Text = "EditCourse";
            this.Load += new System.EventHandler(this.EditCourseFrm_Load);
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
    }
}