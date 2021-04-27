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

namespace WindowsFormsApp2.Forms.Scores
{
    public partial class AddScore : Form
    {
        public AddScore()
        {
            InitializeComponent();
            cboxCourse.DataSource = courseDB.getListCourse();
            cboxCourse.DisplayMember = "label";
            cboxCourse.ValueMember = "id";
           
            showListStudent(studentDB.getListStudent());
        }
        void showListStudent(DataTable dt)
        {
            gvListStudent.DataSource = dt;
            gvListStudent.AllowUserToAddRows = false;
            showTotalStudent();
        }

        void showTotalStudent()
        {

            float total = gvListStudent.Rows.Count;
            lbStudent.Text = "Total students: " + total;

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int sid = Int32.Parse(txtId.Text);
                int cid = Convert.ToInt32(cboxCourse.SelectedValue);
                float score = float.Parse(txtScore.Text);
                string des = txtDes.Text;
                Score s = new Score(sid, cid, score, des);
                if (scoreDB.addScore(s))
                {
                    MessageBox.Show("Add successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Add failed!!!\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Học sinh đã có điểm" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        private void gvListStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = gvListStudent.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
