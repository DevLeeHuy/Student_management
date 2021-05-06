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
    static class scoreDB
    {
        static myDB db = new myDB();
        public static DataTable getListScore()
        {
            SqlCommand cmd = new SqlCommand("SELECT sid,fname,cid,label,stdScore,Score.description FROM Score, course, student " +
                                             "WHERE Score.sid = student.id AND Score.cid = course.id", db.getConnection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        public static bool addScore(Score s)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Score SET stdScore = @score, description = @des WHERE sid=@sid AND cid=@cid", db.getConnection());
            cmd.Parameters.Add("@sid", SqlDbType.Int).Value =s.Sid;
            cmd.Parameters.Add("@cid", SqlDbType.Int).Value = s.Cid;
            cmd.Parameters.Add("@score", SqlDbType.Float).Value = s.StdScore;
            cmd.Parameters.Add("@des", SqlDbType.Text).Value = s.Description;
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
        public static DataTable avgScore()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.avgScore()", db.getConnection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public static bool deleteScore(int sid, int cid)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Score WHERE sid = @sid and cid =@cid", db.getConnection());
            cmd.Parameters.Add("@sid", SqlDbType.Int).Value =sid;
            cmd.Parameters.Add("@cid", SqlDbType.Int).Value = cid;
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
    }
}
