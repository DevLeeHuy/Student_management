namespace WindowsFormsApp2
{
    partial class frmInheritance
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
            this.lvData = new System.Windows.Forms.ListView();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.showBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvData
            // 
            this.lvData.HideSelection = false;
            this.lvData.Location = new System.Drawing.Point(12, 115);
            this.lvData.Name = "lvData";
            this.lvData.Size = new System.Drawing.Size(866, 534);
            this.lvData.TabIndex = 0;
            this.lvData.UseCompatibleStateImageBehavior = false;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(35, 29);
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(626, 59);
            this.txtPath.TabIndex = 1;
            this.txtPath.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(680, 29);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(178, 59);
            this.showBtn.TabIndex = 2;
            this.showBtn.Text = "show";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // frmInheritance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 670);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lvData);
            this.Name = "frmInheritance";
            this.Text = "frmInheritance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvData;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button showBtn;
    }
}