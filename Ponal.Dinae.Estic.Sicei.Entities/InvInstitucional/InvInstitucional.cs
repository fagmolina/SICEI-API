using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponal.Dinae.Estic.Sicei.Entities.InvInstitucional
{
    public class InvInstitucional
    {
        #region InfoBase
        public string IdInvestigacion { get; set; }
        public string Titulo { get; set; }
        public int Direccion { get; set; }
        public string Anio { get; set; }
        public string Participacion { get; set; }
        public string ExParticipa { get; set; }
        public int Escuela { get; set; }
        public int Estado { get; set; }
        #endregion

        #region Area Linea
        public List<AreaLinea> AreaLinea { get; set; }
        #endregion

        #region Investigadores
        public List<Investigarores> Investigadores { get; set; }
        #endregion

        #region Producto
        public Producto Producto { get; set; }
        #endregion

        #region Estimulos
        public Estimulos Estimulos { get; set; }
        #endregion


        #region Eventos
        public Eventos Eventos { get; set; }
        #endregion

        #region Presupuesto
        public List<Presupuesto> Presupuesto { get; set; }
        #endregion



    }
}
