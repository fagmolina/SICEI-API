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
    public class CasoEmblematicoRepository: BaseRepository
    {
        public List<CasoEmblematicoDTO> ConsultarCasosEmblem()
        {
            ProcedimientoParametroDTO parametro = new ProcedimientoParametroDTO();

            parametro.NombreProcedimiento = "PKG_CRUDS_ADIC.prc_get_caso_emblematico";

            parametro.AdicionarParametro(":p_id_caso", null, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_resultado", null, DireccionParametro.Output, TipoParametro.RefCursor);

            var respuesta = EjecutarProcedure<CasoEmblematicoDTO>(parametro).ToList();
            if (respuesta == null)
            {
                throw new Exception();
            }
            return respuesta;
        }

        public IEnumerable<ResultDTO> MergeCasoEmblematico(CasoEmblematicoBaseDTO caso)
        {
            ProcedimientoParametroDTO parametro = new ProcedimientoParametroDTO();

            parametro.NombreProcedimiento = "PKG_CRUDS_ADIC.prc_merge_caso_emblematico";

            parametro.AdicionarParametro(":p_id_caso", caso.ID_CASO, DireccionParametro.Input, TipoParametro.Int32);
            parametro.AdicionarParametro(":p_nombre_caso", caso.NOMBRE_CASO, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_lugar_afectacion", caso.LUGAR_AFECTACION, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_actividades", caso.ACTIVIDADES, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_mensaje", null, DireccionParametro.Output, TipoParametro.RefCursor);

            var respuesta = EjecutarProcedure<ResultDTO>(parametro);
            if (respuesta == null)
            {
                throw new Exception();
            }
            return respuesta;
        }

        public IEnumerable<ResultDTO> MergeCasoEmbInv(decimal idCaso, int idInvestigador)
        {
            ProcedimientoParametroDTO parametro = new ProcedimientoParametroDTO();

            parametro.NombreProcedimiento = "PKG_CRUDS_ADIC.prc_merge_caso_emb_inv";

            parametro.AdicionarParametro(":p_id_caso", idCaso, DireccionParametro.Input, TipoParametro.Decimal);
            parametro.AdicionarParametro(":p_id_investigador", idInvestigador, DireccionParametro.Input, TipoParametro.Int32);
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
