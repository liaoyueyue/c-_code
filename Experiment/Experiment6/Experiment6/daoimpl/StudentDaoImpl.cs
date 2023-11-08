using Experiment6.dao;
using Experiment6.entity;
using Experiment6.utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment6.daoimpl
{
    class StudentDaoImpl : StudentDao
    {
        DBManager dbManager = DBManager.getInstance();

        // 注意：下面方法都是存在 sql 注入的

        public int add(Student student)
        {
            dbManager.connectDB();
            string sql = string.Format("insert into student(studentid, name，gender，age，major，phone) values ({0}, '{1}', '{2}', '{3}', '{4}', '{5}')", student.Studentid, student.Name, student.Gender, student.Age, student.Major, student.Phone);
            int result = dbManager.exeUpdate(sql);
            dbManager.closeDB();
            return result;
        }

        public int delete(Student student)
        {
            dbManager.connectDB();
            string sql = "delete from student where studentid = " + student.Studentid;
            int result = dbManager.exeUpdate(sql);
            dbManager.closeDB();
            return result;
        }
        public int update(Student student)
        {
            dbManager.connectDB();
            string sql = string.Format("update student set studentid = {0}, name = '{1}', gender = '{2}', age = '{3}', major = '{4}', phone = '{5}'", student.Studentid, student.Name, student.Gender, student.Age, student.Major, student.Phone);
            int result = dbManager.exeUpdate(sql);
            dbManager.closeDB();
            return result;
        }

        public List<Student> queryAll()
        {
            dbManager.connectDB();
            string sql = "select * from student";
            MySqlDataReader rs = dbManager.exeQuery(sql);
            List<Student> students = new List<Student>();
            while (rs.Read())
            {
                students.Add(parseStudent(rs));
            }
            dbManager.closeDB();
            return students;
        }

        private Student parseStudent(MySqlDataReader rs)
        {
            Student student = new Student
            {
                Id = rs.GetInt32("id"),
                Studentid = rs.GetInt32("studentid"),
                Name = rs.GetString("name"),
                Gender = rs.GetString("gender"),
                Age = rs.GetString("age"),
                Major = rs.GetString("major"),
                Phone = rs.GetString("phone")
            };
            return student;
        }
 
    }
}
