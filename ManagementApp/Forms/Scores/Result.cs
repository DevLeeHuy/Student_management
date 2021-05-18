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
using DevExpress.XtraReports.UI;
using System.Diagnostics;
using ManagementApp.DAO;
using Word = Microsoft.Office.Interop.Word;
using ManagementApp.Forms.Report;

namespace ManagementApp.Forms.Scores
{
    public partial class Result : XtraForm
    {
        DataTable tbResult = new DataTable();
        public Result()
        {
            InitializeComponent();
            
            cbSem.Items.Clear();
            for (int i = 1; i <= 3; i++)
            {
                cbSem.Items.Add(i);
            }
            cbSem.SelectedIndex = 0;
            gvResult.DataSource = scoreDB.getListResult(Convert.ToInt32(cbSem.SelectedItem));
            Binding();
        }
        void Binding()
        {
            txtId.DataBindings.Add("Text", gvResult.DataSource, "id");
            txtFname.DataBindings.Add("Text", gvResult.DataSource, "fname");
            txtLname.DataBindings.Add("Text", gvResult.DataSource, "lname");
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
            resultReport report = new resultReport();

            report.gridContainer.PrintableComponent = gvResult;

            ReportPrintTool preview = new ReportPrintTool(report);
            preview.ShowRibbonPreview();
           
        }

        private void cbSem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                gvResult.DataSource = null;
                gridView1.Columns.Clear();
                gvResult.DataSource = scoreDB.getListResult(Convert.ToInt32(cbSem.SelectedItem));
            }
            catch { }
        }
    }
}
