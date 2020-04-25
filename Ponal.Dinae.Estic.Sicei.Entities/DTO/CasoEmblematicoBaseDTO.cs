using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponal.Dinae.Estic.Sicei.Entities.DTO
{
    public class CasoEmblematicoBaseDTO
    {
        public int ID_CASO { get; set; }
        public string NOMBRE_CASO { get; set; }
        public string LUGAR_AFECTACION { get; set; }
        public string ACTIVIDADES { get; set; }
        public int[] INVESTIGADORES { get; set; }
    }
}
