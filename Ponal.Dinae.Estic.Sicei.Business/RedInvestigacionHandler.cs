using Ponal.Dinae.Estic.Sicei.DataAccess.Base;
using Ponal.Dinae.Estic.Sicei.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponal.Dinae.Estic.Sicei.Business
{
    public class RedInvestigacionHandler
    {
        protected UOW uow { get; set; }
        public bool MergeRedInvestigacion(RedInvestigacionBaseDTO red)
        {
            using (uow = new UOW())
            {
                try
                {
                    ResultDTO resultado = uow.RedInvestigacionRepository.MergeRedInvestigacion(red).ToList()[0];
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public IEnumerable<RedInvestigacionBaseDTO> ConsultaUsuarios()
        {
            using (uow = new UOW())
            {
                var resultado = uow.RedInvestigacionRepository.GetRedes();
                return resultado;
            }
        }
    }
}
