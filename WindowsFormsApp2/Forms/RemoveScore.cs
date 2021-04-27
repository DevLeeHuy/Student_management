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

namespace WindowsFormsApp2.Forms
{
    public partial class RemoveScore : Form
    {
        int sid;
        int cid;
        public RemoveScore()
        {
            InitializeComponent();
            gvListScore.DataSource = scoreDB.getListScore();
            sid = Int32.Parse(gvListScore.Rows[0].Cells["sid"].Value.ToString());
            cid = Int32.Parse(gvListScore.Rows[0].Cells["cid"].Value.ToString());
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

        private void gvListScore_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            sid = Int32.Parse(gvListScore.CurrentRow.Cells["sid"].Value.ToString());
            cid = Int32.Parse(gvListScore.CurrentRow.Cells["cid"].Value.ToString());
        }

        private void gvListScore_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sid = Int32.Parse(gvListScore.CurrentRow.Cells["sid"].Value.ToString());
            cid = Int32.Parse(gvListScore.CurrentRow.Cells["cid"].Value.ToString());
        }
    }
}
