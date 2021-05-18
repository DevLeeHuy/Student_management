using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagementApp.Forms;
using ManagementApp.Forms.Courses;
using ManagementApp.Forms.Human_resources;
using ManagementApp.Forms.Register_Course;
using ManagementApp.Forms.Scores;

namespace ManagementApp
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
            Application.Run(new Result());
        }
    }
}
