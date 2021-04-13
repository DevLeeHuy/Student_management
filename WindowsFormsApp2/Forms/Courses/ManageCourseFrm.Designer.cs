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
            ((System.ComponentModel.ISupportInitialize)(this.gvListCourse)).BeginInit();
            this.pnTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(220, 398);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(136, 99);
            this.addBtn.TabIndex = 17;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // txtLb
            // 
            this.txtLb.Location = new System.Drawing.Point(185, 96);
            this.txtLb.Name = "txtLb";
            this.txtLb.Size = new System.Drawing.Size(274, 22);
            this.txtLb.TabIndex = 16;
            // 
            // txtPr
            // 
            this.txtPr.Location = new System.Drawing.Point(185, 150);
            this.txtPr.Name = "txtPr";
            this.txtPr.Size = new System.Drawing.Size(136, 22);
            this.txtPr.TabIndex = 15;
            // 
            // txtDes
            // 
            this.txtDes.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtDes.Location = new System.Drawing.Point(185, 202);
            this.txtDes.Multiline = true;
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(502, 164);
            this.txtDes.TabIndex = 14;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(185, 35);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(136, 22);
            this.txtId.TabIndex = 13;
            // 
            // lbDes
            // 
            this.lbDes.AutoSize = true;
            this.lbDes.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDes.Location = new System.Drawing.Point(18, 202);
            this.lbDes.Name = "lbDes";
            this.lbDes.Size = new System.Drawing.Size(161, 37);
            this.lbDes.TabIndex = 12;
            this.lbDes.Text = "Description";
            // 
            // lbPr
            // 
            this.lbPr.AutoSize = true;
            this.lbPr.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPr.Location = new System.Drawing.Point(81, 135);
            this.lbPr.Name = "lbPr";
            this.lbPr.Size = new System.Drawing.Size(98, 37);
            this.lbPr.TabIndex = 11;
            this.lbPr.Text = "Period";
            // 
            // lbLabel
            // 
            this.lbLabel.AutoSize = true;
            this.lbLabel.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLabel.Location = new System.Drawing.Point(95, 81);
            this.lbLabel.Name = "lbLabel";
            this.lbLabel.Size = new System.Drawing.Size(84, 37);
            this.lbLabel.TabIndex = 10;
            this.lbLabel.Text = "Label";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(35, 24);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(144, 37);
            this.lbId.TabIndex = 9;
            this.lbId.Text = "Course ID";
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(365, 398);
            this.editBtn.Margin = new System.Windows.Forms.Padding(6);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(129, 99);
            this.editBtn.TabIndex = 18;
            this.editBtn.Text = "EDIT";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(503, 398);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(134, 99);
            this.deleteBtn.TabIndex = 19;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // gvListCourse
            // 
            this.gvListCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListCourse.Location = new System.Drawing.Point(693, 12);
            this.gvListCourse.Name = "gvListCourse";
            this.gvListCourse.RowHeadersWidth = 51;
            this.gvListCourse.RowTemplate.Height = 24;
            this.gvListCourse.Size = new System.Drawing.Size(606, 485);
            this.gvListCourse.TabIndex = 20;
            // 
            // pnTotal
            // 
            this.pnTotal.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnTotal.Controls.Add(this.lbTotal);
            this.pnTotal.Location = new System.Drawing.Point(693, 513);
            this.pnTotal.Name = "pnTotal";
            this.pnTotal.Size = new System.Drawing.Size(274, 62);
            this.pnTotal.TabIndex = 67;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.Coral;
            this.lbTotal.Location = new System.Drawing.Point(15, 14);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(190, 31);
            this.lbTotal.TabIndex = 0;
            this.lbTotal.Text = "Total Courses:";
            // 
            // ManageCourseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 721);
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
            this.Name = "ManageCourseFrm";
            this.Text = "ManageCourseFrm";
            this.Load += new System.EventHandler(this.ManageCourseFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvListCourse)).EndInit();
            this.pnTotal.ResumeLayout(false);
            this.pnTotal.PerformLayout();
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
    }
}