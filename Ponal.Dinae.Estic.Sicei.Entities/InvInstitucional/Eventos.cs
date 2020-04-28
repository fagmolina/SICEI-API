using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponal.Dinae.Estic.Sicei.Entities.InvInstitucional
{
    public class Eventos
    {
        public string IdInvestigacion { get; set; }
        public string Tipo { get; set; }
        public string Participacion { get; set; }
        public string Fecha { get; set; }
        public string TipoRegion { get; set; }
        public string DescRegion { get; set; }
        public string DescSubRegion { get; set; }
        public string Pais { get; set; }
        public bool EsNacional { get; set; }
    }
}
