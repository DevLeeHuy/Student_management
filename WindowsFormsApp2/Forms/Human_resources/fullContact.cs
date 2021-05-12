using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.model;

namespace WindowsFormsApp2.Forms.Human_resources
{
    public partial class fullContact : Form
    {
        int uid = Globals.user.Field<int>("id");
        public fullContact()
        {
            InitializeComponent();
            lboxGroup.DataSource = group.getListGroup(uid);
            lboxGroup.DisplayMember = "name";
            lboxGroup.ValueMember = "id";
        }

        private void fullContact_Load(object sender, EventArgs e)
        {
        }

        private void lboxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                gvContact.DataSource = contact.getListContactByGroup(uid, Convert.ToInt32(lboxGroup.SelectedValue));
            }
            catch { }
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            gvContact.DataSource = contact.getListContact(uid);
        }
    }
}
