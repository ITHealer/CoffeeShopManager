using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class DataProvider
    {

        private static DataProvider instance; // để tránh trường hợp nhiều kết nối cùng một lúc dẫn đến xung đột

        public static DataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DataProvider();
                return DataProvider.instance;
            }
            private set { DataProvider.instance = value; }//chỉ có nội bộ mới đc set dl vào
        }
        private DataProvider() { }
        string strCon = @"Data Source=DESKTOP-F1OLJ2J\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated Security=True";
        //string strCon = @"Data Source=DESKTOP-F1OLJ2J\SQLEXPRESS;Initial Catalog=QLQuanCafe;Integrated Security=True";
        SqlConnection sqlCon = null;

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(data);
                sqlCon.Close();
            }
            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteNonQuery();
                sqlCon.Close();
            }
            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteScalar();
                sqlCon.Close();
            }
            return data;
        }
    }
}
