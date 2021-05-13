namespace ManagementApp.Forms.Human_resources
{
    partial class fullContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fullContact));
            this.gvContact = new System.Windows.Forms.DataGridView();
            this.lboxGroup = new DevExpress.XtraEditors.ListBoxControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.showBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gvContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lboxGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // gvContact
            // 
            this.gvContact.AllowUserToAddRows = false;
            this.gvContact.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvContact.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvContact.Location = new System.Drawing.Point(215, 94);
            this.gvContact.Name = "gvContact";
            this.gvContact.RowTemplate.Height = 80;
            this.gvContact.Size = new System.Drawing.Size(573, 283);
            this.gvContact.TabIndex = 0;
            // 
            // lboxGroup
            // 
            this.lboxGroup.Location = new System.Drawing.Point(13, 94);
            this.lboxGroup.Name = "lboxGroup";
            this.lboxGroup.Size = new System.Drawing.Size(185, 283);
            this.lboxGroup.TabIndex = 1;
            this.lboxGroup.SelectedIndexChanged += new System.EventHandler(this.lboxGroup_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(13, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(108, 25);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Full contact";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(13, 63);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 25);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Group";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(215, 63);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(98, 25);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "All contact";
            // 
            // showBtn
            // 
            this.showBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("showBtn.ImageOptions.Image")));
            this.showBtn.Location = new System.Drawing.Point(340, 63);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(99, 24);
            this.showBtn.TabIndex = 5;
            this.showBtn.Text = "Show full";
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // fullContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lboxGroup);
            this.Controls.Add(this.gvContact);
            this.Name = "fullContact";
            this.Text = "fullContact";
            this.Load += new System.EventHandler(this.fullContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lboxGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvContact;
        private DevExpress.XtraEditors.ListBoxControl lboxGroup;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton showBtn;
    }
}