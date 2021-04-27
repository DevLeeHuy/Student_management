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

namespace WindowsFormsApp2.Forms.Scores
{
    public partial class AvgScore : Form
    {
        public AvgScore()
        {
            InitializeComponent();
        }

        private void AvgScore_Load(object sender, EventArgs e)
        {
            gvAvgScore.DataSource = scoreDB.avgScore();
        }
    }
}
