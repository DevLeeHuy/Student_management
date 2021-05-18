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
    public partial class AddCourseFrm : Form
    {
        public AddCourseFrm()
        {
            InitializeComponent();
            cbSem.Items.Clear();
            cbSem.Items.Add("--Select--");
            for (int i = 1; i <= 3; i++)
            {
                cbSem.Items.Add(i);
            }
            cbSem.SelectedIndex = 0;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(txtId.Text);
                string label = txtLb.Text;
                int period = Int32.Parse(txtPr.Text);
                string des = txtDes.Text;
                int semester = Convert.ToInt32(cbSem.SelectedItem);
                if (period > 10)
                {
                    if (!courseDB.courseExist(label))
                    {
                        course newCourse = new course(id, label, period, des, semester);
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
    }
}
