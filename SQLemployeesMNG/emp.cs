using System;
using System.Data;
using System.Data.SqlClient;

namespace SQLemployeesMNG
{
    public class emp
    {
        conexion cn = new conexion(); 

        public DataTable MostrarEmpleados()
        {
        
         SqlDataAdapter dataAdapter = new SqlDataAdapter("SP_MOSTRARTABLAEMPLEADOS", cn.svpstring());
         dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
         DataTable dt = new DataTable();
         dataAdapter.Fill(dt);
         return dt;

        }
    }
}

