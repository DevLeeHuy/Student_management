namespace WindowsFormsApp2
{
    partial class loginForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usernameTb = new System.Windows.Forms.TextBox();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.creAccLink = new System.Windows.Forms.LinkLabel();
            this.errorUName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPass = new System.Windows.Forms.ErrorProvider(this.components);
            this.mainPic = new System.Windows.Forms.PictureBox();
            this.gboxRole = new System.Windows.Forms.GroupBox();
            this.rbHuman = new System.Windows.Forms.RadioButton();
            this.rbStd = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorUName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPic)).BeginInit();
            this.gboxRole.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 69);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 331);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 416);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // usernameTb
            // 
            this.usernameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTb.Location = new System.Drawing.Point(248, 331);
            this.usernameTb.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTb.Multiline = true;
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.Size = new System.Drawing.Size(406, 49);
            this.usernameTb.TabIndex = 4;
            // 
            // passwordTb
            // 
            this.passwordTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTb.Location = new System.Drawing.Point(248, 409);
            this.passwordTb.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTb.Multiline = true;
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.Size = new System.Drawing.Size(406, 49);
            this.passwordTb.TabIndex = 5;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Red;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(62, 540);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(266, 74);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Chartreuse;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(404, 539);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(4);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(266, 74);
            this.loginBtn.TabIndex = 7;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // creAccLink
            // 
            this.creAccLink.AutoSize = true;
            this.creAccLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creAccLink.Location = new System.Drawing.Point(243, 678);
            this.creAccLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.creAccLink.Name = "creAccLink";
            this.creAccLink.Size = new System.Drawing.Size(206, 29);
            this.creAccLink.TabIndex = 8;
            this.creAccLink.TabStop = true;
            this.creAccLink.Text = "Create an account";
            this.creAccLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.creAccLink_LinkClicked);
            // 
            // errorUName
            // 
            this.errorUName.BlinkRate = 0;
            this.errorUName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorUName.ContainerControl = this;
            // 
            // errorPass
            // 
            this.errorPass.BlinkRate = 0;
            this.errorPass.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorPass.ContainerControl = this;
            // 
            // mainPic
            // 
            this.mainPic.Image = global::WindowsFormsApp2.Properties.Resources.User;
            this.mainPic.InitialImage = global::WindowsFormsApp2.Properties.Resources.User;
            this.mainPic.Location = new System.Drawing.Point(76, 63);
            this.mainPic.Margin = new System.Windows.Forms.Padding(4);
            this.mainPic.Name = "mainPic";
            this.mainPic.Size = new System.Drawing.Size(176, 160);
            this.mainPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainPic.TabIndex = 0;
            this.mainPic.TabStop = false;
            this.mainPic.Click += new System.EventHandler(this.mainPic_Click);
            // 
            // gboxRole
            // 
            this.gboxRole.Controls.Add(this.rbHuman);
            this.gboxRole.Controls.Add(this.rbStd);
            this.gboxRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxRole.Location = new System.Drawing.Point(248, 249);
            this.gboxRole.Name = "gboxRole";
            this.gboxRole.Size = new System.Drawing.Size(420, 75);
            this.gboxRole.TabIndex = 9;
            this.gboxRole.TabStop = false;
            this.gboxRole.Text = "Role👥";
            // 
            // rbHuman
            // 
            this.rbHuman.AutoSize = true;
            this.rbHuman.Location = new System.Drawing.Point(160, 36);
            this.rbHuman.Name = "rbHuman";
            this.rbHuman.Size = new System.Drawing.Size(246, 33);
            this.rbHuman.TabIndex = 1;
            this.rbHuman.TabStop = true;
            this.rbHuman.Text = "Human Resource👨‍💻";
            this.rbHuman.UseVisualStyleBackColor = true;
            // 
            // rbStd
            // 
            this.rbStd.AutoSize = true;
            this.rbStd.Location = new System.Drawing.Point(6, 36);
            this.rbStd.Name = "rbStd";
            this.rbStd.Size = new System.Drawing.Size(138, 33);
            this.rbStd.TabIndex = 0;
            this.rbStd.TabStop = true;
            this.rbStd.Text = "Student👨‍🎓";
            this.rbStd.UseVisualStyleBackColor = true;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 784);
            this.Controls.Add(this.gboxRole);
            this.Controls.Add(this.creAccLink);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.passwordTb);
            this.Controls.Add(this.usernameTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainPic);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "loginForm";
            this.Text = "18110018_Lê Quang Huy";
            this.Load += new System.EventHandler(this.loginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorUName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPic)).EndInit();
            this.gboxRole.ResumeLayout(false);
            this.gboxRole.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainPic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usernameTb;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.LinkLabel creAccLink;
        private System.Windows.Forms.ErrorProvider errorUName;
        private System.Windows.Forms.ErrorProvider errorPass;
        private System.Windows.Forms.GroupBox gboxRole;
        private System.Windows.Forms.RadioButton rbHuman;
        private System.Windows.Forms.RadioButton rbStd;
    }
}

