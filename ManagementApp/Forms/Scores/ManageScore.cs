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

namespace ManagementApp.Forms.Scores
{
    public partial class ManageScore : Form
    {
        int sid;
        int cid;
        public ManageScore()
        {
            InitializeComponent();
            cboxCourse.DataSource = courseDB.getListCourse();
            cboxCourse.DisplayMember = "label";
            cboxCourse.ValueMember = "id";
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

        private void avgBtn_Click(object sender, EventArgs e)
        {
            Form avg = new AvgScore();
            avg.ShowDialog();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {

            if (scoreDB.deleteScore(sid, cid))
            {
                MessageBox.Show("Delete successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Delete failed!!!\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            gvListScore.DataSource = scoreDB.getListScore();
        }

        private void gvListScore_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                sid = Int32.Parse(gvListScore.CurrentRow.Cells["sid"].Value.ToString());
                cid = Int32.Parse(gvListScore.CurrentRow.Cells["cid"].Value.ToString());
            }
            catch { }
           
        }

        private void showStdBtn_Click(object sender, EventArgs e)
        {
            gvListScore.DataSource = studentDB.getListStudent();
        }

        private void showSBtn_Click(object sender, EventArgs e)
        {
            gvListScore.DataSource = scoreDB.getListScore();
        }

        private void gvListScore_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = gvListScore.CurrentRow.Cells[0].Value.ToString();
            float score = float.Parse(gvListScore.CurrentRow.Cells["score"].Value.ToString());
            txtScore.Text = score.ToString();

            txtDes.Text = gvListScore.CurrentRow.Cells["description"].Value.ToString();
        }

        private void cboxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                showListStudent(courseDB.getListStudy(Convert.ToInt32(cboxCourse.SelectedValue)));
            }
            catch { }
        }
        void showListStudent(DataTable dt)
        {
            gvListScore.DataSource = dt;
            gvListScore.AllowUserToAddRows = false;
        }


    }
}
