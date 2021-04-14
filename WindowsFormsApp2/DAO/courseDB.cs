using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.model;

namespace WindowsFormsApp2.DAO
{
    class courseDB
    {
        static myDB db = new myDB();
        public static DataTable getListCourse()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM course", db.getConnection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static List<course> getAllCourse()
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM course", db.getConnection());
            var courseList = new List<course>();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var s = new course();
                s.Id = reader.GetInt32(0);
                s.Label = reader.GetString(1);
                s.Period = reader.GetInt32(2);
                s.Description = reader.GetString(3);
                courseList.Add(s);
            }
            db.closeConnection();
            return courseList;
        }

        public static bool insertCourse(course course)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO course VALUES(@id, @lb, @period, @des)", db.getConnection());
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = course.Id;
            cmd.Parameters.Add("@lb", SqlDbType.VarChar).Value = course.Label;
            cmd.Parameters.Add("@period", SqlDbType.Int).Value = course.Period ;
            cmd.Parameters.Add("@des", SqlDbType.Text).Value = course.Description;
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
        public static bool updateCourse(course course)
        {
            SqlCommand cmd = new SqlCommand("UPDATE course SET label = @lb, period = @pr, description=@des WHERE id = @id", db.getConnection());
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = course.Id;
            cmd.Parameters.Add("@lb", SqlDbType.VarChar).Value = course.Label;
            cmd.Parameters.Add("@pr", SqlDbType.Int).Value = course.Period;
            cmd.Parameters.Add("@des", SqlDbType.Text).Value = course.Description;
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

        public static bool deleteCourse(int id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM course WHERE id = @id", db.getConnection());
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

        public static bool courseExist(string label)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM course WHERE label =@lb", db.getConnection());
            cmd.Parameters.Add("@lb", SqlDbType.VarChar).Value = label;
            if(Convert.ToInt32(cmd.ExecuteScalar()) != 0)
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

        public static student getCourseById(string id)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM course WHERE id = @id", db.getConnection());
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            SqlDataReader dt = cmd.ExecuteReader();
            while (dt.Read())
            {
                //string lname = dt.GetValue(1).ToString();
                //string fname = dt.GetValue(2).ToString();
                //DateTime BirthDate = (DateTime)dt.GetValue(3);
                //string gender = dt.GetValue(4).ToString();
                //string phone = dt.GetValue(5).ToString();
                //string address = dt.GetValue(6).ToString();
                //byte[] image = (byte[])dt.GetValue(7);
                //MemoryStream img = new MemoryStream(image);
                db.closeConnection();
                //return new student(id, fname, lname, BirthDate, phone, address, gender, img);
                return null;
            }
            db.closeConnection();
            return null;
        }
    
        public static DataTable getListStudy(int id)
        {
            //db.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.getListStudy(@id)", db.getConnection());
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //db.closeConnection();
            return dt;
        }
    }
}
