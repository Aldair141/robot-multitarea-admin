using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace LIBDATOS
{
    public class ConexionDA
    {
        public static string GetConexion
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["CONEXION"].ConnectionString;
            }
        }
    }
}