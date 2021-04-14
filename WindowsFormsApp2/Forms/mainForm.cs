using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Forms;
using WindowsFormsApp2.Forms.Courses;

namespace WindowsFormsApp2
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            btnRefresh.Hide();
            
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form addStudent = new AddStudentForm();
            addStudent.ShowDialog();

        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showListStudent(studentDB.getListStudent());
           

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            showListStudent(studentDB.getListStudent());
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            showListStudent(studentDB.Search(txtSearch.Text));
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            showListStudent(studentDB.Search(txtSearch.Text));
        }

        void showListStudent(DataTable dt)
        {
            gvListStudent.DataSource = dt;
            DataGridViewImageColumn picInList = (DataGridViewImageColumn)gvListStudent.Columns["img"];
            picInList.ImageLayout = DataGridViewImageCellLayout.Stretch;
            gvListStudent.AllowUserToAddRows = false;
            btnRefresh.Show();
        }

        private void editRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form edit = new updateStdFrm();
            edit.ShowDialog();
        }

        private void gvListStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            updateStdFrm edit = new updateStdFrm(Convert.ToInt32(gvListStudent.CurrentRow.Cells[0].Value));    
            
            edit.ShowDialog();
        }

        private void staticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form statistic = new frmStatistic();
            statistic.Show();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form print = new frmPrint();
            print.Show();
        }

        private void manageStudentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form manage = new frmManage();
            manage.ShowDialog();
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form add = new AddCourseFrm();
            add.ShowDialog();
        }

        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form edit = new EditCourseFrm();
            edit.ShowDialog();
        }

        private void deleteCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form delete = new DeleteCourseFrm();
            delete.ShowDialog();
        }

        private void manageCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form manage = new ManageCourseFrm();
            manage.ShowDialog();
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form print = new PrintCourseFrm();
            print.ShowDialog();
        }
    }
}
