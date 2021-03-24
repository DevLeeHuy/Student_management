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

namespace WindowsFormsApp2
{
    public partial class updateStdFrm : Form
    {
        public updateStdFrm()
        {
            InitializeComponent();
        }
        public updateStdFrm(string studentId)
        {
            InitializeComponent();
            txtId.Text = studentId;
            FindBtn_Click();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string fname = txtFname.Text;
            string lname = txtLname.Text;
            string id = txtId.Text;
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
            string id = txtId.Text;
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
            string id = txtId.Text;
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
                MessageBox.Show( "Không tìm thấy sinh viên có mã " + id, "Không tìm thấy");
            }
        }
    }
}
