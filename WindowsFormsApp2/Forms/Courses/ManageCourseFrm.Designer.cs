namespace WindowsFormsApp2.Forms.Courses
{
    partial class ManageCourseFrm
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
            this.addBtn = new System.Windows.Forms.Button();
            this.txtLb = new System.Windows.Forms.TextBox();
            this.txtPr = new System.Windows.Forms.TextBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lbDes = new System.Windows.Forms.Label();
            this.lbPr = new System.Windows.Forms.Label();
            this.lbLabel = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.gvListCourse = new System.Windows.Forms.DataGridView();
            this.pnTotal = new System.Windows.Forms.Panel();
            this.lbTotal = new System.Windows.Forms.Label();
            this.listStdBtn = new System.Windows.Forms.Button();
            this.gvListStudent = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbStudent = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.lboxCourse = new System.Windows.Forms.ListBox();
            this.firstBtn = new System.Windows.Forms.Button();
            this.preBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.lastBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvListCourse)).BeginInit();
            this.pnTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvListStudent)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.addBtn.Location = new System.Drawing.Point(165, 323);
            this.addBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(102, 80);
            this.addBtn.TabIndex = 17;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = false;
            // 
            // txtLb
            // 
            this.txtLb.Location = new System.Drawing.Point(139, 78);
            this.txtLb.Margin = new System.Windows.Forms.Padding(2);
            this.txtLb.Name = "txtLb";
            this.txtLb.Size = new System.Drawing.Size(206, 20);
            this.txtLb.TabIndex = 16;
            // 
            // txtPr
            // 
            this.txtPr.Location = new System.Drawing.Point(139, 122);
            this.txtPr.Margin = new System.Windows.Forms.Padding(2);
            this.txtPr.Name = "txtPr";
            this.txtPr.Size = new System.Drawing.Size(103, 20);
            this.txtPr.TabIndex = 15;
            // 
            // txtDes
            // 
            this.txtDes.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtDes.Location = new System.Drawing.Point(139, 164);
            this.txtDes.Margin = new System.Windows.Forms.Padding(2);
            this.txtDes.Multiline = true;
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(378, 134);
            this.txtDes.TabIndex = 14;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(139, 28);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(103, 20);
            this.txtId.TabIndex = 13;
            // 
            // lbDes
            // 
            this.lbDes.AutoSize = true;
            this.lbDes.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDes.Location = new System.Drawing.Point(14, 164);
            this.lbDes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDes.Name = "lbDes";
            this.lbDes.Size = new System.Drawing.Size(126, 29);
            this.lbDes.TabIndex = 12;
            this.lbDes.Text = "Description";
            // 
            // lbPr
            // 
            this.lbPr.AutoSize = true;
            this.lbPr.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPr.Location = new System.Drawing.Point(61, 110);
            this.lbPr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPr.Name = "lbPr";
            this.lbPr.Size = new System.Drawing.Size(77, 29);
            this.lbPr.TabIndex = 11;
            this.lbPr.Text = "Period";
            // 
            // lbLabel
            // 
            this.lbLabel.AutoSize = true;
            this.lbLabel.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLabel.Location = new System.Drawing.Point(71, 66);
            this.lbLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLabel.Name = "lbLabel";
            this.lbLabel.Size = new System.Drawing.Size(66, 29);
            this.lbLabel.TabIndex = 10;
            this.lbLabel.Text = "Label";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(26, 20);
            this.lbId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(111, 29);
            this.lbId.TabIndex = 9;
            this.lbId.Text = "Course ID";
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.editBtn.Location = new System.Drawing.Point(274, 323);
            this.editBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(97, 80);
            this.editBtn.TabIndex = 18;
            this.editBtn.Text = "EDIT";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Red;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(377, 323);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(100, 80);
            this.deleteBtn.TabIndex = 19;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // gvListCourse
            // 
            this.gvListCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListCourse.Location = new System.Drawing.Point(520, 10);
            this.gvListCourse.Margin = new System.Windows.Forms.Padding(2);
            this.gvListCourse.Name = "gvListCourse";
            this.gvListCourse.RowHeadersWidth = 51;
            this.gvListCourse.RowTemplate.Height = 24;
            this.gvListCourse.Size = new System.Drawing.Size(206, 394);
            this.gvListCourse.TabIndex = 20;
            // 
            // pnTotal
            // 
            this.pnTotal.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnTotal.Controls.Add(this.lbTotal);
            this.pnTotal.Location = new System.Drawing.Point(520, 417);
            this.pnTotal.Margin = new System.Windows.Forms.Padding(2);
            this.pnTotal.Name = "pnTotal";
            this.pnTotal.Size = new System.Drawing.Size(206, 50);
            this.pnTotal.TabIndex = 67;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.Coral;
            this.lbTotal.Location = new System.Drawing.Point(11, 11);
            this.lbTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(153, 25);
            this.lbTotal.TabIndex = 0;
            this.lbTotal.Text = "Total Courses:";
            // 
            // listStdBtn
            // 
            this.listStdBtn.Location = new System.Drawing.Point(245, 23);
            this.listStdBtn.Margin = new System.Windows.Forms.Padding(2);
            this.listStdBtn.Name = "listStdBtn";
            this.listStdBtn.Size = new System.Drawing.Size(99, 27);
            this.listStdBtn.TabIndex = 68;
            this.listStdBtn.Text = "List Student";
            this.listStdBtn.UseVisualStyleBackColor = true;
            this.listStdBtn.Click += new System.EventHandler(this.listStdBtn_Click);
            // 
            // gvListStudent
            // 
            this.gvListStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListStudent.Location = new System.Drawing.Point(730, 11);
            this.gvListStudent.Margin = new System.Windows.Forms.Padding(2);
            this.gvListStudent.Name = "gvListStudent";
            this.gvListStudent.RowHeadersWidth = 51;
            this.gvListStudent.RowTemplate.Height = 24;
            this.gvListStudent.Size = new System.Drawing.Size(343, 393);
            this.gvListStudent.TabIndex = 69;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.lbStudent);
            this.panel1.Location = new System.Drawing.Point(868, 417);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 50);
            this.panel1.TabIndex = 68;
            // 
            // lbStudent
            // 
            this.lbStudent.AutoSize = true;
            this.lbStudent.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudent.ForeColor = System.Drawing.Color.Coral;
            this.lbStudent.Location = new System.Drawing.Point(2, 11);
            this.lbStudent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStudent.Name = "lbStudent";
            this.lbStudent.Size = new System.Drawing.Size(170, 25);
            this.lbStudent.TabIndex = 0;
            this.lbStudent.Text = "Total Students:";
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(976, 472);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(97, 31);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "SAVE TO WORD";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // lboxCourse
            // 
            this.lboxCourse.FormattingEnabled = true;
            this.lboxCourse.Location = new System.Drawing.Point(520, 11);
            this.lboxCourse.Margin = new System.Windows.Forms.Padding(2);
            this.lboxCourse.Name = "lboxCourse";
            this.lboxCourse.Size = new System.Drawing.Size(206, 394);
            this.lboxCourse.TabIndex = 70;
            this.lboxCourse.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lboxCourse_MouseClick);
            // 
            // firstBtn
            // 
            this.firstBtn.BackColor = System.Drawing.SystemColors.ControlText;
            this.firstBtn.ForeColor = System.Drawing.Color.AliceBlue;
            this.firstBtn.Location = new System.Drawing.Point(19, 462);
            this.firstBtn.Margin = new System.Windows.Forms.Padding(2);
            this.firstBtn.Name = "firstBtn";
            this.firstBtn.Size = new System.Drawing.Size(95, 41);
            this.firstBtn.TabIndex = 71;
            this.firstBtn.Text = "FIRST";
            this.firstBtn.UseVisualStyleBackColor = false;
            this.firstBtn.Click += new System.EventHandler(this.firstBtn_Click);
            // 
            // preBtn
            // 
            this.preBtn.BackColor = System.Drawing.SystemColors.ControlText;
            this.preBtn.ForeColor = System.Drawing.Color.AliceBlue;
            this.preBtn.Location = new System.Drawing.Point(139, 462);
            this.preBtn.Margin = new System.Windows.Forms.Padding(2);
            this.preBtn.Name = "preBtn";
            this.preBtn.Size = new System.Drawing.Size(95, 41);
            this.preBtn.TabIndex = 72;
            this.preBtn.Text = "PREVIOUS";
            this.preBtn.UseVisualStyleBackColor = false;
            this.preBtn.Click += new System.EventHandler(this.preBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.SystemColors.ControlText;
            this.nextBtn.ForeColor = System.Drawing.Color.AliceBlue;
            this.nextBtn.Location = new System.Drawing.Point(257, 462);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(2);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(95, 41);
            this.nextBtn.TabIndex = 73;
            this.nextBtn.Text = "NEXT";
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // lastBtn
            // 
            this.lastBtn.BackColor = System.Drawing.SystemColors.ControlText;
            this.lastBtn.ForeColor = System.Drawing.Color.AliceBlue;
            this.lastBtn.Location = new System.Drawing.Point(382, 462);
            this.lastBtn.Margin = new System.Windows.Forms.Padding(2);
            this.lastBtn.Name = "lastBtn";
            this.lastBtn.Size = new System.Drawing.Size(95, 41);
            this.lastBtn.TabIndex = 74;
            this.lastBtn.Text = "LAST";
            this.lastBtn.UseVisualStyleBackColor = false;
            this.lastBtn.Click += new System.EventHandler(this.lastBtn_Click);
            // 
            // ManageCourseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 586);
            this.Controls.Add(this.lastBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.preBtn);
            this.Controls.Add(this.firstBtn);
            this.Controls.Add(this.lboxCourse);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gvListStudent);
            this.Controls.Add(this.listStdBtn);
            this.Controls.Add(this.pnTotal);
            this.Controls.Add(this.gvListCourse);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.txtLb);
            this.Controls.Add(this.txtPr);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lbDes);
            this.Controls.Add(this.lbPr);
            this.Controls.Add(this.lbLabel);
            this.Controls.Add(this.lbId);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManageCourseFrm";
            this.Text = "ManageCourseFrm";
            this.Load += new System.EventHandler(this.ManageCourseFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvListCourse)).EndInit();
            this.pnTotal.ResumeLayout(false);
            this.pnTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvListStudent)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox txtLb;
        private System.Windows.Forms.TextBox txtPr;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lbDes;
        private System.Windows.Forms.Label lbPr;
        private System.Windows.Forms.Label lbLabel;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DataGridView gvListCourse;
        private System.Windows.Forms.Panel pnTotal;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button listStdBtn;
        private System.Windows.Forms.DataGridView gvListStudent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbStudent;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ListBox lboxCourse;
        private System.Windows.Forms.Button firstBtn;
        private System.Windows.Forms.Button preBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button lastBtn;
    }
}