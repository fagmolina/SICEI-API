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
    public class RedInvestigacionRepository: BaseRepository
    {
        public IEnumerable<ResultDTO> MergeRedInvestigacion(RedInvestigacionBaseDTO red)
        {
            ProcedimientoParametroDTO parametro = new ProcedimientoParametroDTO();

            parametro.NombreProcedimiento = "PKG_CRUDS_ADIC.prc_merge_red_investigacion";

            parametro.AdicionarParametro(":p_id_red", red.ID_RED, DireccionParametro.Input, TipoParametro.Int32);
            parametro.AdicionarParametro(":p_nombre_red", red.NOMBRE_RED, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_entidad", red.ENTIDAD, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_ano_creacion", red.ANO_CREACION, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_sede_depto", red.SEDE_DEPTO, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_sede_ciudad", red.SEDE_CIUDAD, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_mensaje", null, DireccionParametro.Output, TipoParametro.RefCursor);

            var respuesta = EjecutarProcedure<ResultDTO>(parametro);
            if (respuesta == null)
            {
                throw new Exception();
            }
            return respuesta;
        }
    }
}
