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
using WindowsFormsApp2.model;
using System.Diagnostics;

namespace WindowsFormsApp2.Forms.Human_resources
{
    public partial class editContact : DevExpress.XtraEditors.XtraForm
    {
        int uid = Globals.user.Field<int>("id");
        public editContact()
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



        private void editContact_Load(object sender, EventArgs e)
        {
            gvContacts.DataSource = contact.getListContact(Globals.user.Field<int>("id"));
        }

        private void gvContacts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection contact = gvContacts.CurrentRow.Cells;
            txtId.Text = contact["id"].Value.ToString();
            txtFname.Text = contact["fname"].Value.ToString();
            txtLname.Text = contact["lname"].Value.ToString();
            txtEmail.Text = contact["email"].Value.ToString();
            txtPhone.Text = contact["phone"].Value.ToString();
            txtAddress.Text = contact["address"].Value.ToString();
            cbGroups.SelectedValue = contact["gid"].Value;
            byte[] pic = (byte[])contact["img"].Value;
            MemoryStream picture = new MemoryStream(pic);
            Avatar.Image = Image.FromStream(picture);

        }

        private void HandleBar_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            string cmd = e.Button.Properties.Caption.ToString();
            if(cmd == "Save")
            {
                edit_contact();
            }
            else if(cmd == "Delete"){
                delete_contact();
            }
            editContact_Load(sender, e);

        }
        private void edit_contact()
        {
            try
            {
                string fname = txtFname.Text;
                string lname = txtLname.Text;
                string email = txtEmail.Text;
                string phone = txtPhone.Text;
                string address = txtAddress.Text;
                int gid = Convert.ToInt32(cbGroups.SelectedValue);
                int contactID = Convert.ToInt32(txtId.Text);

                //File.Copy(Avatar.ImageLocation, Path.Combine(Application.StartupPath + "\\Images\\", Path.GetFileName(Avatar.ImageLocation)), true);
                MemoryStream pic = new MemoryStream();
                Avatar.Image.Save(pic, Avatar.Image.RawFormat);

                if (contact.updateContact(contactID, fname, lname, phone, address, email, gid, pic))
                {
                    MessageBox.Show("Edit contact successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Can not edit this contact", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something was wrong!!! " + ex.Message);
            }
        }
        private void delete_contact()
        {
            try
            { 
                DialogResult dialogResult = MessageBox.Show("Are you sure ???", "⚠️Delete contact", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (dialogResult == DialogResult.Yes)
                {
                    int contactID = Convert.ToInt32(txtId.Text);
                    if (contact.deleteContact(contactID))
                    {
                        MessageBox.Show("Delete contact successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Can not delete this contact", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something was wrong!!! " + ex.Message);
            }
        }

        private void cbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                gvContacts.DataSource = contact.getListContactByGroup(uid, Convert.ToInt32(cbGroups.SelectedValue));
            }
            catch { }
        }
    }
}