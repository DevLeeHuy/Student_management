namespace WindowsFormsApp2.Forms
{
    partial class frmManage
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.FindBtn = new System.Windows.Forms.Button();
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
            this.searchBtn = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.gvListStudent = new System.Windows.Forms.DataGridView();
            this.Avatar = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.pnTotal = new System.Windows.Forms.Panel();
            this.lbTotal = new System.Windows.Forms.Label();
            this.btnDown = new System.Windows.Forms.Button();
            this.genderBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvListStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            this.pnTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelBtn.BackColor = System.Drawing.Color.Red;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(1474, 847);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(192, 51);
            this.cancelBtn.TabIndex = 60;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.BackColor = System.Drawing.Color.Tomato;
            this.RemoveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveBtn.Location = new System.Drawing.Point(375, 755);
            this.RemoveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(192, 51);
            this.RemoveBtn.TabIndex = 59;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = false;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // FindBtn
            // 
            this.FindBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.FindBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindBtn.ForeColor = System.Drawing.Color.AliceBlue;
            this.FindBtn.Location = new System.Drawing.Point(399, 11);
            this.FindBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FindBtn.Name = "FindBtn";
            this.FindBtn.Size = new System.Drawing.Size(168, 35);
            this.FindBtn.TabIndex = 58;
            this.FindBtn.Text = "Find";
            this.FindBtn.UseVisualStyleBackColor = false;
            this.FindBtn.Click += new System.EventHandler(this.FindBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Location = new System.Drawing.Point(175, 755);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(192, 51);
            this.UpdateBtn.TabIndex = 57;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // upImgBtn
            // 
            this.upImgBtn.BackColor = System.Drawing.Color.MediumAquamarine;
            this.upImgBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upImgBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.upImgBtn.Location = new System.Drawing.Point(197, 685);
            this.upImgBtn.Margin = new System.Windows.Forms.Padding(4);
            this.upImgBtn.Name = "upImgBtn";
            this.upImgBtn.Size = new System.Drawing.Size(370, 28);
            this.upImgBtn.TabIndex = 56;
            this.upImgBtn.Text = "Upload";
            this.upImgBtn.UseVisualStyleBackColor = false;
            this.upImgBtn.Click += new System.EventHandler(this.upImgBtn_Click);
            // 
            // genderBox
            // 
            this.genderBox.Controls.Add(this.femaleRaBtn);
            this.genderBox.Controls.Add(this.maleRaBtn);
            this.genderBox.Location = new System.Drawing.Point(197, 299);
            this.genderBox.Margin = new System.Windows.Forms.Padding(4);
            this.genderBox.Name = "genderBox";
            this.genderBox.Padding = new System.Windows.Forms.Padding(4);
            this.genderBox.Size = new System.Drawing.Size(370, 54);
            this.genderBox.TabIndex = 54;
            this.genderBox.TabStop = false;
            this.genderBox.Text = "gender";
            // 
            // femaleRaBtn
            // 
            this.femaleRaBtn.AutoSize = true;
            this.femaleRaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleRaBtn.Location = new System.Drawing.Point(214, 13);
            this.femaleRaBtn.Margin = new System.Windows.Forms.Padding(4);
            this.femaleRaBtn.Name = "femaleRaBtn";
            this.femaleRaBtn.Size = new System.Drawing.Size(107, 33);
            this.femaleRaBtn.TabIndex = 1;
            this.femaleRaBtn.TabStop = true;
            this.femaleRaBtn.Text = "female";
            this.femaleRaBtn.UseVisualStyleBackColor = true;
            // 
            // maleRaBtn
            // 
            this.maleRaBtn.AutoSize = true;
            this.maleRaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleRaBtn.Location = new System.Drawing.Point(58, 15);
            this.maleRaBtn.Margin = new System.Windows.Forms.Padding(4);
            this.maleRaBtn.Name = "maleRaBtn";
            this.maleRaBtn.Size = new System.Drawing.Size(87, 33);
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
            this.birthPicker.Location = new System.Drawing.Point(197, 237);
            this.birthPicker.Margin = new System.Windows.Forms.Padding(4);
            this.birthPicker.Name = "birthPicker";
            this.birthPicker.Size = new System.Drawing.Size(370, 22);
            this.birthPicker.TabIndex = 53;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.MediumAquamarine;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtAddress.Location = new System.Drawing.Point(197, 477);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(370, 30);
            this.txtAddress.TabIndex = 52;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.MediumAquamarine;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPhone.Location = new System.Drawing.Point(197, 395);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(370, 30);
            this.txtPhone.TabIndex = 51;
            // 
            // txtLname
            // 
            this.txtLname.BackColor = System.Drawing.Color.MediumAquamarine;
            this.txtLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtLname.Location = new System.Drawing.Point(197, 166);
            this.txtLname.Margin = new System.Windows.Forms.Padding(4);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(370, 30);
            this.txtLname.TabIndex = 50;
            // 
            // txtFname
            // 
            this.txtFname.BackColor = System.Drawing.Color.MediumAquamarine;
            this.txtFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtFname.Location = new System.Drawing.Point(197, 78);
            this.txtFname.Margin = new System.Windows.Forms.Padding(4);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(370, 30);
            this.txtFname.TabIndex = 49;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.MediumAquamarine;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtId.Location = new System.Drawing.Point(197, 16);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(197, 30);
            this.txtId.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(49, 589);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 34);
            this.label8.TabIndex = 47;
            this.label8.Text = "Picture";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 470);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 34);
            this.label7.TabIndex = 46;
            this.label7.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 387);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 34);
            this.label6.TabIndex = 45;
            this.label6.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 312);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 34);
            this.label5.TabIndex = 44;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 230);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 34);
            this.label4.TabIndex = 43;
            this.label4.Text = "Birthday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 34);
            this.label3.TabIndex = 42;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 34);
            this.label2.TabIndex = 41;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 34);
            this.label1.TabIndex = 40;
            this.label1.Text = "Student ID";
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Navy;
            this.searchBtn.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.Magenta;
            this.searchBtn.Location = new System.Drawing.Point(1465, 10);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(110, 40);
            this.searchBtn.TabIndex = 62;
            this.searchBtn.Text = "Find";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(1259, 11);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(202, 34);
            this.txtSearch.TabIndex = 61;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // gvListStudent
            // 
            this.gvListStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvListStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListStudent.Location = new System.Drawing.Point(573, 54);
            this.gvListStudent.Margin = new System.Windows.Forms.Padding(2);
            this.gvListStudent.Name = "gvListStudent";
            this.gvListStudent.RowHeadersWidth = 102;
            this.gvListStudent.RowTemplate.Height = 80;
            this.gvListStudent.Size = new System.Drawing.Size(1160, 773);
            this.gvListStudent.TabIndex = 63;
            this.gvListStudent.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvListStudent_CellDoubleClick);
            // 
            // Avatar
            // 
            this.Avatar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Avatar.Location = new System.Drawing.Point(197, 533);
            this.Avatar.Margin = new System.Windows.Forms.Padding(4);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(370, 144);
            this.Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Avatar.TabIndex = 55;
            this.Avatar.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DarkCyan;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("MV Boli", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefresh.Location = new System.Drawing.Point(137, 817);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(270, 74);
            this.btnRefresh.TabIndex = 64;
            this.btnRefresh.Text = "RESET";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.hand_painted_watercolor_background_with_sky_clouds_shape_24972_1095;
            this.submitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(4, 756);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(160, 50);
            this.submitBtn.TabIndex = 65;
            this.submitBtn.Text = "ADD";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // pnTotal
            // 
            this.pnTotal.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnTotal.Controls.Add(this.lbTotal);
            this.pnTotal.Location = new System.Drawing.Point(574, 830);
            this.pnTotal.Name = "pnTotal";
            this.pnTotal.Size = new System.Drawing.Size(274, 62);
            this.pnTotal.TabIndex = 66;
            this.pnTotal.Paint += new System.Windows.Forms.PaintEventHandler(this.pnTotal_Paint);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.Coral;
            this.lbTotal.Location = new System.Drawing.Point(15, 14);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(206, 31);
            this.lbTotal.TabIndex = 0;
            this.lbTotal.Text = "Total students:";
            this.lbTotal.Click += new System.EventHandler(this.lbTotal_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDown.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDown.Location = new System.Drawing.Point(197, 719);
            this.btnDown.Margin = new System.Windows.Forms.Padding(4);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(370, 28);
            this.btnDown.TabIndex = 67;
            this.btnDown.Text = "DOWNLOAD";
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // frmManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.background_gradient_cau_vong_052410381;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1739, 976);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.pnTotal);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.gvListStudent);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.txtSearch);
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
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmManage";
            this.Load += new System.EventHandler(this.frmManage_Load);
            this.genderBox.ResumeLayout(false);
            this.genderBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvListStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            this.pnTotal.ResumeLayout(false);
            this.pnTotal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button FindBtn;
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
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView gvListStudent;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Panel pnTotal;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button btnDown;
    }
}