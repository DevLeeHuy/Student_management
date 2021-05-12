using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.DAO;
using WindowsFormsApp2.Forms;
using WindowsFormsApp2.Forms.Human_resources;

namespace WindowsFormsApp2
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

            

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            DataTable valid = userDB.checkAccount(usernameTb.Text, passwordTb.Text);
            RadioButton ckb = null;
            foreach (RadioButton item in gboxRole.Controls)
            {
                if (item != null)
                    if (item.Checked)
                    {
                        ckb = item;
                        break;
                    }
            }
            if (valid.Rows.Count > 0)
            {
                Globals.setUser(valid.Rows[0]);
                Form mainform = new Form();
                if(ckb.Text == "Student")
                {
                    mainform = new mainForm();
                }
                else
                {
                    mainform = new HR_mainForm();
                }
                
                this.Hide();
                mainform.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid username or password","FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorUName.SetError(usernameTb, "Please input your username");
                errorPass.SetError(passwordTb, "Please input your password");
            }
        }
       

        private void mainPic_Click(object sender, EventArgs e)
        {

        }

        private void creAccLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form regis = new RegisterUser();
            regis.ShowDialog();
        }
    }
}
