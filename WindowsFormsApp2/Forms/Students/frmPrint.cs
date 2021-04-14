using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
namespace WindowsFormsApp2
{
    public partial class frmPrint : Form
    {
        public frmPrint()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            DataTable result;
            RadioButton ckb = null;
            string gender = "ALL";
            foreach (RadioButton item in genderBox.Controls)
            {
                if (item != null)
                    if (item.Checked)
                    {
                        ckb = item;
                        break;
                    }
            }
            if(ckb != null&& ckb.Text != "ALL")
                gender = ckb.Text == "Male" ? "male" : "female";
            if (gender != "ALL")
                result = studentDB.Search(gender);
            else
                result = studentDB.getListStudent();
            showListStudent(result);
            ckb = null;
            foreach (RadioButton item in gbConfirm.Controls)
            {
                if (item != null)
                    if (item.Checked)
                    {
                        ckb = item;
                        break;
                    }
            }
            if (ckb != null)
            {
                bool isBirthRange = ckb.Text == "YES" ? true : false;
                if (isBirthRange) 
                { 
                    DateTime fromDt = dtFrom.Value;
                    DateTime toDt = dtTo.Value;
                    if (fromDt < toDt)
                    {
                        //gvStudent.DataSource = studentDB.getStdByBirth(fromDt, toDt);
                         result = result.AsEnumerable().Intersect(studentDB.getStdByBirth(fromDt, toDt).AsEnumerable(), DataRowComparer.Default).CopyToDataTable();
                        showListStudent(result);
                    }
                    else
                    {
                        gvStudent.DataSource = null;
                        MessageBox.Show("Wrong Birth date range!!!!");
                    }               
                }

            }
        }
        void showListStudent(DataTable dt)
        {
            gvStudent.DataSource = dt;
            DataGridViewImageColumn picInList = (DataGridViewImageColumn)gvStudent.Columns["img"];
            picInList.ImageLayout = DataGridViewImageCellLayout.Stretch;
            gvStudent.AllowUserToAddRows = false;
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "export.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Export_Data_To_Word(gvStudent, sfd.FileName);
            }
        }
        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count + 1;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                //add rows
                int r = 0;
                
                for ( r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        if (c == 0)
                            DataArray[r, c] = r+1; //cot stt             
                        else
                            DataArray[r, c] = DGV.Rows[r].Cells[c-1].Value;
                    } //end row loop
                } //end column loop
                //DataArray[0, 0] = "STT"; //Them cot stt
          
               
                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;

                //page orintation
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;


                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                Object oMissing = System.Reflection.Missing.Value;
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        if (c != 7)
                            oTemp = oTemp + DataArray[r, c] + "\t";
                        else
                            oTemp = oTemp + " " + "\t";
                    }
                }

                //table format
                oRange.Text = oTemp;

                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                
                
               //header row style
               oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                //add header row manually
                for (int c = 1; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c-1].HeaderText;
                }
                oDoc.Application.Selection.Tables[1].Cell(1, 1).Range.Text = "STT";


                //table style 
                oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                //header text
                foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                    headerRange.Text = "Student list table";
                    headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                //save images
                for (r = 0; r <= RowCount - 1; r++)
                {
                    byte[] imgbyte = (byte[])gvStudent.Rows[r].Cells[7].Value;
                    MemoryStream ms = new MemoryStream(imgbyte);
                    Image finalPic = (Image)(new Bitmap(Image.FromStream(ms), new Size(70, 70)));
                    Clipboard.SetDataObject(finalPic);
                    oDoc.Application.Selection.Tables[1].Cell(r+2, ColumnCount).Range.Paste();
                    oDoc.Application.Selection.Tables[1].Cell(r+2, ColumnCount).Range.InsertParagraph();
                }
                //save the file
                oDoc.SaveAs(filename);

            }
        }




   

    }
}
