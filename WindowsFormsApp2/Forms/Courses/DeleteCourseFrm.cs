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

namespace WindowsFormsApp2.Forms.Courses
{
    public partial class DeleteCourseFrm : Form
    {
        public DeleteCourseFrm()
        {
            InitializeComponent();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            DialogResult result = MessageBox.Show("Are you sure??", "Delete Course", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
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
