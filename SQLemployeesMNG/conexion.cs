using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace SQLemployeesMNG
{
    public class conexion
    {
        public SqlConnection svpstring()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["skrrseven"].ConnectionString);
           
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            else
            {
                cn.Open();
            }
            return cn;
        }
    }
}
