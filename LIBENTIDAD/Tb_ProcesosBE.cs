using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBENTIDAD
{
    public class Tb_ProcesosBE
    {
        public int ProcesoID { get; set; }
        public string ProcesoName { get; set; }
        public string ProcesoDescription { get; set; }
        public int FlagActivo { get; set; }
        public int TipoProcesoID { get; set; }
        public string DiasSemana { get; set; }
        public TimeSpan HoraEjecucion { get; set; }
        public DateTime FechaEjecucion { get; set; }
        public int NumDias { get; set; }
        public int NumMinutos { get; set; }
    }
}