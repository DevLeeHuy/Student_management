namespace WindowsFormsApp2
{
    partial class AddStudentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.birthPicker = new System.Windows.Forms.DateTimePicker();
            this.genderBox = new System.Windows.Forms.GroupBox();
            this.femaleRaBtn = new System.Windows.Forms.RadioButton();
            this.maleRaBtn = new System.Windows.Forms.RadioButton();
            this.Avatar = new System.Windows.Forms.PictureBox();
            this.upImgBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.genderBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Birthday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 26);
            this.label7.TabIndex = 6;
            this.label7.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 484);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 26);
            this.label8.TabIndex = 7;
            this.label8.Text = "Picture";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtId.Location = new System.Drawing.Point(235, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(278, 26);
            this.txtId.TabIndex = 8;
            // 
            // txtFname
            // 
            this.txtFname.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.txtFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtFname.Location = new System.Drawing.Point(235, 63);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(278, 26);
            this.txtFname.TabIndex = 9;
            // 
            // txtLname
            // 
            this.txtLname.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.txtLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtLname.Location = new System.Drawing.Point(235, 134);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(278, 26);
            this.txtLname.TabIndex = 10;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPhone.Location = new System.Drawing.Point(235, 320);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(278, 26);
            this.txtPhone.TabIndex = 11;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtAddress.Location = new System.Drawing.Point(235, 387);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(278, 26);
            this.txtAddress.TabIndex = 12;
            // 
            // birthPicker
            // 
            this.birthPicker.CalendarForeColor = System.Drawing.SystemColors.ButtonFace;
            this.birthPicker.CalendarMonthBackground = System.Drawing.Color.DarkMagenta;
            this.birthPicker.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonFace;
            this.birthPicker.Location = new System.Drawing.Point(235, 192);
            this.birthPicker.Name = "birthPicker";
            this.birthPicker.Size = new System.Drawing.Size(278, 20);
            this.birthPicker.TabIndex = 14;
            // 
            // genderBox
            // 
            this.genderBox.Controls.Add(this.femaleRaBtn);
            this.genderBox.Controls.Add(this.maleRaBtn);
            this.genderBox.Location = new System.Drawing.Point(235, 242);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(278, 44);
            this.genderBox.TabIndex = 15;
            this.genderBox.TabStop = false;
            this.genderBox.Text = "gender";
            // 
            // femaleRaBtn
            // 
            this.femaleRaBtn.AutoSize = true;
            this.femaleRaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleRaBtn.Location = new System.Drawing.Point(160, 11);
            this.femaleRaBtn.Name = "femaleRaBtn";
            this.femaleRaBtn.Size = new System.Drawing.Size(84, 28);
            this.femaleRaBtn.TabIndex = 1;
            this.femaleRaBtn.TabStop = true;
            this.femaleRaBtn.Text = "female";
            this.femaleRaBtn.UseVisualStyleBackColor = true;
            // 
            // maleRaBtn
            // 
            this.maleRaBtn.AutoSize = true;
            this.maleRaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleRaBtn.Location = new System.Drawing.Point(44, 12);
            this.maleRaBtn.Name = "maleRaBtn";
            this.maleRaBtn.Size = new System.Drawing.Size(69, 28);
            this.maleRaBtn.TabIndex = 0;
            this.maleRaBtn.TabStop = true;
            this.maleRaBtn.Text = "male";
            this.maleRaBtn.UseVisualStyleBackColor = true;
            // 
            // Avatar
            // 
            this.Avatar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Avatar.Location = new System.Drawing.Point(235, 434);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(278, 117);
            this.Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Avatar.TabIndex = 16;
            this.Avatar.TabStop = false;
            // 
            // upImgBtn
            // 
            this.upImgBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.upImgBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.upImgBtn.Location = new System.Drawing.Point(235, 557);
            this.upImgBtn.Name = "upImgBtn";
            this.upImgBtn.Size = new System.Drawing.Size(278, 23);
            this.upImgBtn.TabIndex = 17;
            this.upImgBtn.Text = "Upload";
            this.upImgBtn.UseVisualStyleBackColor = false;
            this.upImgBtn.Click += new System.EventHandler(this.upImgBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(204, 605);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(144, 41);
            this.submitBtn.TabIndex = 18;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(563, 658);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.upImgBtn);
            this.Controls.Add(this.Avatar);
            this.Controls.Add(this.genderBox);
            this.Controls.Add(this.birthPicker);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddStudentForm";
            this.Text = "AddStudentForm";
            this.genderBox.ResumeLayout(false);
            this.genderBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DateTimePicker birthPicker;
        private System.Windows.Forms.GroupBox genderBox;
        private System.Windows.Forms.RadioButton femaleRaBtn;
        private System.Windows.Forms.RadioButton maleRaBtn;
        private System.Windows.Forms.PictureBox Avatar;
        private System.Windows.Forms.Button upImgBtn;
        private System.Windows.Forms.Button submitBtn;
    }
}