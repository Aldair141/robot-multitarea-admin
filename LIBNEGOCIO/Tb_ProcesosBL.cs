using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIBDATOS;
using LIBENTIDAD;

namespace LIBNEGOCIO
{
    public class Tb_ProcesosBL
    {
        Tb_ProcesosDA procesosDA;

        public Tb_ProcesosBL()
        {
            procesosDA = new Tb_ProcesosDA();
        }
        public bool Insert(Tb_ProcesosBE entidad)
        {
            return procesosDA.Insert(entidad);
        }
    }
}