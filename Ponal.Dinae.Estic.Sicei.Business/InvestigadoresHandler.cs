using Ponal.Dinae.Estic.Sicei.DataAccess.Base;
using Ponal.Dinae.Estic.Sicei.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponal.Dinae.Estic.Sicei.Business
{
    public class InvestigadoresHandler
    {
        protected UOW uow { get; set; }
        public IEnumerable<InvestigadorDTO> ConsultaInvestigadores()
        {
            using (uow = new UOW())
            {
                var resultado = uow.InvestigadorRepository.ConsultaInvestigadores();
                return resultado;
            }
        }

        public IEnumerable<ResultDTO> EliminarInvestigador(int id)
        {
            using (uow = new UOW())
            {
                var resultado = uow.InvestigadorRepository.eliminarInvestigador(id);
                return resultado;
            }
        }

        public IEnumerable<ResultDTO> CrearModificarInvestigador(InvestigadorDTO investigador)
        {
            using (uow = new UOW())
            {
                var resultado = uow.InvestigadorRepository.crearModificarInvestigador(investigador);
                return resultado;
            }
        }

    }
}
