namespace ManagementApp
{
    partial class updateStdFrm
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
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.upImgBtn = new System.Windows.Forms.Button();
            this.genderBox = new System.Windows.Forms.GroupBox();
            this.femaleRaBtn = new System.Windows.Forms.RadioButton();
            this.maleRaBtn = new System.Windows.Forms.RadioButton();
            this.birthPicker = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FindBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Avatar = new System.Windows.Forms.PictureBox();
            this.genderBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Location = new System.Drawing.Point(380, 514);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(144, 41);
            this.UpdateBtn.TabIndex = 36;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // upImgBtn
            // 
            this.upImgBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.upImgBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.upImgBtn.Location = new System.Drawing.Point(766, 317);
            this.upImgBtn.Name = "upImgBtn";
            this.upImgBtn.Size = new System.Drawing.Size(278, 23);
            this.upImgBtn.TabIndex = 35;
            this.upImgBtn.Text = "Upload";
            this.upImgBtn.UseVisualStyleBackColor = false;
            this.upImgBtn.Click += new System.EventHandler(this.upImgBtn_Click);
            // 
            // genderBox
            // 
            this.genderBox.Controls.Add(this.femaleRaBtn);
            this.genderBox.Controls.Add(this.maleRaBtn);
            this.genderBox.Location = new System.Drawing.Point(246, 331);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(278, 44);
            this.genderBox.TabIndex = 33;
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
            // birthPicker
            // 
            this.birthPicker.CalendarForeColor = System.Drawing.SystemColors.ButtonFace;
            this.birthPicker.CalendarMonthBackground = System.Drawing.Color.DarkMagenta;
            this.birthPicker.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonFace;
            this.birthPicker.Location = new System.Drawing.Point(246, 280);
            this.birthPicker.Name = "birthPicker";
            this.birthPicker.Size = new System.Drawing.Size(278, 20);
            this.birthPicker.TabIndex = 32;
            this.birthPicker.Value = new System.DateTime(2000, 6, 13, 20, 55, 0, 0);
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtAddress.Location = new System.Drawing.Point(246, 475);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(278, 26);
            this.txtAddress.TabIndex = 31;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPhone.Location = new System.Drawing.Point(246, 409);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(278, 26);
            this.txtPhone.TabIndex = 30;
            // 
            // txtLname
            // 
            this.txtLname.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.txtLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtLname.Location = new System.Drawing.Point(246, 223);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(278, 26);
            this.txtLname.TabIndex = 29;
            // 
            // txtFname
            // 
            this.txtFname.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.txtFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtFname.Location = new System.Drawing.Point(246, 151);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(278, 26);
            this.txtFname.TabIndex = 28;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtId.Location = new System.Drawing.Point(246, 101);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(278, 26);
            this.txtId.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(656, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 26);
            this.label8.TabIndex = 26;
            this.label8.Text = "Picture";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(123, 470);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 26);
            this.label7.TabIndex = 25;
            this.label7.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(131, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 26);
            this.label6.TabIndex = 24;
            this.label6.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(131, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 26);
            this.label5.TabIndex = 23;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(124, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 26);
            this.label4.TabIndex = 22;
            this.label4.Text = "Birthday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 26);
            this.label3.TabIndex = 21;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 26);
            this.label2.TabIndex = 20;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 26);
            this.label1.TabIndex = 19;
            this.label1.Text = "Student ID";
            // 
            // FindBtn
            // 
            this.FindBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.FindBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindBtn.ForeColor = System.Drawing.Color.AliceBlue;
            this.FindBtn.Location = new System.Drawing.Point(540, 96);
            this.FindBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FindBtn.Name = "FindBtn";
            this.FindBtn.Size = new System.Drawing.Size(126, 33);
            this.FindBtn.TabIndex = 37;
            this.FindBtn.Text = "Find";
            this.FindBtn.UseVisualStyleBackColor = false;
            this.FindBtn.Click += new System.EventHandler(this.FindBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.BackColor = System.Drawing.Color.Tomato;
            this.RemoveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveBtn.Location = new System.Drawing.Point(540, 514);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(144, 41);
            this.RemoveBtn.TabIndex = 38;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = false;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Red;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(918, 537);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(144, 41);
            this.cancelBtn.TabIndex = 39;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Coral;
            this.label9.Location = new System.Drawing.Point(372, 22);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(327, 37);
            this.label9.TabIndex = 40;
            this.label9.Text = "Update student form";
            // 
            // Avatar
            // 
            this.Avatar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Avatar.Location = new System.Drawing.Point(766, 193);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(278, 117);
            this.Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Avatar.TabIndex = 34;
            this.Avatar.TabStop = false;
            // 
            // updateStdFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 585);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.FindBtn);
            this.Controls.Add(this.UpdateBtn);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "updateStdFrm";
            this.Text = "updateStdFrm";
            this.genderBox.ResumeLayout(false);
            this.genderBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button upImgBtn;
        private System.Windows.Forms.PictureBox Avatar;
        private System.Windows.Forms.GroupBox genderBox;
        private System.Windows.Forms.RadioButton femaleRaBtn;
        private System.Windows.Forms.RadioButton maleRaBtn;
        private System.Windows.Forms.DateTimePicker birthPicker;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FindBtn;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label9;
    }
}