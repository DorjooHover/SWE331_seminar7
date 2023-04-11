using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class GlobalVar
    {
        private static SqlConnection conn;
        public static SqlConnection Connection
        {
            get { return conn; }
            set { conn = value; }
        }



        public static DataTable getData(string query)
        {
            try
            {

                DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                SqlDataAdapter sd = new SqlDataAdapter();
                conn.Open();

                sd.SelectCommand = new SqlCommand(query, conn);
                sd.Fill(ds);
                sd.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public static bool exec(string query, int param, string[] prms, string[] prmsText)
        {
            try
            {
                SqlCommand sc = new SqlCommand(query, conn);
                sc.CommandType = CommandType.StoredProcedure;
               
                for(int i = 0; i < param; i++)
                {
                    sc.Parameters.Add(new SqlParameter("@" + prmsText[i], prms[i]));

                }
                SqlDataAdapter sd = new SqlDataAdapter(sc);
                Console.WriteLine(sd);
                conn.Open();
                sc.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public static bool deleteExec(string query, int param, string[] prms, string[] prmsText)
        {
            try
            {
                SqlCommand sc = new SqlCommand(query, conn);
                sc.CommandType = CommandType.StoredProcedure;

                for (int i = 0; i < param; i++)
                {
                    sc.Parameters.Add(new SqlParameter("@" + prmsText[i], int.Parse(prms[i])));

                }
                SqlDataAdapter sd = new SqlDataAdapter(sc);
                Console.WriteLine(sd);
                conn.Open();
                sc.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
