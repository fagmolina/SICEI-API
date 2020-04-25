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
    public class UnidadRepository : BaseRepository 
    {

        public IEnumerable<UnidadDTO> ConsultaUnidades()
        {
            ProcedimientoParametroDTO parametro = new ProcedimientoParametroDTO();

            parametro.NombreProcedimiento = "PKG_CRUDS.PRC_GET_UNIDAD";


            parametro.AdicionarParametro(":P_RESULTADO", null, DireccionParametro.Output, TipoParametro.RefCursor);
            //parametro.AdicionarParametro(ConstantesModelo.V_error, null, DireccionParametro.Output, TipoParametro.Int32);
            //parametro.AdicionarParametro(ConstantesModelo.V_desc_error, null, DireccionParametro.Output, TipoParametro.Varchar2, 255);

            var respuesta = EjecutarProcedure<UnidadDTO>(parametro);            
            if (respuesta == null)
            {
                throw new Exception();
            }
            return respuesta;

        }

        public IEnumerable<TipoDTO> ConsultaTipos()
        {
            ProcedimientoParametroDTO parametro = new ProcedimientoParametroDTO();

            parametro.NombreProcedimiento = "PKG_CRUDS.PRC_GET_TIPO";


            parametro.AdicionarParametro(":P_RESULTADO", null, DireccionParametro.Output, TipoParametro.RefCursor);

            var respuesta = EjecutarProcedure<TipoDTO>(parametro);
            if (respuesta == null)
            {
                throw new Exception();
            }
            return respuesta;

        }

        public string MergeUnidad(UnidadDTO unidad)
        {
            ProcedimientoParametroDTO parametro = new ProcedimientoParametroDTO();

            parametro.NombreProcedimiento = "PKG_CRUDS.PRC_MERGE_UNIDAD";

            parametro.AdicionarParametro(":p_id_unidad", unidad.ID_UNIDAD, DireccionParametro.Input, TipoParametro.Decimal);
            parametro.AdicionarParametro(":p_sigla", unidad.SIGLA, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_descripcion", unidad.DESCRIPCION, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_id_tipo", unidad.ID_TIPO, DireccionParametro.Input, TipoParametro.Decimal);
            parametro.AdicionarParametro(":p_mensaje", null, DireccionParametro.Output, TipoParametro.RefCursor);

            EjecutarProcedure<RespuestaDTO>(parametro);

            string respuesta = parametro.ArregloParametros.Find(x => x.Nombre.Equals(":p_mensaje")).Valor.ToString();
            if (!respuesta.Equals("OK"))
            {
                throw new Exception();
            }
            return respuesta;

        }
    }
}
