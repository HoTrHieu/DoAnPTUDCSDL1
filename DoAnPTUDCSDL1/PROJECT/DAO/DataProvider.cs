using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PROJECT.DAO
{
    class DataProvider
    {
        public string ConnectionString;
        SqlConnection Connection { get; set; }
        //static string ConnectionString="Server=DESKTOP-KALP039; Database=QLHV;  Trusted_Connection=True;";

        ////////viết hàm khởi tạo
        public DataProvider()
        {
           ConnectionString= "Data Source=DESKTOP-KALP039;Initial Catalog=QuanLyChuyenDe;Integrated Security=True";
        }
      
       //hàm kết nối
        public void Connect()
        {
            try
            {
                if (Connection == null)
                {
                    Connection = new SqlConnection(ConnectionString);
                }
                if (Connection.State != ConnectionState.Closed)
                    Connection.Close();
                Connection.Open();

                //Console.Write("\nKet noi thanh cong");
            }
            catch (SqlException ex)
            {
                Console.Write("\nKet noi that bai");
                throw ex;
            }
        }
        //c2 viết hàm connect
        //public SqlConnection Connect()
        //{
        //    return new SqlConnection(ConnectionString);
        //}


        //ngắt kết nối
        //hàm ngắt kết nối
        public void Disconnect()
        {
            if (Connection != null && Connection.State == ConnectionState.Open)
                Connection.Close();
        }

        /// <summary>
        /// /thêm xoa sửa
        /// </summary>
        /// <param name="args"></param>
        /// 
        //THEM XOA SUA DU LIEU
        public int ExecuteNonQuery(CommandType cmdType, string strSql)
        {
            try
            {
                SqlCommand command = Connection.CreateCommand();
                command.CommandText = strSql;
                command.CommandType = cmdType;

                int nRow = command.ExecuteNonQuery();
                return nRow;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// tham số
        /// </summary>
        /// <param name="args"></param>
        public int ExecuteNonQuery(CommandType cmdType, string strSql, params SqlParameter[] parameters)
        {
            try
            {
                SqlCommand command = Connection.CreateCommand();
                command.CommandText = strSql;
                command.CommandType = cmdType;

                if (parameters != null && parameters.Length > 0)
                    command.Parameters.AddRange(parameters);

                int nRow = command.ExecuteNonQuery();
                if (nRow > 0)
                {
                    Console.Write("\nTB:Thanh Cong");
                }
                return nRow;
            }
            catch (SqlException ex)
            {
                Console.Write("\nTB:That Bai!");
                throw ex;
            }
        }


        public DataTable Select(CommandType cmdType, string strSql)
        {
            try
            {
                SqlCommand command = Connection.CreateCommand();
                command.CommandText = strSql;
                command.CommandType = cmdType;

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }


    }
}
