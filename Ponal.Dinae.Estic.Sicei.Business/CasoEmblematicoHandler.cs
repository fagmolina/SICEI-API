using Ponal.Dinae.Estic.Sicei.DataAccess.Base;
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
            using(uow = new UOW())
            {
                var resultado = uow.CasoEmblemRepository.ConsultarCasosEmblem();
                return resultado;
            }
        }
    }
}
