using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.model
{
    class contact
    {
        static myDB db = new myDB();
        public static bool insertContact(string fname,string lname, string phone, string address, string email, int uid,int gid,MemoryStream pic)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO contact VALUES(@fname,@lname,@phone,@address,@email,@uid,@gid,@img)", db.getConnection());
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@uid", SqlDbType.VarChar).Value = uid;
            cmd.Parameters.Add("@gid", SqlDbType.VarChar).Value = gid;
            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = address;
            cmd.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
            cmd.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
            cmd.Parameters.Add("@img", SqlDbType.Image).Value = pic.ToArray();
            db.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }

            db.closeConnection();

            return false;
        }
        public static bool updateContact(int contactId, string fname, string lname, string phone, string address, string email, int gid, MemoryStream pic)
        {
            SqlCommand cmd = new SqlCommand("UPDATE contact SET lname = @lname, fname = @fname, group_id=@gid, email = @email," +
               "phone = @phone, address = @address, img = @img WHERE id = @id", db.getConnection());
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = contactId;
            cmd.Parameters.Add("@gid", SqlDbType.Int).Value = gid;
            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = address;
            cmd.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
            cmd.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
            cmd.Parameters.Add("@img", SqlDbType.Image).Value = pic.ToArray();
            db.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }

            db.closeConnection();

            return false;
        }
       
        public static bool deleteContact(int id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM contact WHERE id = @id", db.getConnection());
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            db.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
        public static DataTable getContactById(int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM contact WHERE id = @id", db.getConnection());
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;


        }
        public static DataTable getListContact()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM contact", db.getConnection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
