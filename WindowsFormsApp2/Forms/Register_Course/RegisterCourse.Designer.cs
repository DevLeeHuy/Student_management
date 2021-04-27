namespace WindowsFormsApp2.Forms.Register_Course
{
    partial class RegisterCourse
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
            this.txtStdId = new System.Windows.Forms.TextBox();
            this.cbSem = new System.Windows.Forms.ComboBox();
            this.stdId = new System.Windows.Forms.Label();
            this.semLb = new System.Windows.Forms.Label();
            this.AvaiLb = new System.Windows.Forms.Label();
            this.selectLb = new System.Windows.Forms.Label();
            this.lboxCou = new System.Windows.Forms.ListBox();
            this.lboxSelect = new System.Windows.Forms.ListBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtStdId
            // 
            this.txtStdId.Location = new System.Drawing.Point(117, 67);
            this.txtStdId.Name = "txtStdId";
            this.txtStdId.Size = new System.Drawing.Size(123, 22);
            this.txtStdId.TabIndex = 0;
            // 
            // cbSem
            // 
            this.cbSem.FormattingEnabled = true;
            this.cbSem.Location = new System.Drawing.Point(504, 67);
            this.cbSem.Name = "cbSem";
            this.cbSem.Size = new System.Drawing.Size(121, 24);
            this.cbSem.TabIndex = 1;
            // 
            // stdId
            // 
            this.stdId.AutoSize = true;
            this.stdId.Location = new System.Drawing.Point(13, 67);
            this.stdId.Name = "stdId";
            this.stdId.Size = new System.Drawing.Size(82, 17);
            this.stdId.TabIndex = 2;
            this.stdId.Text = "Student ID: ";
            // 
            // semLb
            // 
            this.semLb.AutoSize = true;
            this.semLb.Location = new System.Drawing.Point(394, 66);
            this.semLb.Name = "semLb";
            this.semLb.Size = new System.Drawing.Size(76, 17);
            this.semLb.TabIndex = 3;
            this.semLb.Text = "Semester: ";
            // 
            // AvaiLb
            // 
            this.AvaiLb.AutoSize = true;
            this.AvaiLb.Location = new System.Drawing.Point(16, 138);
            this.AvaiLb.Name = "AvaiLb";
            this.AvaiLb.Size = new System.Drawing.Size(129, 17);
            this.AvaiLb.TabIndex = 4;
            this.AvaiLb.Text = "Available Courses: ";
            // 
            // selectLb
            // 
            this.selectLb.AutoSize = true;
            this.selectLb.Location = new System.Drawing.Point(459, 147);
            this.selectLb.Name = "selectLb";
            this.selectLb.Size = new System.Drawing.Size(63, 17);
            this.selectLb.TabIndex = 5;
            this.selectLb.Text = "Selected";
            // 
            // lboxCou
            // 
            this.lboxCou.FormattingEnabled = true;
            this.lboxCou.ItemHeight = 16;
            this.lboxCou.Location = new System.Drawing.Point(12, 185);
            this.lboxCou.Name = "lboxCou";
            this.lboxCou.Size = new System.Drawing.Size(322, 260);
            this.lboxCou.TabIndex = 6;
            // 
            // lboxSelect
            // 
            this.lboxSelect.FormattingEnabled = true;
            this.lboxSelect.ItemHeight = 16;
            this.lboxSelect.Location = new System.Drawing.Point(450, 185);
            this.lboxSelect.Name = "lboxSelect";
            this.lboxSelect.Size = new System.Drawing.Size(338, 260);
            this.lboxSelect.TabIndex = 7;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(340, 185);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(103, 73);
            this.addBtn.TabIndex = 8;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(340, 372);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(103, 73);
            this.saveBtn.TabIndex = 9;
            this.saveBtn.Text = "SAVE";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(340, 264);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(103, 73);
            this.delBtn.TabIndex = 10;
            this.delBtn.Text = "DELETE";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // RegisterCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.lboxSelect);
            this.Controls.Add(this.lboxCou);
            this.Controls.Add(this.selectLb);
            this.Controls.Add(this.AvaiLb);
            this.Controls.Add(this.semLb);
            this.Controls.Add(this.stdId);
            this.Controls.Add(this.cbSem);
            this.Controls.Add(this.txtStdId);
            this.Name = "RegisterCourse";
            this.Text = "RegisterCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStdId;
        private System.Windows.Forms.ComboBox cbSem;
        private System.Windows.Forms.Label stdId;
        private System.Windows.Forms.Label semLb;
        private System.Windows.Forms.Label AvaiLb;
        private System.Windows.Forms.Label selectLb;
        private System.Windows.Forms.ListBox lboxCou;
        private System.Windows.Forms.ListBox lboxSelect;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button delBtn;
    }
}