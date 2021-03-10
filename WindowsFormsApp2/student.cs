using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class student
    {

        public student() { }
        public student(string id,string fname,string lname,string birth,string phone,string address,string gender, MemoryStream Pic)
        {
            this.id = id;
            this.firstName = fname;
            this.lastName = lname;
            this.birthDate = birth;
            this.phone = phone;
            this.address = address;
            this.gender = gender;
            this.img = Pic;
        }

        private string id;

        private string lastName;


        private string firstName;


        private string birthDate;


        private string gender;


        private string phone;


        private string address;


        private MemoryStream img;

        public string Id { get => id; set => id = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string BirthDate { get => birthDate; set => birthDate = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public MemoryStream Img { get => img; set => img = value; }
    }
}
