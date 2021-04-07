﻿using System;
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
    public partial class AddCourseFrm : Form
    {
        public AddCourseFrm()
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
                course newCourse = new course(id, label, period, des);
                if (courseDB.insertCourse(newCourse))
                {
                    MessageBox.Show("Add successfully");
                }
                else
                    MessageBox.Show("Something was Wrong!!!");
            }
            catch
            {
                MessageBox.Show("Something was Wrong!!!");
            }
        }
    }
}
