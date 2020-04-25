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
    public class InvestigacionRepository : BaseRepository
    {
        public IEnumerable<InvestigacionDTO> ConsultarInvestigaciones()
        {
            ProcedimientoParametroDTO parametro = new ProcedimientoParametroDTO();

            parametro.NombreProcedimiento = "PKG_CRUDS.prc_get_investigacion";


            parametro.AdicionarParametro(":P_RESULTADO", null, DireccionParametro.Output, TipoParametro.RefCursor);

            var respuesta = EjecutarProcedure<InvestigacionDTO>(parametro);
            if (respuesta == null)
            {
                throw new Exception();
            }
            return respuesta;
        }

        public IEnumerable<string> MergeInvestigacion(InvestigacionDTO investigacion)
        {
            ProcedimientoParametroDTO parametro = new ProcedimientoParametroDTO();

            parametro.NombreProcedimiento = "PKG_CRUDS.prc_merge_investigacion";

            parametro.AdicionarParametro(":p_id_investigacion", investigacion.ID_INVESTIGACION, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_titulo", investigacion.TITULO, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_direccion", investigacion.DIRECCION, DireccionParametro.Input, TipoParametro.Decimal);
            parametro.AdicionarParametro(":p_ano", investigacion.ANO, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_participacion", investigacion.PARTICIPACION, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_exp_participa", investigacion.EXP_PARTICIPA, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_escuela", investigacion.ESCUELA, DireccionParametro.Input, TipoParametro.Decimal);
            parametro.AdicionarParametro(":p_mensaje", null, DireccionParametro.Output, TipoParametro.RefCursor);

            var respuesta = EjecutarProcedure<string>(parametro);
            if (respuesta == null)
            {
                throw new Exception();
            }
            return respuesta;
        }

        public IEnumerable<InvestigadorDTO> ConsultarInvestigadores()
        {
            ProcedimientoParametroDTO parametro = new ProcedimientoParametroDTO();

            parametro.NombreProcedimiento = "PKG_CRUDS.prc_get_investigador";


            parametro.AdicionarParametro(":p_resultado", null, DireccionParametro.Output, TipoParametro.RefCursor);

            var respuesta = EjecutarProcedure<InvestigadorDTO>(parametro);
            if (respuesta == null)
            {
                throw new Exception();
            }
            return respuesta;
        }
    }
}
