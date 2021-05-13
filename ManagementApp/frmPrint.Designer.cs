namespace WindowsFormsApp2
{
    partial class frmPrint
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
            this.gvStudent = new System.Windows.Forms.DataGridView();
            this.genderBox = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.birthRange = new System.Windows.Forms.GroupBox();
            this.gbConfirm = new System.Windows.Forms.GroupBox();
            this.rdNo = new System.Windows.Forms.RadioButton();
            this.rdYes = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudent)).BeginInit();
            this.genderBox.SuspendLayout();
            this.birthRange.SuspendLayout();
            this.gbConfirm.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvStudent
            // 
            this.gvStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvStudent.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStudent.Location = new System.Drawing.Point(13, 124);
            this.gvStudent.Name = "gvStudent";
            this.gvStudent.RowHeadersWidth = 51;
            this.gvStudent.RowTemplate.Height = 80;
            this.gvStudent.Size = new System.Drawing.Size(881, 314);
            this.gvStudent.TabIndex = 0;
            // 
            // genderBox
            // 
            this.genderBox.Controls.Add(this.rbFemale);
            this.genderBox.Controls.Add(this.rbMale);
            this.genderBox.Controls.Add(this.rbAll);
            this.genderBox.Location = new System.Drawing.Point(13, 32);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(243, 64);
            this.genderBox.TabIndex = 1;
            this.genderBox.TabStop = false;
            this.genderBox.Text = "Gender";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(162, 21);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(75, 21);
            this.rbFemale.TabIndex = 2;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(82, 21);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(59, 21);
            this.rbMale.TabIndex = 1;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(11, 21);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(54, 21);
            this.rbAll.TabIndex = 0;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "ALL";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // birthRange
            // 
            this.birthRange.Controls.Add(this.gbConfirm);
            this.birthRange.Controls.Add(this.label2);
            this.birthRange.Controls.Add(this.dtTo);
            this.birthRange.Controls.Add(this.dtFrom);
            this.birthRange.Controls.Add(this.label1);
            this.birthRange.Controls.Add(this.lb);
            this.birthRange.Location = new System.Drawing.Point(263, 13);
            this.birthRange.Name = "birthRange";
            this.birthRange.Size = new System.Drawing.Size(404, 105);
            this.birthRange.TabIndex = 2;
            this.birthRange.TabStop = false;
            this.birthRange.Text = "Birth Range";
            // 
            // gbConfirm
            // 
            this.gbConfirm.Controls.Add(this.rdNo);
            this.gbConfirm.Controls.Add(this.rdYes);
            this.gbConfirm.Location = new System.Drawing.Point(161, 10);
            this.gbConfirm.Name = "gbConfirm";
            this.gbConfirm.Size = new System.Drawing.Size(168, 41);
            this.gbConfirm.TabIndex = 7;
            this.gbConfirm.TabStop = false;
            // 
            // rdNo
            // 
            this.rdNo.AutoSize = true;
            this.rdNo.Location = new System.Drawing.Point(100, 20);
            this.rdNo.Name = "rdNo";
            this.rdNo.Size = new System.Drawing.Size(50, 21);
            this.rdNo.TabIndex = 3;
            this.rdNo.TabStop = true;
            this.rdNo.Text = "NO";
            this.rdNo.UseVisualStyleBackColor = true;
            // 
            // rdYes
            // 
            this.rdYes.AutoSize = true;
            this.rdYes.Location = new System.Drawing.Point(23, 20);
            this.rdYes.Name = "rdYes";
            this.rdYes.Size = new System.Drawing.Size(56, 21);
            this.rdYes.TabIndex = 2;
            this.rdYes.TabStop = true;
            this.rdYes.Text = "YES";
            this.rdYes.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "And";
            // 
            // dtTo
            // 
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo.Location = new System.Drawing.Point(298, 66);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(92, 22);
            this.dtTo.TabIndex = 5;
            // 
            // dtFrom
            // 
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(161, 66);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(92, 22);
            this.dtFrom.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "BirthDate between";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(30, 22);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(114, 17);
            this.lb.TabIndex = 0;
            this.lb.Text = "Use date range: ";
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.LightCoral;
            this.btnCheck.Location = new System.Drawing.Point(673, 39);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(104, 48);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "CHECK";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // saveFile
            // 
            this.saveFile.BackColor = System.Drawing.Color.DarkOrange;
            this.saveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveFile.Location = new System.Drawing.Point(191, 477);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(216, 48);
            this.saveFile.TabIndex = 4;
            this.saveFile.Text = "Save to file";
            this.saveFile.UseVisualStyleBackColor = false;
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSalmon;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.AliceBlue;
            this.button2.Location = new System.Drawing.Point(414, 477);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 48);
            this.button2.TabIndex = 5;
            this.button2.Text = "To printer";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // frmPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(906, 561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.saveFile);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.birthRange);
            this.Controls.Add(this.genderBox);
            this.Controls.Add(this.gvStudent);
            this.Name = "frmPrint";
            this.Text = "frmPrint";
            ((System.ComponentModel.ISupportInitialize)(this.gvStudent)).EndInit();
            this.genderBox.ResumeLayout(false);
            this.genderBox.PerformLayout();
            this.birthRange.ResumeLayout(false);
            this.birthRange.PerformLayout();
            this.gbConfirm.ResumeLayout(false);
            this.gbConfirm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvStudent;
        private System.Windows.Forms.GroupBox genderBox;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.GroupBox birthRange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.RadioButton rdNo;
        private System.Windows.Forms.RadioButton rdYes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button saveFile;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gbConfirm;
    }
}