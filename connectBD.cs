using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;

namespace QL_Khenthuong
{
    internal class connectBD
    {
        private string connection;
        public connectBD()
        {
            connection = @"Data Source=LAPTOP-J7;Database=QLDL_Khenthuong;User Id=sa;Password=123456";
        }
        public DataTable ReadData(string sql)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand(sql, con);

            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr, LoadOption.OverwriteChanges);

                if (dt.Rows.Count == 0)
                {
                    con.Close();
                    return null;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                return null;
            }
            return dt;
        }
        public int WriteData(string sql)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand(sql, con);
            int roweffect = -1;
            try
            {
                con.Open();
                roweffect = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                return -1;
            }
            return roweffect;
        }
    }
}
