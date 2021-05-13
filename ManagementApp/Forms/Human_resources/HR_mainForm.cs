using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagementApp.model;

namespace ManagementApp.Forms.Human_resources
{
    public partial class HR_mainForm : Form
    {
        DataRow curUser = Globals.user;
        int uid;
        public HR_mainForm()
        {
            InitializeComponent();
            lbUser.Text = curUser["username"].ToString();
            lbname.Text = curUser["fname"].ToString() +" "+ curUser["lname"].ToString();
            MemoryStream img = new MemoryStream((byte[])curUser["img"]);
            avatar.Image = Image.FromStream(img);
            uid = curUser.Field<int>("id");
        }
         
        private void addCTbtn_Click(object sender, EventArgs e)
        {
            Form addContact = new addContact();
            addContact.ShowDialog();
        }

        private void editCtBtn_Click(object sender, EventArgs e)
        {
            Form editContact = new editContact();
            editContact.ShowDialog();
        }

        private void showCtBtn_Click(object sender, EventArgs e)
        {
            Form showContact = new fullContact();
            showContact.Show();
        }

        private void HR_mainForm_Load(object sender, EventArgs e)
        {
             cbEditGroup.DataSource = group.getListGroup(uid);
            cbEditGroup.DisplayMember = "name";
            cbEditGroup.ValueMember = "id";
            cbRemoveGroup.DataSource = group.getListGroup(uid);
            cbRemoveGroup.DisplayMember = "name";
            cbRemoveGroup.ValueMember = "id";

        }

        private void addGroupBtn_Click(object sender, EventArgs e)
        {
            string grName = txtGroupname.Text;
            //int grID = Convert.ToInt32(txtGroup_id.Text
            if(grName.Trim() != null)
            {
                if (!group.groupExist(grName, uid))
                {
                    if (group.insertGroup(grName, uid))
                    {
                        MessageBox.Show("Add successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Add unsuccessfully", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Can not add the group has been exist❗❗❗", "Group Exist⚠️⚠️⚠️", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please insert the group name❗❗❗", "⚠️⚠️⚠️", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            HR_mainForm_Load(sender, e);
        }

        private void EditGroupBtn_Click(object sender, EventArgs e)
        {
            int gid = Convert.ToInt32(cbEditGroup.SelectedValue);
            string newName = txtNewname.Text;
            if (newName.Trim() != null)
            {
                if (!group.groupExist(newName, uid))
                {
                    if (group.updateGroup(gid, newName))
                    {
                        txtNewname.Text = "";
                        MessageBox.Show("Update successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Update unsuccessfully", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Can not update the group name has been exist❗❗❗", "Group Exist⚠️⚠️⚠️", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please insert the group name❗❗❗", "⚠️⚠️⚠️", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            HR_mainForm_Load(sender, e);
        }
        private void removeGroupBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cbRemoveGroup.SelectedValue);
            DialogResult dialogResult = MessageBox.Show("Are you sure ???","⚠️Delete group", MessageBoxButtons.YesNo,MessageBoxIcon.Stop);
            if (dialogResult == DialogResult.Yes)
            {
                if (group.deleteGroup(id))
                {
                    MessageBox.Show("Delete successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Delete unsuccessfully", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
            
            HR_mainForm_Load(sender, e);
        }

        private void removeCtBtn_Click(object sender, EventArgs e)
        {
            Form editContact = new editContact();
            editContact.ShowDialog();
        }
    }
}
