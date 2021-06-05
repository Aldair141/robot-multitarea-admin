using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using LIBENTIDAD;

namespace LIBDATOS
{
    public class Tb_ProcesosDA
    {
        SqlConnection connection;

        public Tb_ProcesosDA()
        {
            connection = new SqlConnection(ConexionDA.GetConexion);
        }
    }
}