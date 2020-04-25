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
    public class InvestigadorRepository : BaseRepository
    {
        public IEnumerable<InvestigadorDTO> ConsultaInvestigadores()
        {
            ProcedimientoParametroDTO parametro = new ProcedimientoParametroDTO();

            parametro.NombreProcedimiento = "PKG_CRUDS.PRC_GET_INVESTIGADOR";
            parametro.AdicionarParametro(":P_RESULTADO", null, DireccionParametro.Output, TipoParametro.RefCursor);
            var respuesta = EjecutarProcedure<InvestigadorDTO>(parametro);
            if (respuesta == null)
            {
                throw new Exception();
            }
            return respuesta;

        }


        public IEnumerable<ResultDTO> crearModificarInvestigador(InvestigadorDTO investigador)
        {
            ProcedimientoParametroDTO parametro = new ProcedimientoParametroDTO();
            parametro.NombreProcedimiento = "PKG_CRUDS.PRC_MERGE_INVESTIGADOR";
            parametro.AdicionarParametro(":p_id_investigador", investigador.ID_INVESTIGADOR, DireccionParametro.Input, TipoParametro.Int32);
            parametro.AdicionarParametro(":p_id_grado", investigador.ID_GRADO, DireccionParametro.Input, TipoParametro.Int32);
            parametro.AdicionarParametro(":p_documento", investigador.DOCUMENTO, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_nombres", investigador.NOMBRES, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_apellidos", investigador.APELLIDOS, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_email", investigador.EMAIL, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_telefono", investigador.TELEFONO, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_direccion", investigador.DIRECCION, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_estudios", investigador.ESTUDIOS, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_categorizado", investigador.CATEGORIZADO, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_categorizado_valor", investigador.CATEGORIZADO_VALOR, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_profesor", investigador.PROFESOR, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_estudiante", investigador.ESTUDIANTE, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_mensaje", null, DireccionParametro.Output, TipoParametro.RefCursor);

            var respuesta = EjecutarProcedure<ResultDTO>(parametro);
            if (respuesta == null)
            {
                throw new Exception();
            }
            return respuesta;

        }

        public IEnumerable<ResultDTO> eliminarInvestigador(int id)
        {
            ProcedimientoParametroDTO parametro = new ProcedimientoParametroDTO();
            parametro.NombreProcedimiento = "PKG_CRUDS.PRC_DELETE_INVESTIGADOR";
            parametro.AdicionarParametro(":p_id_investigador", id, DireccionParametro.Input, TipoParametro.Int32);
            parametro.AdicionarParametro(":p_resultado", null, DireccionParametro.Output, TipoParametro.RefCursor);

            var respuesta = EjecutarProcedure<ResultDTO>(parametro);
            if (respuesta == null)
            {
                throw new Exception();
            }
            return respuesta;
        }
    }
}
