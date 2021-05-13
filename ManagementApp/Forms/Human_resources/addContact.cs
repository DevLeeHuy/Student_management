using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.ComponentModel.DataAnnotations;
using System.IO;
using DevExpress.XtraLayout.Helpers;
using DevExpress.XtraLayout;
using ManagementApp.model;


namespace ManagementApp.Forms.Human_resources
{
    public partial class addContact : DevExpress.XtraEditors.XtraForm
    {
        int uid = Globals.user.Field<int>("id");
        public addContact()
        {
            InitializeComponent();
            cbGroups.DataSource = group.getListGroup(uid);
            cbGroups.DisplayMember = "name";
            cbGroups.ValueMember = "id";
        }
 
        private void upImgBtn_Click(object sender, EventArgs e)
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

        private void addContactBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string fname = txtFname.Text;
                string lname = txtLname.Text;
                string email = txtEmail.Text;
                string phone = txtPhone.Text;
                string address = txtAddress.Text;
                int gid = Convert.ToInt32(cbGroups.SelectedValue);

                //File.Copy(Avatar.ImageLocation, Path.Combine(Application.StartupPath + "\\Images\\", Path.GetFileName(Avatar.ImageLocation)), true);
                MemoryStream pic = new MemoryStream();
                Avatar.Image.Save(pic, Avatar.Image.RawFormat);
               
                if (contact.insertContact(fname,lname,phone,address,email,uid,gid,pic))
                {
                    MessageBox.Show("Add successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Can not add this contact", "Unsuccessful");
                }
                
            }
            catch
            {
                MessageBox.Show("Something was wrong!!!");
            }

        }
    }
}