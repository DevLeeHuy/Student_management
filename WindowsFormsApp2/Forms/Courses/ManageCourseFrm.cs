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
using WindowsFormsApp2.model;
using Word = Microsoft.Office.Interop.Word;

namespace WindowsFormsApp2.Forms.Courses
{
    public partial class ManageCourseFrm : Form
    {
        public ManageCourseFrm()
        {
            InitializeComponent();
            showListCourse(courseDB.getListCourse());
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(txtId.Text);
                string label = txtLb.Text;
                int period = Int32.Parse(txtPr.Text);
                string des = txtDes.Text;
                if (period > 10)
                {
                    if (courseDB.courseExist(label))
                    {
                        course newCourse = new course(id, label, period, des);
                        if (courseDB.insertCourse(newCourse))
                        {
                            MessageBox.Show("Add successfully");
                        }
                        else
                            MessageBox.Show("Something was Wrong!!!");
                    }
                    else
                    {
                        MessageBox.Show("Duplicated information!!");
                    }

                }
                else
                {
                    MessageBox.Show("Period need more than 10");
                }

            }
            catch
            {
                MessageBox.Show("Something was Wrong!!!");
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
             try
            {
                string label = txtLb.Text;
                int period = Convert.ToInt32(txtPr.Text);
                string des = txtDes.Text;
                int id = Int32.Parse(txtId.Text);
                course cou = new course(id, label, period, des);
                if (courseDB.updateCourse(cou))
                {
                    MessageBox.Show("Update successfully","Successful",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                 else
                    MessageBox.Show("Update failed!!!\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something was wrong!!!\n"+ex,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        void showListCourse(DataTable dt)
        {
            lboxCourse.DataSource = dt;
            lboxCourse.ValueMember = "id";
            lboxCourse.DisplayMember = "label";
            showTotalCourse();
        }
        void showListStudent(DataTable dt)
        {
            gvListStudent.DataSource = dt;
            gvListStudent.AllowUserToAddRows = false;
            showTotalStudent();
        }
        void showTotalCourse()
        {

            float total = lboxCourse.Items.Count;
            lbTotal.Text = "Total courses: " + total;

        }
        void showTotalStudent()
        {

            float total = gvListStudent.Rows.Count;
            lbStudent.Text = "Total students: " + total;

        }

        private void ManageCourseFrm_Load(object sender, EventArgs e)
        {
            showListCourse(courseDB.getListCourse());
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            DialogResult result = MessageBox.Show("Are you sure??", "Delete Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void listStdBtn_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            showListStudent(courseDB.getListStudy(id));
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "export.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Export_Data_To_Word(gvListStudent, sfd.FileName);
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

                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        if (c == 0)
                            DataArray[r, c] = r + 1; //cot stt             
                        else
                            DataArray[r, c] = DGV.Rows[r].Cells[c - 1].Value;
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
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c - 1].HeaderText;
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
                    headerRange.Text = "Điểm quá Trình";
                    headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                oDoc.Application.Selection.Paragraphs.Add("Tên môn");

                //save images
                
                //save the file
                oDoc.SaveAs(filename);

            }
        }
        int couID;
        private void preBtn_Click(object sender, EventArgs e)
        {
            if(lboxCourse.SelectedIndex != 0)
            lboxCourse.SelectedIndex = lboxCourse.SelectedIndex - 1;
            couID = Int32.Parse(lboxCourse.SelectedValue.ToString());
        }

        private void firstBtn_Click(object sender, EventArgs e)
        {
            lboxCourse.SelectedIndex = 0;
            couID = Int32.Parse(lboxCourse.SelectedValue.ToString());
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (lboxCourse.SelectedIndex != lboxCourse.Items.Count)
                lboxCourse.SelectedIndex = lboxCourse.SelectedIndex - 1;
            couID = Int32.Parse(lboxCourse.SelectedValue.ToString());
        }

        private void lastBtn_Click(object sender, EventArgs e)
        {
            lboxCourse.SelectedIndex = lboxCourse.Items.Count;
            couID = Int32.Parse(lboxCourse.SelectedValue.ToString());
        }
       
        private void fillData(course c)
        {
            txtId.Text = c.Id.ToString();
            txtLb.Text = c.Label;
            txtDes.Text = c.Description;
            txtPr.Text = c.Period.ToString();
        }
    }
}
