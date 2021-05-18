﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagementApp.model;

namespace ManagementApp.DAO
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
        public static DataTable getCourseBySemester(int sem)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM course WHERE semester=@sem", db.getConnection());
            cmd.Parameters.Add("@sem", SqlDbType.Int).Value = sem;
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
            SqlCommand cmd = new SqlCommand("INSERT INTO course VALUES(@id, @lb, @period, @des, @sem)", db.getConnection());
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = course.Id;
            cmd.Parameters.Add("@lb", SqlDbType.VarChar).Value = course.Label;
            cmd.Parameters.Add("@period", SqlDbType.Int).Value = course.Period ;
            cmd.Parameters.Add("@des", SqlDbType.Text).Value = course.Description;
            cmd.Parameters.Add("@sem", SqlDbType.Int).Value = course.Semester;
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
            SqlCommand cmd = new SqlCommand("UPDATE course SET label = @lb, period = @pr, description=@des, semester=@sem WHERE id = @id", db.getConnection());
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = course.Id;
            cmd.Parameters.Add("@lb", SqlDbType.VarChar).Value = course.Label;
            cmd.Parameters.Add("@pr", SqlDbType.Int).Value = course.Period;
            cmd.Parameters.Add("@des", SqlDbType.Text).Value = course.Description;
            cmd.Parameters.Add("@sem", SqlDbType.Int).Value = course.Semester;
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

        public static course getCourseById(int id)
        {
            List<course> listCourse = getAllCourse();
            foreach(course c in listCourse)
            {
                if (c.Id == id)
                    return c;
            }
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
        public static DataTable getCourseByStudentId(int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT c.id,c.label FROM student s, course c, Score sc WHERE s.id = sc.sid AND c.id=sc.cid AND sc.sid = @id", db.getConnection());
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
