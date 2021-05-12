using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.ComponentModel.DataAnnotations;
using DevExpress.XtraBars;
using System.Diagnostics;
using WindowsFormsApp2.DAO;
using Word = Microsoft.Office.Interop.Word;


namespace WindowsFormsApp2.Forms.Scores
{
    public partial class Result : XtraForm
    {
        DataTable tbResult = new DataTable();
        public Result()
        {
            InitializeComponent();
           
            tbResult = scoreDB.getListResult();
            gvResult.DataSource = tbResult;           
        }
        void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Print")
                PrintResult();
            else
                this.Close();
        }
        void PrintResult()
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "Result.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                gvResult.ExportToDocx(sfd.FileName);
            }
        }
    }
}
