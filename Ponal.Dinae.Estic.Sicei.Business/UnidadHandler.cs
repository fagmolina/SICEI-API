using Ponal.Dinae.Estic.Sicei.DataAccess.Base;
using Ponal.Dinae.Estic.Sicei.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponal.Dinae.Estic.Sicei.Business
{
    public class UnidadHandler
    {
        protected UOW uow { get; set; }
        public IEnumerable<UnidadDTO> ConsultarUnidades()
        {
            using (uow = new UOW())
            {
                var resultado = uow.Unidadrepository.ConsultaUnidades();
                return resultado;
            }
        }

    }
}
