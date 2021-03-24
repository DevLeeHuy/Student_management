using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class studentDB
    {
        static myDB db = new myDB();

        public static DataTable getListStudent()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM student", db.getConnection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static bool insertStudent(student stu)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO student VALUES(@id, @ln, @fn, @birth, @gender, @phone, @address,@img)", db.getConnection());
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = stu.Id;
            cmd.Parameters.Add("@ln", SqlDbType.VarChar).Value = stu.LastName;
            cmd.Parameters.Add("@fn", SqlDbType.VarChar).Value = stu.FirstName;
            cmd.Parameters.Add("@birth", SqlDbType.DateTime).Value = stu.BirthDate;
            cmd.Parameters.Add("@gender", SqlDbType.VarChar).Value = stu.Gender;
            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = stu.Phone;
            cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = stu.Address;
            cmd.Parameters.Add("@img", SqlDbType.Image).Value = stu.Img.ToArray();
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
        public static bool updateStudent(student stu)
        {
            SqlCommand cmd = new SqlCommand("UPDATE student SET lname = @ln, fname = @fn, BirthDate=@birth, gender = @gender," +
                "phone = @phone, address = @address, img = @img WHERE id = @id", db.getConnection());
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = stu.Id;
            cmd.Parameters.Add("@ln", SqlDbType.VarChar).Value = stu.LastName;
            cmd.Parameters.Add("@fn", SqlDbType.VarChar).Value = stu.FirstName;
            cmd.Parameters.Add("@birth", SqlDbType.DateTime).Value = stu.BirthDate;
            cmd.Parameters.Add("@gender", SqlDbType.VarChar).Value = stu.Gender;
            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = stu.Phone;
            cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = stu.Address;
            cmd.Parameters.Add("@img", SqlDbType.Image).Value = stu.Img.ToArray();
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

        public static bool deleteStudent(string id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM student WHERE id = @id", db.getConnection());
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
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

        public static student getStdById(string id)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM student WHERE id = @id", db.getConnection());
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            SqlDataReader dt = cmd.ExecuteReader();
            while (dt.Read())
            {
                string lname = dt.GetValue(1).ToString();
                string fname = dt.GetValue(2).ToString();
                DateTime BirthDate = (DateTime)dt.GetValue(3);
                string gender = dt.GetValue(4).ToString();
                string phone = dt.GetValue(5).ToString();
                string address = dt.GetValue(6).ToString();
                byte[] image = (byte[])dt.GetValue(7);
                MemoryStream img = new MemoryStream(image);
                db.closeConnection();
                return new student(id, fname, lname, BirthDate, phone, address, gender, img);
            }
            db.closeConnection();
            return null;


        }



        public static DataTable Search(string value)
        {
            try
            {
                db.openConnection();
                string sql = "SELECT * FROM student WHERE id LIKE '" + value + "%'" + " OR fname LIKE '" + value + "%'" + " OR gender LIKE '" + value + "%'";
                // cmd.Parameters.Add("@value", SqlDbType.VarChar).Value = value;

                SqlDataAdapter da = new SqlDataAdapter(sql, db.getConnection());
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
            finally
            {
                db.closeConnection();
            }
        }
        public static DataTable getStdByBirth(DateTime from, DateTime to)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM student WHERE BirthDate >= @from AND BirthDate <= @to",db.getConnection());
            cmd.Parameters.Add("@from", SqlDbType.DateTime).Value = from;
            cmd.Parameters.Add("@to", SqlDbType.DateTime).Value = to;
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            return dt;


        }
    }
}
  