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

namespace ManagementApp
{
    public partial class updateStdFrm : Form
    {
        public updateStdFrm()
        {
            InitializeComponent();
        }
        public updateStdFrm(int studentId)
        {
            InitializeComponent();
            txtId.Text = studentId.ToString();
            FindBtn_Click();
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

        private void FindBtn_Click(object sender = null, EventArgs e = null)
        {
            int id = Int32.Parse(txtId.Text);
            DataRow std = studentDB.getStdById(id);
            if (std != null)
            {
                txtLname.Text = std["lname"].ToString();
                txtFname.Text = std["fname"].ToString();
                txtAddress.Text = std["address"].ToString();
                txtPhone.Text = std["phone"].ToString();
                DateTime dt = std.Field<DateTime>("BirthDate");
                birthPicker.Value = dt;
                if (std["gender"].ToString() == "male")
                {
                    maleRaBtn.Checked = true;
                }
                else
                {
                    femaleRaBtn.Checked = true;
                }
                Avatar.Image = Image.FromStream(new MemoryStream((byte[])std["img"]));
            }
            else
            {
                MessageBox.Show( "Không tìm thấy sinh viên có mã " + id, "Không tìm thấy");
            }
        }

        private void upImgBtn_Click(object sender, EventArgs e)
        {
            try{
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
    }
}
