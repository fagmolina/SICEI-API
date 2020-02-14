using Ponal.Dinae.Estic.Sicei.DataAccess.Base;
using Ponal.Dinae.Estic.Sicei.Entities.DTO;
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

        public IEnumerable<string> MergeInvestigacion(InvestigacionDTO investigacion)
        {
            using(uow = new UOW())
            {
                var resultado = uow.InvestigacionRepository.MergeInvestigacion(investigacion);
                return resultado;
            }
        }

        public IEnumerable<InvestigadorDTO> ConsultarInvestigadores()
        {
            using (uow = new UOW())
            {
                var resultado = uow.InvestigacionRepository.ConsultarInvestigadores();
                return resultado;
            }
        }
    }
}
