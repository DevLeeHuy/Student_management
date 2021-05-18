namespace ManagementApp.Forms.Scores
{
    partial class printScore
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
            this.lboxCourse = new System.Windows.Forms.ListBox();
            this.gvScore = new System.Windows.Forms.DataGridView();
            this.gvStd = new System.Windows.Forms.DataGridView();
            this.printBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStd)).BeginInit();
            this.SuspendLayout();
            // 
            // lboxCourse
            // 
            this.lboxCourse.FormattingEnabled = true;
            this.lboxCourse.Location = new System.Drawing.Point(12, 124);
            this.lboxCourse.Name = "lboxCourse";
            this.lboxCourse.Size = new System.Drawing.Size(235, 368);
            this.lboxCourse.TabIndex = 0;
            this.lboxCourse.SelectedIndexChanged += new System.EventHandler(this.lboxCourse_SelectedIndexChanged);
            // 
            // gvScore
            // 
            this.gvScore.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gvScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvScore.Location = new System.Drawing.Point(261, 61);
            this.gvScore.Name = "gvScore";
            this.gvScore.Size = new System.Drawing.Size(506, 431);
            this.gvScore.TabIndex = 1;
            // 
            // gvStd
            // 
            this.gvStd.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gvStd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStd.Location = new System.Drawing.Point(783, 124);
            this.gvStd.Name = "gvStd";
            this.gvStd.Size = new System.Drawing.Size(397, 368);
            this.gvStd.TabIndex = 2;
            this.gvStd.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvStd_CellDoubleClick);
            // 
            // printBtn
            // 
            this.printBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBtn.Location = new System.Drawing.Point(261, 524);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(506, 43);
            this.printBtn.TabIndex = 3;
            this.printBtn.Text = "PRINT SCORE";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GrayText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(13, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "List Course";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GrayText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(268, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "List Score";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GrayText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(791, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "List Student";
            // 
            // printScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 589);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.gvStd);
            this.Controls.Add(this.gvScore);
            this.Controls.Add(this.lboxCourse);
            this.Name = "printScore";
            this.Text = "printScore";
            this.Load += new System.EventHandler(this.printScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboxCourse;
        private System.Windows.Forms.DataGridView gvScore;
        private System.Windows.Forms.DataGridView gvStd;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}