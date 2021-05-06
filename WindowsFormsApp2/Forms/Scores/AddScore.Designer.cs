namespace WindowsFormsApp2.Forms.Scores
{
    partial class AddScore
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCouID = new System.Windows.Forms.Label();
            this.cboxCourse = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.lbDes = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbStudent = new System.Windows.Forms.Label();
            this.gvListStudent = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvListStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtId.Location = new System.Drawing.Point(306, 27);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(369, 30);
            this.txtId.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(46, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 34);
            this.label1.TabIndex = 9;
            this.label1.Text = "Student ID";
            // 
            // lbCouID
            // 
            this.lbCouID.AutoSize = true;
            this.lbCouID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCouID.Location = new System.Drawing.Point(12, 79);
            this.lbCouID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbCouID.Name = "lbCouID";
            this.lbCouID.Size = new System.Drawing.Size(208, 32);
            this.lbCouID.TabIndex = 12;
            this.lbCouID.Text = "Select Course: ";
            // 
            // cboxCourse
            // 
            this.cboxCourse.BackColor = System.Drawing.Color.LavenderBlush;
            this.cboxCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxCourse.FormattingEnabled = true;
            this.cboxCourse.Location = new System.Drawing.Point(306, 79);
            this.cboxCourse.Margin = new System.Windows.Forms.Padding(6);
            this.cboxCourse.Name = "cboxCourse";
            this.cboxCourse.Size = new System.Drawing.Size(229, 30);
            this.cboxCourse.TabIndex = 11;
            this.cboxCourse.SelectedIndexChanged += new System.EventHandler(this.cboxCourse_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Score:";
            // 
            // txtScore
            // 
            this.txtScore.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtScore.Location = new System.Drawing.Point(306, 140);
            this.txtScore.Margin = new System.Windows.Forms.Padding(4);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(229, 30);
            this.txtScore.TabIndex = 14;
            // 
            // txtDes
            // 
            this.txtDes.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDes.Location = new System.Drawing.Point(306, 191);
            this.txtDes.Margin = new System.Windows.Forms.Padding(6);
            this.txtDes.Multiline = true;
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(344, 160);
            this.txtDes.TabIndex = 16;
            // 
            // lbDes
            // 
            this.lbDes.AutoSize = true;
            this.lbDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDes.Location = new System.Drawing.Point(111, 206);
            this.lbDes.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbDes.Name = "lbDes";
            this.lbDes.Size = new System.Drawing.Size(109, 25);
            this.lbDes.TabIndex = 15;
            this.lbDes.Text = "Description";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(360, 360);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(229, 99);
            this.addBtn.TabIndex = 19;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.lbStudent);
            this.panel1.Location = new System.Drawing.Point(865, 501);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 62);
            this.panel1.TabIndex = 71;
            // 
            // lbStudent
            // 
            this.lbStudent.AutoSize = true;
            this.lbStudent.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudent.ForeColor = System.Drawing.Color.Coral;
            this.lbStudent.Location = new System.Drawing.Point(3, 14);
            this.lbStudent.Name = "lbStudent";
            this.lbStudent.Size = new System.Drawing.Size(211, 31);
            this.lbStudent.TabIndex = 0;
            this.lbStudent.Text = "Total Students:";
            // 
            // gvListStudent
            // 
            this.gvListStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListStudent.Location = new System.Drawing.Point(682, 1);
            this.gvListStudent.Name = "gvListStudent";
            this.gvListStudent.RowHeadersWidth = 51;
            this.gvListStudent.RowTemplate.Height = 24;
            this.gvListStudent.Size = new System.Drawing.Size(457, 484);
            this.gvListStudent.TabIndex = 72;
            this.gvListStudent.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvListStudent_CellDoubleClick);
            // 
            // AddScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 568);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gvListStudent);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.lbDes);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbCouID);
            this.Controls.Add(this.cboxCourse);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Name = "AddScore";
            this.Text = "AddScore";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvListStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCouID;
        private System.Windows.Forms.ComboBox cboxCourse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.Label lbDes;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbStudent;
        private System.Windows.Forms.DataGridView gvListStudent;
    }
}