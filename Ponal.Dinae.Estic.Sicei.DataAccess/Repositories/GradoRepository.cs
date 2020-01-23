using Ponal.Dinae.Estic.Sicei.Common.Enums;
using Ponal.Dinae.Estic.Sicei.DataAccess.Base;
using Ponal.Dinae.Estic.Sicei.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponal.Dinae.Estic.Sicei.DataAccess.Repositories
{
    public class GradoRepository : BaseRepository
    {

        public IEnumerable<GradoDTO> ConsultaGrados()
        {
            ProcedimientoParametroDTO parametro = new ProcedimientoParametroDTO();

            parametro.NombreProcedimiento = "PKG_CRUDS.prc_get_grado";


            parametro.AdicionarParametro(":P_RESULTADO", null, DireccionParametro.Output, TipoParametro.RefCursor);
            //parametro.AdicionarParametro(ConstantesModelo.V_error, null, DireccionParametro.Output, TipoParametro.Int32);
            //parametro.AdicionarParametro(ConstantesModelo.V_desc_error, null, DireccionParametro.Output, TipoParametro.Varchar2, 255);

            var respuesta = EjecutarProcedure<GradoDTO>(parametro);
            if (respuesta == null)
            {
                throw new Exception();
            }
            return respuesta;

        }
    }
}
