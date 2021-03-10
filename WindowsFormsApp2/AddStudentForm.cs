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
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string fname = txtFname.Text;
                string lname = txtLname.Text;
                string id = txtId.Text;
                string birth = birthPicker.Text.ToString();

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
            catch(Exception ex)
            {
                MessageBox.Show("Upload image unsuccessfully!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
