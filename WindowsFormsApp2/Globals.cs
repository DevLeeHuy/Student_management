using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public static class Globals
    {
        static Globals() { user = new DataTable(); } // default value

        public static DataTable user { get; private set; }

        public static void setUserID(DataTable user)
        {
            Globals.user = user;
        }
    }
}
