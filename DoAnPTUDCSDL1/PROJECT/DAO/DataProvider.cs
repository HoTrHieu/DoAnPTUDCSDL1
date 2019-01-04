using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.DAO
{
    public class DataProvider
    {
        //duy nhất 1 lần tạo ra 1 connection
        private static DataProvider instance; // Ctrl + R + E

        public static DataProvider Instance
        {
            get {
                if (instance == null)
                    instance = new DataProvider();
                    return DataProvider.instance;
            }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }

        // Hậu
        private string connectionSTR = "Data Source=DESKTOP-KTD1ED7\\SQLEXPRESS;Initial Catalog=QuanLyChuyenDe;Integrated Security=True";
        
        // Hải    
        private string connectionSTR = "Data Source = DELL-DOTO\\SQLEXPRESS;Initial Catalog = QuanLyChuyenDe; Integrated Security = True";
        
        // Hiếu    
        //private string connectionSTR = "Data Source = DESKTOP-KALP039;Initial Catalog = QuanLyChuyenDe; Integrated Security = True";

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            //quyry có parameter: @s1 , @s2 ,.......
            //truyền parametter: ExecuteQuery(quyry, new object[]{"s1","s2"});
            DataTable data = new DataTable();
            //dữ liệu khai báo trong using() được tự động giải phóng
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        //trả ra số dòng thực thi thành công cho các lệnh: insert, delete, update
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }

        //đếm số lượng dòng trả ra(select*) chưa biết
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;
        }
    }
}