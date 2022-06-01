using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FirstMVC.ModelHelp
{
    public class SQLHELP
    {
        private static string ConnectionString = @"Data Source=QA-DEMON\SQLEXPRESS;Initial Catalog=UserInfo;Integrated Security=True";

        public static void ExecuteSql(string sql, SqlParameter[] paramers)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.Parameters.AddRange(paramers);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static SqlDataReader ExecuteReader(string sql, params SqlParameter[] ps)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddRange(ps);
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
        public static DataTable GetData()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            string txt = "select * from Farm";
           // string txt = "select season from Farm";
            using (SqlDataAdapter apter = new SqlDataAdapter(txt, conn))
            {                
                DataTable da = new DataTable();
                apter.Fill(da);
                return da;
            }
        }
        //查出单列
        public static DataTable GetRow0()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            string txt = "select * from Farm";
            using (SqlDataAdapter apter = new SqlDataAdapter(txt, conn))
            {
                DataTable da = new DataTable();
                apter.Fill(da);
                return da;
            }
        }
        public static DataTable GetRow()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            string txt = "select distinct season from Farm";
            using (SqlDataAdapter apter = new SqlDataAdapter(txt, conn))
            {
                DataTable da = new DataTable();
                apter.Fill(da);
                return da;
            }
        }
        public static DataTable GetRow2()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            string txt = "select ID, season from Farm";
            using (SqlDataAdapter apter = new SqlDataAdapter(txt, conn))
            {
                DataTable da = new DataTable();
                apter.Fill(da);
                return da;
            }
        }
        public static DataTable GetRow20(string txt)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            using (SqlDataAdapter apter = new SqlDataAdapter(txt, conn))
            {
                DataTable da = new DataTable();
                apter.Fill(da);
                return da;
            }
        }
        //public static DataTable GetData2(SqlParameter[] paramers)
        //{
        //    SqlConnection conn = new SqlConnection(ConnectionString);
        //    conn.Open();
        //    string txt = "select * from userinfo where name='武器大师'";
        //    SqlParameter[] param ={
        //                         new SqlParameter("@name","武器大师")
        //                         };
        //    using (SqlDataAdapter apter = new SqlDataAdapter(txt, conn))
        //    {
        //        apter.SelectCommand.Parameters.AddRange(param);
        //        DataTable da = new DataTable();
        //        apter.Fill(da);
        //        return da;
        //    }
        //}
        public static DataTable GetData2(string txt, SqlParameter[] param)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            using (SqlDataAdapter apter = new SqlDataAdapter(txt, conn))
            {
                apter.SelectCommand.Parameters.AddRange(param);
                DataTable da = new DataTable();
                apter.Fill(da);
                return da;
            }
        }
     
    }
}