using System;
using System.Data;
using System.Data.SqlClient;

namespace SQLemployeesMNG
{
    public class cargos
    {
        conexion cn = new conexion();

        public DataTable CargarCombo()
        {
    
         SqlDataAdapter dataAdapter = new SqlDataAdapter("SP_CARGOS", cn.svpstring());
         dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
         DataTable dt = new DataTable();
         dataAdapter.Fill(dt);
         return dt;
      
        }
    }
}
