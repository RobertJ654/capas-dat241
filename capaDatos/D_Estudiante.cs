using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using capaEntidad;
using System.Configuration;

using System.Data.SqlClient;
using System.Data;

namespace capaDatos
{
    public class D_Estudiante
    {
        
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);

        public DataTable D_listado()
        {
            SqlCommand cmd = new SqlCommand("listar", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
