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

namespace WindowsFormsApp2.Forms.Register_Course
{
    public partial class RegisterCourse : Form
    {
        List<int> listCourses = new List<int>(); 
        public RegisterCourse()
        {
            InitializeComponent();
            lboxCou.DataSource = courseDB.getListCourse();
            //lboxCou.SelectedItem = "id";
            lboxCou.ValueMember = "id";
            lboxCou.DisplayMember = "label";

            lboxSelect.DisplayMember = "label";

            cbSem.Items.Clear();
            cbSem.Items.Add("--Select--");
            for (int i = 1; i<=3; i++)
            {
                cbSem.Items.Add(i);
            }
            cbSem.SelectedIndex = 0;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            listCourses.Add(Convert.ToInt32(lboxCou.SelectedValue));
            lboxSelect.Items.Add(lboxCou.SelectedItem);
        }
        private void delBtn_Click(object sender, EventArgs e)
        {
            listCourses.Remove(Convert.ToInt32(lboxSelect.SelectedValue));
            lboxSelect.Items.Remove(lboxCou.SelectedItem);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            int stdID = Convert.ToInt32(txtStdId.Text);
            int semester = Convert.ToInt32(cbSem.SelectedValue);
            int check = 0;
            foreach(int courseID in listCourses)
            {
                Score temp = new Score(stdID, courseID,-1, "");
                if (scoreDB.addScore(temp))
                {
                    check++;
                }
            }
            if (check == listCourses.Count)
            {
                MessageBox.Show("Save successfully 👌👌");
            }
            else
                MessageBox.Show("Can not save 😮😮");
            
        }
    }
}
