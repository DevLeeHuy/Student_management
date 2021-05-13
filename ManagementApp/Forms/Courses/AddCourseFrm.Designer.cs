namespace ManagementApp.Forms.Courses
{
    partial class AddCourseFrm
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
            this.lbId = new System.Windows.Forms.Label();
            this.lbLabel = new System.Windows.Forms.Label();
            this.lbPr = new System.Windows.Forms.Label();
            this.lbDes = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.txtPr = new System.Windows.Forms.TextBox();
            this.txtLb = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.cbSem = new System.Windows.Forms.ComboBox();
            this.lbSemester = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(38, 54);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(144, 37);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "Course ID";
            // 
            // lbLabel
            // 
            this.lbLabel.AutoSize = true;
            this.lbLabel.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLabel.Location = new System.Drawing.Point(98, 111);
            this.lbLabel.Name = "lbLabel";
            this.lbLabel.Size = new System.Drawing.Size(84, 37);
            this.lbLabel.TabIndex = 1;
            this.lbLabel.Text = "Label";
            // 
            // lbPr
            // 
            this.lbPr.AutoSize = true;
            this.lbPr.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPr.Location = new System.Drawing.Point(84, 165);
            this.lbPr.Name = "lbPr";
            this.lbPr.Size = new System.Drawing.Size(98, 37);
            this.lbPr.TabIndex = 2;
            this.lbPr.Text = "Period";
            // 
            // lbDes
            // 
            this.lbDes.AutoSize = true;
            this.lbDes.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDes.Location = new System.Drawing.Point(21, 232);
            this.lbDes.Name = "lbDes";
            this.lbDes.Size = new System.Drawing.Size(161, 37);
            this.lbDes.TabIndex = 3;
            this.lbDes.Text = "Description";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(225, 65);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(136, 22);
            this.txtId.TabIndex = 4;
            // 
            // txtDes
            // 
            this.txtDes.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtDes.Location = new System.Drawing.Point(225, 232);
            this.txtDes.Multiline = true;
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(502, 164);
            this.txtDes.TabIndex = 5;
            // 
            // txtPr
            // 
            this.txtPr.Location = new System.Drawing.Point(225, 180);
            this.txtPr.Name = "txtPr";
            this.txtPr.Size = new System.Drawing.Size(136, 22);
            this.txtPr.TabIndex = 6;
            // 
            // txtLb
            // 
            this.txtLb.Location = new System.Drawing.Point(225, 126);
            this.txtLb.Name = "txtLb";
            this.txtLb.Size = new System.Drawing.Size(274, 22);
            this.txtLb.TabIndex = 7;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(285, 477);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(229, 99);
            this.addBtn.TabIndex = 8;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // cbSem
            // 
            this.cbSem.FormattingEnabled = true;
            this.cbSem.Location = new System.Drawing.Point(684, 63);
            this.cbSem.Name = "cbSem";
            this.cbSem.Size = new System.Drawing.Size(58, 24);
            this.cbSem.TabIndex = 9;
            // 
            // lbSemester
            // 
            this.lbSemester.AutoSize = true;
            this.lbSemester.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSemester.Location = new System.Drawing.Point(534, 54);
            this.lbSemester.Name = "lbSemester";
            this.lbSemester.Size = new System.Drawing.Size(139, 37);
            this.lbSemester.TabIndex = 10;
            this.lbSemester.Text = "Semester";
            // 
            // AddCourseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 625);
            this.Controls.Add(this.lbSemester);
            this.Controls.Add(this.cbSem);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.txtLb);
            this.Controls.Add(this.txtPr);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lbDes);
            this.Controls.Add(this.lbPr);
            this.Controls.Add(this.lbLabel);
            this.Controls.Add(this.lbId);
            this.Name = "AddCourseFrm";
            this.Text = "AddCourseFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbLabel;
        private System.Windows.Forms.Label lbPr;
        private System.Windows.Forms.Label lbDes;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.TextBox txtPr;
        private System.Windows.Forms.TextBox txtLb;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ComboBox cbSem;
        private System.Windows.Forms.Label lbSemester;
    }
}