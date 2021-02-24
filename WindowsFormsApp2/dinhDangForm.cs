using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class dinhDangForm : Form
    {
        public dinhDangForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new Form2();
            frm.IsMdiContainer = true;
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new Form3();
            frm.MdiParent = this;
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frm = new Form5();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "new form";
            frm.Name = "frmNewForm";
            frm.Click += delegate (object sender1, EventArgs e1)
            {
                MessageBox.Show("Click on the new form!", "example");
            };
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form frm = new frmInheritance();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form frm = new Form6();
            frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form frm = new Form5();
            frm.MdiParent = Form2.ActiveForm;
            frm.Show();
        }

        private void dinhDangForm_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }
    }
}
