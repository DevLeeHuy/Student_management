using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.model
{
    class group
    {
        static myDB db = new myDB();
        public static bool insertGroup(string grName, int userID)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO groups VALUES(@grName,@uid)", db.getConnection());
            cmd.Parameters.Add("@grName", SqlDbType.VarChar).Value = grName;
            cmd.Parameters.Add("@uid", SqlDbType.VarChar).Value = userID;
            db.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }

            db.closeConnection();

            return false;
        }
        public static bool updateGroup(int id, string name)
        {
            SqlCommand cmd = new SqlCommand("UPDATE groups SET name = @name WHERE id = @id", db.getConnection());
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            db.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }

            db.closeConnection();

            return false;

        }
        public static bool deleteGroup(int id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM groups WHERE id = @id", db.getConnection());
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

        public static DataTable getListGroup(int uid)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM groups WHERE uid = @uid", db.getConnection());
            cmd.Parameters.Add("@uid", SqlDbType.Int).Value = uid;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static bool groupExist(string name, int uid = 0)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM groups WHERE  name=@name AND uid=@uid ", db.getConnection());
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@uid", SqlDbType.Int).Value = uid;
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
