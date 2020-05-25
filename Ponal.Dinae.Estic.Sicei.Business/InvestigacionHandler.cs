using Ponal.Dinae.Estic.Sicei.DataAccess.Base;
using Ponal.Dinae.Estic.Sicei.Entities.DTO;
using Ponal.Dinae.Estic.Sicei.Entities.InvInstitucional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponal.Dinae.Estic.Sicei.Business
{
    public class InvestigacionHandler
    {
        protected UOW uow { get; set; }
        public IEnumerable<InvestigacionDTO> ConsultarInvestigaciones()
        {
            using (uow = new UOW())
            {
                var resultado = uow.InvestigacionRepository.ConsultarInvestigaciones();
                return resultado;
            }
        }

        public Tuple<string,string> MergeInvestigacion(InvInstitucional investigacion)
        {
            using(uow = new UOW())
            {

                var resultado = uow.InvestigacionRepository.MergeInvestigacion(investigacion);
                if (resultado.Item1 != "")
                {
                    investigacion.IdInvestigacion = resultado.Item1;
                    foreach (var item in investigacion.AreaLinea)
                    {
                        uow.InvestigacionRepository.MergeAreaLineaInv(item, investigacion.IdInvestigacion);
                    }
                    foreach (var item in investigacion.Investigadores)
                    {
                        uow.InvestigacionRepository.MergeInvestigadoresInv(item, investigacion.IdInvestigacion);
                    }
                    foreach (var item in investigacion.Producto)
                    {
                        uow.InvestigacionRepository.MergeProductoInv(item, investigacion.IdInvestigacion);
                    }
                    uow.InvestigacionRepository.MergeEstimulosInv(investigacion.Estimulos, investigacion.IdInvestigacion);
                    uow.InvestigacionRepository.MergeEventosInv(investigacion.Eventos, investigacion.IdInvestigacion);
                    foreach (var item in investigacion.Presupuesto)
                    {
                        uow.InvestigacionRepository.MergePresupuestoInv(item, investigacion.IdInvestigacion);
                    }
                    
                } else {

                    return new Tuple<string, string>("0", "Error al crear la investigacion");
                }                                
                return  new Tuple<string, string>("1"," OK") ;
            }
        }

        public List<InvestigadorDTO> ConsultarInvestigadores()
        {
            using (uow = new UOW())
            {
                var resultado = uow.InvestigacionRepository.ConsultarInvestigadores().ToList();
                return resultado;
            }
        }

        public IEnumerable<Object> EliminarInvestigacionInstitucional(string investigacion)
        {
            using (uow = new UOW())
            {
                var resultado = uow.InvestigacionRepository.EliminaInvestigacion(investigacion);
                return resultado;
            }
        }

        public IEnumerable<InvestigacionInstitucionalDTO> ConsultarInvestigacionIns()
        {
            using (uow = new UOW())
            {
                var resultado = uow.InvestigacionRepository.ConsultarInvestigacionIns();
                return resultado;
            }
        }



        public IEnumerable<object> ConsultarCasosEmblem()
        {
            using (uow = new UOW())
            {
                var resultado = uow.CasoEmblemRepository.ConsultarCasosEmblem();
                return resultado;
            }
        }
 


    }
}
