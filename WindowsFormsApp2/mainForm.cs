using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            updateStdFrm edit = new updateStdFrm(gvListStudent.CurrentRow.Cells[0].Value.ToString());    
            
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
    }
}
