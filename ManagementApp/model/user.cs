using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementApp.model
{
    public class user
    {
        private int userID;
        private string fname;
        private string lname;
        private string password;
        private string username;
        private MemoryStream image;

        public user( string fname, string lname,string pass, string username, MemoryStream image)
        {
            this.fname = fname;
            this.lname = lname;
            this.password = pass;
            this.username = username;
            this.image = image;
        }
        public int UserID { get => userID; set => userID = value; }
        public string Fname { get => fname; set => fname = value; }
        public string Lname { get => lname; set => lname = value; }
        public string Password { get => password; set => password = value; }
        public string Username { get => username; set => username = value; }
        public MemoryStream Image { get => image; set => image = value; }

    }
}
