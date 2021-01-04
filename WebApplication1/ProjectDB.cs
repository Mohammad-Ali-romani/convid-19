using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public static class ProjectDB
    {
        static  string  str = "Data Source=.;Initial Catalog=TCC;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static DataTable ExcuteDataTable(string sql)
        {
            SqlConnection con = new SqlConnection(str);
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable ds = new DataTable();
            ad.Fill(ds);
            return ds;
        }
        public static DataSet ExcuteDataSet(string sql)
        {
            SqlConnection con = new SqlConnection(str);
            SqlDataAdapter ad = new SqlDataAdapter(sql,con);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            return ds;
        }
        public static int ExcuteNonQuery(string sql)
        {
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public static object ExcuteScalar(string sql)
        {
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            object i = cmd.ExecuteScalar();
            con.Close();
            return i;
        }

    }
}