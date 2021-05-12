using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Forms.Courses;
using WindowsFormsApp2.Forms.Human_resources;
using WindowsFormsApp2.Forms.Register_Course;
using WindowsFormsApp2.Forms.Scores;

namespace WindowsFormsApp2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ManageCourseFrm());
        }
    }
}
