﻿using System.Data;
using System.Data.SqlClient;


namespace QuanLy
{
    class ketnoi
    {
        public SqlConnection GetConnection()
        {
            SqlConnection con;
            string sql = @"Data Source=KILLA\SQLEXPRESS;Initial Catalog=QLDB;Integrated Security=True;User ID=sa;Password=123456789;";
            con = new SqlConnection(sql);
            return con;
        }

        public DataTable GetTable(string sql)
        {
            SqlConnection con = GetConnection();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
        public void hamxuly(string sql)
        {
            SqlConnection con = GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
        }
    }
}
