using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM student",db.getConnection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static bool insertStudent(student stu)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO student VALUES(@id, @ln, @fn, @birth, @gender, @phone, @address,@img)",db.getConnection());
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = stu.Id;
            cmd.Parameters.Add("@ln", SqlDbType.VarChar).Value = stu.LastName;
            cmd.Parameters.Add("@fn", SqlDbType.VarChar).Value = stu.FirstName;
            cmd.Parameters.Add("@birth", SqlDbType.VarChar).Value = stu.BirthDate;
            cmd.Parameters.Add("@gender", SqlDbType.VarChar).Value = stu.Gender;
            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = stu.Phone;
            cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = stu.Address;
            cmd.Parameters.Add("@img", SqlDbType.Image).Value = stu.Img.ToArray();
            db.openConnection();
            if(cmd.ExecuteNonQuery() == 1)
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

        public static DataTable Search(string value)
        {
            try
            {
                db.openConnection();
                string sql = "SELECT * FROM student WHERE id LIKE '" + value + "%'"; 
               // cmd.Parameters.Add("@value", SqlDbType.VarChar).Value = value;
                
                SqlDataAdapter da = new SqlDataAdapter(sql,db.getConnection());
                DataTable dt = new DataTable();
                da.Fill(dt);
               
                return dt;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
            finally
            {
                db.closeConnection();
            }
        }
    }
}
