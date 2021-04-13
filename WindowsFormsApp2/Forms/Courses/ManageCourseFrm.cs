using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.DAO;
using WindowsFormsApp2.model;

namespace WindowsFormsApp2.Forms.Courses
{
    public partial class ManageCourseFrm : Form
    {
        public ManageCourseFrm()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(txtId.Text);
                string label = txtLb.Text;
                int period = Int32.Parse(txtPr.Text);
                string des = txtDes.Text;
                if (period > 10)
                {
                    if (courseDB.courseExist(label))
                    {
                        course newCourse = new course(id, label, period, des);
                        if (courseDB.insertCourse(newCourse))
                        {
                            MessageBox.Show("Add successfully");
                        }
                        else
                            MessageBox.Show("Something was Wrong!!!");
                    }
                    else
                    {
                        MessageBox.Show("Duplicated information!!");
                    }

                }
                else
                {
                    MessageBox.Show("Period need more than 10");
                }

            }
            catch
            {
                MessageBox.Show("Something was Wrong!!!");
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
             try
            {
                string label = txtLb.Text;
                int period = Convert.ToInt32(txtPr.Text);
                string des = txtDes.Text;
                int id = Int32.Parse(txtId.Text);
                course cou = new course(id, label, period, des);
                if (courseDB.updateCourse(cou))
                {
                    MessageBox.Show("Update successfully","Successful",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                 else
                    MessageBox.Show("Update failed!!!\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something was wrong!!!\n"+ex,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        void showListCourse(DataTable dt)
        {
            gvListCourse.DataSource = dt;
            gvListCourse.AllowUserToAddRows = false;
            showTotalCourse();
        }
        void showTotalCourse()
        {

            float total = gvListCourse.Rows.Count;
            lbTotal.Text = "Total students: " + total;

        }

        private void ManageCourseFrm_Load(object sender, EventArgs e)
        {
            showListCourse(courseDB.getListCourse());
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            DialogResult result = MessageBox.Show("Are you sure??", "Delete Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (courseDB.deleteCourse(id))
                {
                    MessageBox.Show("Delete successfully", "Successful", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Delete failed", "Failure", MessageBoxButtons.OK);
                }
            }
            else if (result == DialogResult.No)
            {
                //no...
            }
        }


    }
}
