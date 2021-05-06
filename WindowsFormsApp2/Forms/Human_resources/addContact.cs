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

namespace WindowsFormsApp2.Forms.Human_resources
{
    public partial class addContact : DevExpress.XtraEditors.XtraForm
    {
        public addContact()
        {
            InitializeComponent();

           
        }
        
        private void windowsUIButtonPanelMain_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void labelControl_Click(object sender, EventArgs e)
        {

        }
    }
}