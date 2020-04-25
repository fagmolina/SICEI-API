using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponal.Dinae.Estic.Sicei.Entities.InvInstitucional
{
    public class Producto
    {
        public string IdInvestigacion { get; set; }
        public string TipoProducto { get; set; }
        public string Autor { get; set; }
        public string NombreRevista { get; set; }
        public string NombreArticulo { get; set; }
        public int Anio { get; set; }
        public string CodigoISSN { get; set; }
        public string NombreLibro { get; set; }
        public int PaginaInicio { get; set; }
        public int PaginaFinal { get; set; }
        public string Editorial { get; set; }
        public string FechaPublicacion { get; set; }
    }
}
