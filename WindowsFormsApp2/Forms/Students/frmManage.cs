using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Forms
{
    public partial class frmManage : Form
    {
        public frmManage()
        {
            InitializeComponent();
        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            student std = studentDB.getStdById(id);
            if (std != null)
            {
                txtLname.Text = std.LastName;
                txtFname.Text = std.FirstName;
                txtAddress.Text = std.Address;
                txtPhone.Text = std.Phone;
                birthPicker.Value = std.BirthDate;
                if (std.Gender == "male")
                {
                    maleRaBtn.Checked = true;
                }
                else
                {
                    femaleRaBtn.Checked = true;
                }
                Avatar.Image = Image.FromStream(std.Img);
            }
            else
            {
                MessageBox.Show("Không tìm thấy sinh viên có mã " + id, "Không tìm thấy");
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string fname = txtFname.Text;
            string lname = txtLname.Text;
            int id = Int32.Parse(txtId.Text);
            DateTime birth = birthPicker.Value;

            int bornYear = birthPicker.Value.Year;
            int thisYear = DateTime.Now.Year;
            if (thisYear - bornYear < 10 || thisYear - bornYear > 100)
            {
                MessageBox.Show("The student age must be between 10 and 100 years old", "Invalid birth date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string phone = txtPhone.Text;
                string address = txtAddress.Text;


                //File.Copy(Avatar.ImageLocation, Path.Combine(Application.StartupPath + "\\Images\\", Path.GetFileName(Avatar.ImageLocation)), true);
                MemoryStream pic = new MemoryStream();
                Avatar.Image.Save(pic, Avatar.Image.RawFormat);
                RadioButton ckb = null;
                foreach (RadioButton item in genderBox.Controls)
                {
                    if (item != null)
                        if (item.Checked)
                        {
                            ckb = item;
                            break;
                        }
                }
                string gender = ckb.Text == "male" ? "male" : "female";
                student newStudent = new student(id, fname, lname, birth, phone, address, gender, pic);
                if (studentDB.updateStudent(newStudent))
                {
                    MessageBox.Show("Done", "Update successfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Something wrong ", "Unsuccessful");
                }
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            if (studentDB.deleteStudent(id))
            {
                MessageBox.Show("Done", "Remove successfully");
                this.Close();
            }
            else
            {
                MessageBox.Show("Something wrong ", "Unsuccessful");
            }
        }

        private void upImgBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String imageLocation = "";
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                }
                Avatar.ImageLocation = imageLocation;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Upload image unsuccessfully!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            showTotalStd();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            showListStudent(studentDB.Search(txtSearch.Text));
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FindBtn_Click(null, null);
        }

        private void gvListStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = gvListStudent.CurrentRow.Cells[0].Value.ToString();
            FindBtn_Click(null, null);
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string fname = txtFname.Text;
                string lname = txtLname.Text;
                int id = Int32.Parse(txtId.Text);
                DateTime birth = birthPicker.Value;

                int bornYear = birthPicker.Value.Year;
                int thisYear = DateTime.Now.Year;
                if (thisYear - bornYear < 10 || thisYear - bornYear > 100)
                {
                    MessageBox.Show("The student age must be between 10 and 100 years old", "Invalid birth date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string phone = txtPhone.Text;
                    string address = txtAddress.Text;


                    //File.Copy(Avatar.ImageLocation, Path.Combine(Application.StartupPath + "\\Images\\", Path.GetFileName(Avatar.ImageLocation)), true);
                    MemoryStream pic = new MemoryStream();
                    Avatar.Image.Save(pic, Avatar.Image.RawFormat);
                    RadioButton ckb = null;
                    foreach (RadioButton item in genderBox.Controls)
                    {
                        if (item != null)
                            if (item.Checked)
                            {
                                ckb = item;
                                break;
                            }
                    }
                    string gender = ckb.Text == "male" ? "male" : "female";
                    student newStudent = new student(id, fname, lname, birth, phone, address, gender, pic);
                    if (studentDB.insertStudent(newStudent))
                    {
                        MessageBox.Show("Done", "Add successfully");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Something wrong ", "Unsuccessful");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Something was wrong!!!");
            }
        }

        private void frmManage_Load(object sender, EventArgs e)
        {
            showTotalStd();
        }
        void showTotalStd()
        {
            
                float total = gvListStudent.Rows.Count;
                lbTotal.Text = "Total students: " + total;
            
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = ("student_" + txtId.Text);
            if(Avatar.Image == null)
            {
                MessageBox.Show("NO image in the picturebox");
            }
            else if (svf.ShowDialog() == DialogResult.OK)
            {
                Avatar.Image.Save(svf.FileName + ("." + ImageFormat.Jpeg.ToString()));
                MessageBox.Show("Save successful"+ svf.FileName + ("." + ImageFormat.Jpeg.ToString()));
            }
        }

        private void lbTotal_Click(object sender, EventArgs e)
        {

        }

        private void pnTotal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
