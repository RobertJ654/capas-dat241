using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using capaDatos;
using capaEntidad;
using System.Data;

namespace capaFusion
{
    public class F_Estudiante
    {

        D_Estudiante datos_estudiante = new D_Estudiante();

        public DataTable F_listado()
        {
            return datos_estudiante.D_listado();
        }

    }
}
