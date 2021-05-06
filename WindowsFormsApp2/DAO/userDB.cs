using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.model;

namespace WindowsFormsApp2.DAO
{
   public class userDB
    {
        static myDB db = new myDB();
        public static bool insertUser(user u)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO users VALUES(@username,@pass,@fname,@lname,@img)", db.getConnection());
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = u.Username;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = u.Password;
            cmd.Parameters.Add("@fname", SqlDbType.VarChar).Value = u.Fname;
            cmd.Parameters.Add("@lname", SqlDbType.VarChar).Value = u.Lname;
            cmd.Parameters.Add("@img", SqlDbType.Image).Value = u.Image.ToArray();
            db.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }

            db.closeConnection();
           
                return false;
        }
        public static DataTable checkAccount(string username, string pass)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM users WHERE username = @User AND password =@Pass", db.getConnection());
            cmd.Parameters.Add("@User", SqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@Pass", SqlDbType.VarChar).Value = pass;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable getUserById(int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM users WHERE id = @id", db.getConnection());
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static bool userExist(string username)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM users WHERE  username = @User ", db.getConnection());
            cmd.Parameters.Add("@User", SqlDbType.VarChar).Value = username;
            db.openConnection();
            if (cmd.ExecuteScalar() != null)
            {
                db.closeConnection();
                return true;
            }

            db.closeConnection();

            return false;
        }
    }
}
