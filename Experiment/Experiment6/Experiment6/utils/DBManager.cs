using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment6.utils
{
    public class DBManager
    {
        // 静态成员 支持单例模式
        private static DBManager instance = null;
        private static object syncRoot = new object();
        private string connectUrl;//数据库连接参数

        private MySqlConnection connection = null;//连接数据库

        // 单例模式
        public static DBManager getInstance()
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new DBManager();
                    }
                }
            }
            return instance;
        }

        private DBManager()
        {
            //连接参数
            connectUrl = "server = localhost; " +
                "port = " + 3306 + "; " +
                "user = " + "root" + "; " +
                "password = " + "123456" + "; " +
                "database = " + "test" + "; ";
        }

        //1. 连接数据库
        public void connectDB()
        {
            try
            {
                connection = new MySqlConnection(connectUrl);
                connection.Open();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //2. 关闭连接
        public void closeDB()
        {
            try
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //3. 查询操作(select) -> 返回查询结果
        public MySqlDataReader exeQuery(string sql)
        {
            MySqlDataReader reader = null;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                reader = cmd.ExecuteReader();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
            return reader;
        }

        //4. 更新操作(insert, update, delete) -> 返回影响行数
        //return: (1) the row count for SQL Data Manipulation Language (DML) statements 
        //		  (2) 0 for SQL statements that return nothing
        public int exeUpdate(string sql)
        {
            int result = 0;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                result = cmd.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
            return result;
        }
    }

}
