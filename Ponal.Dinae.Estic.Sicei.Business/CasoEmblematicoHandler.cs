using Ponal.Dinae.Estic.Sicei.DataAccess.Base;
using Ponal.Dinae.Estic.Sicei.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponal.Dinae.Estic.Sicei.Business
{
    public class CasoEmblematicoHandler
    {
        protected UOW uow { get; set; }
        public IEnumerable<object> ConsultarCasosEmblem()
        {
            using (uow = new UOW())
            {
                var resultado = uow.CasoEmblemRepository.ConsultarCasosEmblem();
                return resultado;
            }
        }

        public bool MergeCasoEmblematico(CasoEmblematicoBaseDTO caso)
        {
            using (uow = new UOW())
            {
                try
                {
                    ResultDTO resultado = uow.CasoEmblemRepository.MergeCasoEmblematico(caso).ToList()[0];
                    if (resultado.codigo > 1)
                    {
                        foreach (int id in caso.INVESTIGADORES)
                        {
                            var resultadoInv = uow.CasoEmblemRepository.MergeCasoEmbInv(resultado.codigo, id);
                        }
                    }
                    return true;
                }catch(Exception ex)
                {
                    return false;
                }
            }
        }
    }
}