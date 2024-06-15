using System;
using System.Data;
using System.Data.SqlClient;

namespace SQLemployeesMNG
{
    public class genero
    {
        conexion cn = new conexion();

        public DataTable Generos()
        {
         
        SqlDataAdapter dataAdapter = new SqlDataAdapter("SP_GENERO", cn.svpstring());
        dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataTable dt = new DataTable();
        dataAdapter.Fill(dt);
        return dt;
      
        }
    }
}
