using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementApp
{
    public partial class frmStatistic : Form
    {
        float total;
        float male;
        float female;
        public frmStatistic()
        {
            InitializeComponent();
        }

        private void frmStatistic_Load(object sender, EventArgs e)
        {
            total = studentDB.getListStudent().Rows.Count;
            male = studentDB.Search("male").Rows.Count;
            female = total - male;

            lbTotal.Text = "Total students: " + total;
            lbMale.Text = "Male: " + (male/total)*100 + "%";
            lbFemale.Text = "Female: " + (female / total) * 100 + "%";
        }
    }
}
