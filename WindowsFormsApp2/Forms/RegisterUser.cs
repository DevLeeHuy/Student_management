using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.DAO;
using WindowsFormsApp2.model;

namespace WindowsFormsApp2.Forms
{
    public partial class RegisterUser : Form
    {
        public RegisterUser()
        {
            InitializeComponent();
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String imageLocation = "";
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                }
                Avatar.ImageLocation = imageLocation;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Upload image unsuccessfully!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void regisBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string fname = txtFname.Text;
                string lname = txtLname.Text;
                string username = txtUname.Text;
                string pass = txtPass.Text;  
                    //File.Copy(Avatar.ImageLocation, Path.Combine(Application.StartupPath + "\\Images\\", Path.GetFileName(Avatar.ImageLocation)), true);
                    MemoryStream pic = new MemoryStream();
                    Avatar.Image.Save(pic, Avatar.Image.RawFormat);
                user newUser = new user(fname, lname, pass, username, pic);
                   
                    if (userDB.insertUser(newUser))
                    {
                        MessageBox.Show("Done", "Add successfully");
                    }
                    else
                    {
                        MessageBox.Show("Can not add user ", "Unsuccessful");
                    }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something was wrong!!! " +ex);
            }

        }
    }
}
