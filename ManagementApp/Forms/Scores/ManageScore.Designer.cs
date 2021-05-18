namespace ManagementApp.Forms.Scores
{
    partial class ManageScore
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
            this.removeBtn = new System.Windows.Forms.Button();
            this.gvListScore = new System.Windows.Forms.DataGridView();
            this.addBtn = new System.Windows.Forms.Button();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.lbDes = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCouID = new System.Windows.Forms.Label();
            this.cboxCourse = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.avgBtn = new System.Windows.Forms.Button();
            this.showStdBtn = new System.Windows.Forms.Button();
            this.showSBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvListScore)).BeginInit();
            this.SuspendLayout();
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.Color.Red;
            this.removeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.Location = new System.Drawing.Point(347, 428);
            this.removeBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(152, 63);
            this.removeBtn.TabIndex = 3;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // gvListScore
            // 
            this.gvListScore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvListScore.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gvListScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListScore.Location = new System.Drawing.Point(528, 33);
            this.gvListScore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gvListScore.Name = "gvListScore";
            this.gvListScore.RowHeadersWidth = 51;
            this.gvListScore.RowTemplate.Height = 24;
            this.gvListScore.Size = new System.Drawing.Size(443, 394);
            this.gvListScore.TabIndex = 2;
            this.gvListScore.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvListScore_CellClick);
            this.gvListScore.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvListScore_CellDoubleClick);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.LawnGreen;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(164, 428);
            this.addBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(154, 63);
            this.addBtn.TabIndex = 28;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // txtDes
            // 
            this.txtDes.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDes.Location = new System.Drawing.Point(223, 167);
            this.txtDes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDes.Multiline = true;
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(259, 131);
            this.txtDes.TabIndex = 27;
            // 
            // lbDes
            // 
            this.lbDes.AutoSize = true;
            this.lbDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDes.Location = new System.Drawing.Point(76, 179);
            this.lbDes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDes.Name = "lbDes";
            this.lbDes.Size = new System.Drawing.Size(89, 20);
            this.lbDes.TabIndex = 26;
            this.lbDes.Text = "Description";
            // 
            // txtScore
            // 
            this.txtScore.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtScore.Location = new System.Drawing.Point(223, 125);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(173, 26);
            this.txtScore.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 26);
            this.label2.TabIndex = 24;
            this.label2.Text = "Score:";
            // 
            // lbCouID
            // 
            this.lbCouID.AutoSize = true;
            this.lbCouID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCouID.Location = new System.Drawing.Point(2, 76);
            this.lbCouID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCouID.Name = "lbCouID";
            this.lbCouID.Size = new System.Drawing.Size(161, 26);
            this.lbCouID.TabIndex = 23;
            this.lbCouID.Text = "Select Course: ";
            // 
            // cboxCourse
            // 
            this.cboxCourse.BackColor = System.Drawing.Color.LavenderBlush;
            this.cboxCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxCourse.FormattingEnabled = true;
            this.cboxCourse.Location = new System.Drawing.Point(223, 76);
            this.cboxCourse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxCourse.Name = "cboxCourse";
            this.cboxCourse.Size = new System.Drawing.Size(173, 25);
            this.cboxCourse.TabIndex = 22;
            this.cboxCourse.SelectedIndexChanged += new System.EventHandler(this.cboxCourse_SelectedIndexChanged);
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtId.Location = new System.Drawing.Point(223, 33);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(278, 26);
            this.txtId.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 26);
            this.label1.TabIndex = 20;
            this.label1.Text = "Student ID";
            // 
            // avgBtn
            // 
            this.avgBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgBtn.Location = new System.Drawing.Point(164, 531);
            this.avgBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.avgBtn.Name = "avgBtn";
            this.avgBtn.Size = new System.Drawing.Size(336, 65);
            this.avgBtn.TabIndex = 29;
            this.avgBtn.Text = "Show Avg Score";
            this.avgBtn.UseVisualStyleBackColor = true;
            this.avgBtn.Click += new System.EventHandler(this.avgBtn_Click);
            // 
            // showStdBtn
            // 
            this.showStdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showStdBtn.Location = new System.Drawing.Point(528, 432);
            this.showStdBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showStdBtn.Name = "showStdBtn";
            this.showStdBtn.Size = new System.Drawing.Size(190, 39);
            this.showStdBtn.TabIndex = 30;
            this.showStdBtn.Text = "Show student";
            this.showStdBtn.UseVisualStyleBackColor = true;
            this.showStdBtn.Click += new System.EventHandler(this.showStdBtn_Click);
            // 
            // showSBtn
            // 
            this.showSBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showSBtn.Location = new System.Drawing.Point(769, 432);
            this.showSBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showSBtn.Name = "showSBtn";
            this.showSBtn.Size = new System.Drawing.Size(202, 39);
            this.showSBtn.TabIndex = 31;
            this.showSBtn.Text = "Show Score";
            this.showSBtn.UseVisualStyleBackColor = true;
            this.showSBtn.Click += new System.EventHandler(this.showSBtn_Click);
            // 
            // ManageScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 643);
            this.Controls.Add(this.showSBtn);
            this.Controls.Add(this.showStdBtn);
            this.Controls.Add(this.avgBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.lbDes);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbCouID);
            this.Controls.Add(this.cboxCourse);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.gvListScore);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManageScore";
            this.Text = "ManageScore";
            ((System.ComponentModel.ISupportInitialize)(this.gvListScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.DataGridView gvListScore;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.Label lbDes;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCouID;
        private System.Windows.Forms.ComboBox cboxCourse;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button avgBtn;
        private System.Windows.Forms.Button showStdBtn;
        private System.Windows.Forms.Button showSBtn;
    }
}