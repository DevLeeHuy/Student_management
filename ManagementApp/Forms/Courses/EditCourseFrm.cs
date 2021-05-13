using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagementApp.DAO;
using ManagementApp.model;

namespace ManagementApp.Forms.Courses
{
    public partial class EditCourseFrm : Form
    {
        List<course> listCourse = courseDB.getAllCourse();
        public EditCourseFrm()
        {
            InitializeComponent();

            //show list course on select box
            cboxCourse.Items.Clear();
            cboxCourse.Items.Add("--Select--");
            foreach(course cou in listCourse)
            {
                cboxCourse.Items.Add(cou.Id);
            }
            cboxCourse.SelectedIndex = 0;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string label = txtLb.Text;
                int period = Convert.ToInt32(nudPr.Value);
                string des = txtDes.Text;
                course cou = new course(listCourse[cboxCourse.SelectedIndex - 1].Id, label, period, des);
                if (courseDB.updateCourse(cou))
                {
                    MessageBox.Show("Update successfully","Successful",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                 else
                    MessageBox.Show("Something was wrong!!!\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something was wrong!!!\n"+ex,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void cboxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cboxCourse.SelectedIndex;
            txtLb.Enabled = index != 0 ? true:false;
            txtDes.Enabled = index != 0 ? true : false;
            nudPr.Enabled = index != 0 ? true : false;
            editBtn.Enabled = index != 0 ? true : false;

            if (cboxCourse.SelectedIndex != 0)
            {
                course cou = listCourse[cboxCourse.SelectedIndex-1];
                txtLb.Text = cou.Label;
                txtDes.Text = cou.Description;
                nudPr.Value = cou.Period;
            }
            else
            {
                txtLb.Text = "";
                txtDes.Text = "";
                nudPr.Value = 0;
            }
        }

        private void EditCourseFrm_Load(object sender, EventArgs e)
        {
           
        }
    }
}
