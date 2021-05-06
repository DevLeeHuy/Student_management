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
            this.clrBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtStdId
            // 
            this.txtStdId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStdId.Location = new System.Drawing.Point(189, 33);
            this.txtStdId.Margin = new System.Windows.Forms.Padding(4);
            this.txtStdId.Name = "txtStdId";
            this.txtStdId.Size = new System.Drawing.Size(198, 37);
            this.txtStdId.TabIndex = 0;
            // 
            // cbSem
            // 
            this.cbSem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSem.FormattingEnabled = true;
            this.cbSem.Location = new System.Drawing.Point(607, 33);
            this.cbSem.Margin = new System.Windows.Forms.Padding(4);
            this.cbSem.Name = "cbSem";
            this.cbSem.Size = new System.Drawing.Size(195, 38);
            this.cbSem.TabIndex = 1;
            // 
            // stdId
            // 
            this.stdId.AutoSize = true;
            this.stdId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdId.Location = new System.Drawing.Point(20, 33);
            this.stdId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stdId.Name = "stdId";
            this.stdId.Size = new System.Drawing.Size(170, 31);
            this.stdId.TabIndex = 2;
            this.stdId.Text = "Student ID: ";
            // 
            // semLb
            // 
            this.semLb.AutoSize = true;
            this.semLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semLb.Location = new System.Drawing.Point(429, 33);
            this.semLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.semLb.Name = "semLb";
            this.semLb.Size = new System.Drawing.Size(155, 31);
            this.semLb.TabIndex = 3;
            this.semLb.Text = "Semester: ";
            // 
            // AvaiLb
            // 
            this.AvaiLb.AutoSize = true;
            this.AvaiLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvaiLb.Location = new System.Drawing.Point(20, 110);
            this.AvaiLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AvaiLb.Name = "AvaiLb";
            this.AvaiLb.Size = new System.Drawing.Size(267, 31);
            this.AvaiLb.TabIndex = 4;
            this.AvaiLb.Text = "Available Courses: ";
            // 
            // selectLb
            // 
            this.selectLb.AutoSize = true;
            this.selectLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectLb.Location = new System.Drawing.Point(606, 109);
            this.selectLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectLb.Name = "selectLb";
            this.selectLb.Size = new System.Drawing.Size(128, 31);
            this.selectLb.TabIndex = 5;
            this.selectLb.Text = "Selected";
            // 
            // lboxCou
            // 
            this.lboxCou.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxCou.FormattingEnabled = true;
            this.lboxCou.ItemHeight = 30;
            this.lboxCou.Location = new System.Drawing.Point(20, 139);
            this.lboxCou.Margin = new System.Windows.Forms.Padding(4);
            this.lboxCou.Name = "lboxCou";
            this.lboxCou.Size = new System.Drawing.Size(403, 394);
            this.lboxCou.TabIndex = 6;
            // 
            // lboxSelect
            // 
            this.lboxSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxSelect.FormattingEnabled = true;
            this.lboxSelect.ItemHeight = 30;
            this.lboxSelect.Location = new System.Drawing.Point(611, 138);
            this.lboxSelect.Margin = new System.Windows.Forms.Padding(4);
            this.lboxSelect.Name = "lboxSelect";
            this.lboxSelect.Size = new System.Drawing.Size(400, 394);
            this.lboxSelect.TabIndex = 7;
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(525, 224);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(82, 78);
            this.addBtn.TabIndex = 8;
            this.addBtn.Text = "➕";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(873, 563);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(138, 69);
            this.saveBtn.TabIndex = 9;
            this.saveBtn.Text = "Save 📁";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBtn.Location = new System.Drawing.Point(431, 224);
            this.delBtn.Margin = new System.Windows.Forms.Padding(4);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(82, 78);
            this.delBtn.TabIndex = 10;
            this.delBtn.Text = "➖";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // clrBtn
            // 
            this.clrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clrBtn.Location = new System.Drawing.Point(431, 339);
            this.clrBtn.Margin = new System.Windows.Forms.Padding(4);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(168, 64);
            this.clrBtn.TabIndex = 11;
            this.clrBtn.Text = "🧹";
            this.clrBtn.UseVisualStyleBackColor = true;
            this.clrBtn.Click += new System.EventHandler(this.clrBtn_Click);
            // 
            // RegisterCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 648);
            this.Controls.Add(this.clrBtn);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button clrBtn;
    }
}