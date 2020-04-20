using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QlyCHVT
{
    class ThucthiSQL
    {
        public static SqlConnection conn1 = new SqlConnection();

        public static string connectionString = " Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Admin\\Downloads\\cslt2\\QlyCHVT\\QlyCHVT\\bin\\Debug\\QlyCHVT.mdf;Integrated Security=True";
        public static void KetNoiCSDL()
        {
            conn1 = new SqlConnection();
            conn1.ConnectionString = connectionString;
            if (conn1.State != ConnectionState.Open)
                conn1.Open();
        }
        public static void DongKetNoiCSDL()
        {
            if (conn1.State != ConnectionState.Closed)
            {
                conn1.Close();
                conn1.Dispose();
                conn1= null;
            }

        }
        public static DataTable DocBang(string sql)
        {

            DataTable dt = new DataTable();
            SqlDataAdapter Mydata = new SqlDataAdapter();
            Mydata.SelectCommand = new SqlCommand();
            KetNoiCSDL();
            Mydata.SelectCommand.Connection = conn1;
            Mydata.SelectCommand.CommandText = sql;
            Mydata.Fill(dt);
            DongKetNoiCSDL();
            return dt;

        }
        public static void CapNhatDuLieu(string sql)
        {
            KetNoiCSDL();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conn1;
            sqlCommand.CommandText = sql;
            sqlCommand.ExecuteNonQuery();
            DongKetNoiCSDL();
        }
        public static string GetFieldValues(string sql)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, conn1);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
                ma = reader.GetValue(0).ToString();
            reader.Close();
            return ma;
        }
    }
}
