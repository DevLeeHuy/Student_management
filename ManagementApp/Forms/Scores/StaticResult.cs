using ManagementApp.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementApp.Forms.Scores
{
    public partial class StaticResult : Form
    {
        public StaticResult()
        {
            InitializeComponent();
            cbSem.Items.Clear();
            for (int i = 1; i <= 3; i++)
            {
                cbSem.Items.Add(i);
            }
            cbSem.SelectedIndex = 0;
        }

        private void StaticResult_Load(object sender, EventArgs e)
        {
            gvAvgScore.DataSource = scoreDB.avgScore();            
            DataTable result = scoreDB.getListResult(Convert.ToInt32(cbSem.SelectedItem));
            var query = from row in result.AsEnumerable()
                        group row by row.Field<string>("Result") into rs
                        orderby rs.Key
                        select new
                        {
                            Type = rs.Key,
                            CountOfType = rs.Count()
                        };

            foreach(var type in query)
            {
                switch (type.Type)
                {
                    case "Rớt":
                        lbRot.Text = "RỚT: " + type.CountOfType.ToString();
                        break;
                    case "Trung bình":
                        lbRot.Text = "TRUNG BÌNH: " + type.CountOfType.ToString();
                        break;
                    case "Khá":
                        lbRot.Text = "kHÁ: " + type.CountOfType.ToString();
                        break;
                    case "Giỏi":
                        lbRot.Text = "GIỎI: " + type.CountOfType.ToString();
                        break;
                    case "Xuất sắc":
                        lbRot.Text = "XUẤT SẮC: " + type.CountOfType.ToString();
                        break;
                    default:
                        break;
                }
            }
        }

        private void cbSem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                StaticResult_Load(sender, e);
            }
            catch { }
        }
    }
}
