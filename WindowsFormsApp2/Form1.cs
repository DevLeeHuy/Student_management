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
           mainPic.Image = Image.FromFile("F:\\Window\\Window\\WindowsFormsApp2\\Images\\User.jpg");
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            bool valid = checkAccount(usernameTb.Text, passwordTb.Text);
           
            if (valid)
            {
                MessageBox.Show("Wait for next week","SUCCESSFUL",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Invalid username or password","FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public Boolean checkAccount(string username, string password)
        {
            myDB db = new myDB();
            db.openConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM users WHERE username = @User AND password =@Pass", db.getConnection());
            command.Parameters.Add("@User", SqlDbType.VarChar).Value = usernameTb.Text;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = passwordTb.Text;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                db.closeConnection();
                return true;
            }
            db.closeConnection();
            return false;
        }

       
    }
}
