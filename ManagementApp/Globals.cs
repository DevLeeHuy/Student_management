using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementApp
{
    public static class Globals
    {
        static Globals() { } 

        public static DataRow user { get; private set; }

        public static void setUser(DataRow user)
        {
            Globals.user = user;
        }
    }
}
