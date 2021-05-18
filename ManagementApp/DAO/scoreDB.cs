using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagementApp.model;

namespace ManagementApp.DAO
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
        public static bool exist(int sid, int cid)
        {
            SqlCommand cmd = new SqlCommand("SELECT *FROM Score " +
                                            "WHERE sid = @sid AND cid = @cid", db.getConnection());
            cmd.Parameters.Add("@sid", SqlDbType.Int).Value = sid;
            cmd.Parameters.Add("@cid", SqlDbType.Int).Value = cid;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public static bool addStudy(Score s)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Score VALUES(@sid,@cid,null,@des)", db.getConnection());
            cmd.Parameters.Add("@sid", SqlDbType.Int).Value = s.Sid;
            cmd.Parameters.Add("@cid", SqlDbType.Int).Value = s.Cid;
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
        public static string getCnameByCid(int cid)
        {
            SqlCommand cmd = new SqlCommand("SELECT dbo.getCnameByCid(@cid)", db.getConnection());
            cmd.Parameters.Add("@cid", SqlDbType.Int).Value = cid;
            db.openConnection();
            string name = cmd.ExecuteScalar().ToString();
            db.closeConnection();
            return name;
        }

        public static DataTable getScoreByCid(int cid)
        {
            SqlCommand cmd = new SqlCommand("SELECT student.id ,stdScore as '"+getCnameByCid(cid)+"' FROM student LEFT JOIN Score ON student.id = Score.sid AND cid =@cid", db.getConnection());
            cmd.Parameters.Add("@cid", SqlDbType.Int).Value = cid;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable getAllStdAvgScore(int sem)
        {
            SqlCommand cmd = new SqlCommand("SELECT student.id, avg(stdScore) as 'Average Score' FROM student, Score,course WHERE student.id = Score.sid" +
                " AND course.id= Score.cid AND course.semester=@sem GROUP BY student.id ", db.getConnection());
            cmd.Parameters.Add("@sem", SqlDbType.Int).Value = sem;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable getListResult(int sem)
        {
            DataTable listCourse = courseDB.getCourseBySemester(sem);
            DataTable rs = new DataTable();
            rs = studentDB.getListStudent();
            for (int i = 3; i < rs.Columns.Count + (i - 3); i++)
            {
                rs.Columns.RemoveAt(3);
            }
            List<DataTable> tables = new List<DataTable>();
            tables.Add(rs);
            //get all score by course_id
            foreach (DataRow row in listCourse.Rows)
            {
                int cid = row.Field<int>("id");
                DataTable dt = getScoreByCid(cid);
                tables.Add(dt);
            }
            //get average_score && results of student
            rs = getAllStdAvgScore(sem);
            rs.Columns.Add("Result",typeof(string));
            //show result by score
            foreach (DataRow row in rs.Rows)
            {
                string type = "";
                if (row["Average Score"].ToString() != "")
                {
                    double avgScore = row.Field<double>("Average Score");
                    if (avgScore > 0 && avgScore < 10)
                    {
                        if (avgScore < 5)
                        {
                            type = "Rớt";
                        }
                        else if (avgScore < 6.5)
                        {
                            type = "Trung bình";
                        }
                        else if (avgScore < 8)
                        {
                            type = "Khá";
                        }
                        else if (avgScore < 10)
                        {
                            type = "Giỏi";
                        }
                        else
                        {
                            type = "Xuất sắc";
                        }
                    }
                    else
                    {
                        type = "Sai điểm";
                    }
                }
                else type = "Chưa có điểm";
                row["Result"] = type;
            }
            tables.Add(rs);
            rs = tables.MergeAll("id");
            return rs;
        }
        public static DataTable MergeAll(this IList<DataTable> tables, String primaryKeyColumn)
        {
            if (!tables.Any())
                throw new ArgumentException("Tables must not be empty", "tables");
            if (primaryKeyColumn != null)
                foreach (DataTable t in tables)
                    if (!t.Columns.Contains(primaryKeyColumn))
                        throw new ArgumentException("All tables must have the specified primarykey column " + primaryKeyColumn, "primaryKeyColumn");

            if (tables.Count == 1)
                return tables[0];

            DataTable table = new DataTable("TblUnion");
            table.BeginLoadData(); // Turns off notifications, index maintenance, and constraints while loading data
            foreach (DataTable t in tables)
            {
                table.Merge(t); // same as table.Merge(t, false, MissingSchemaAction.Add);
            }
            table.EndLoadData();

            if (primaryKeyColumn != null)
            {
                // since we might have no real primary keys defined, the rows now might have repeating fields
                // so now we're going to "join" these rows ...
                var pkGroups = table.AsEnumerable()
                    .GroupBy(r => r[primaryKeyColumn]);
                var dupGroups = pkGroups.Where(g => g.Count() > 1);
                foreach (var grpDup in dupGroups)
                {
                    // use first row and modify it
                    DataRow firstRow = grpDup.First();
                    foreach (DataColumn c in table.Columns)
                    {
                        if (firstRow.IsNull(c))
                        {
                            DataRow firstNotNullRow = grpDup.Skip(1).FirstOrDefault(r => !r.IsNull(c));
                            if (firstNotNullRow != null)
                                firstRow[c] = firstNotNullRow[c];
                        }
                    }
                    // remove all but first row
                    var rowsToRemove = grpDup.Skip(1);
                    foreach (DataRow rowToRemove in rowsToRemove)
                        table.Rows.Remove(rowToRemove);
                }
            }

            return table;
        }
    }
}
