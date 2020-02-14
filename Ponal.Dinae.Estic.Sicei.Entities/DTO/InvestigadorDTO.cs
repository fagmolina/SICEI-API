using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponal.Dinae.Estic.Sicei.Entities.DTO
{
    public class InvestigadorDTO
    {
        public decimal ID_INVESTIGADOR { get; set; }
        public decimal ID_GRADO { get; set; }
        public string DOCUMENTO { get; set; }
        public string NOMBRES { get; set; }
        public string APELLIDOS { get; set; }
        public string EMAIL { get; set; }
        public string TELEFONO { get; set; }
        public string DIRECCION { get; set; }
        public string ESTUDIOS { get; set; }
        public string CATEGORIZADO { get; set; }
        public string CATEGORIZADO_VALOR { get; set; }
        public string PROFESOR { get; set; }
        public string ESTUDIANTE { get; set; }
    }
}
