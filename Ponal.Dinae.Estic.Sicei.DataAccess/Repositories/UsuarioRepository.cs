using Ponal.Dinae.Estic.Sicei.Common.Enums;
using Ponal.Dinae.Estic.Sicei.DataAccess.Base;
using Ponal.Dinae.Estic.Sicei.Entities;
using Ponal.Dinae.Estic.Sicei.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponal.Dinae.Estic.Sicei.DataAccess.Repositories
{
    public class UsuarioRepository : BaseRepository
    {

        public IEnumerable<UsuarioDTO> ConsultaUsuarios()
        {
            ProcedimientoParametroDTO parametro = new ProcedimientoParametroDTO();

            parametro.NombreProcedimiento = "PKG_CRUDS.prc_get_usuarios";
            parametro.AdicionarParametro(":P_RESULTADO", null, DireccionParametro.Output, TipoParametro.RefCursor);
            var respuesta = EjecutarProcedure<UsuarioDTO>(parametro);
            if (respuesta == null)
            {
                throw new Exception();
            }
            return respuesta;

        }


        public int Login(LoginRequest user)
        {
            ProcedimientoParametroDTO parametro = new ProcedimientoParametroDTO();

            parametro.NombreProcedimiento = "PKG_LOGIN.prc_acceso";
            parametro.AdicionarParametro(":p_documento", user.Username, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_contrasena", user.Password, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_respuesta", null, DireccionParametro.Output, TipoParametro.Int32);
            var respuesta = EjecutarProcedure<Int32>(parametro);
            if (respuesta == null)
            {
                throw new Exception();
            }
            return respuesta.FirstOrDefault();

        }

        public IEnumerable<ResultDTO> crearModificarUsuario(UsuarioDTO user)
        {
            ProcedimientoParametroDTO parametro = new ProcedimientoParametroDTO();
            parametro.NombreProcedimiento = "PKG_CRUDS.PRC_MERGE_USUARIOS";
            parametro.AdicionarParametro(":p_id_usuario", user.ID_USUARIO, DireccionParametro.Input, TipoParametro.Int32);
            parametro.AdicionarParametro(":p_id_tipo_documento", user.ID_TIPO_DOCUMENTO, DireccionParametro.Input, TipoParametro.Int32);
            parametro.AdicionarParametro(":p_documento", user.DOCUMENTO, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_nombres", user.NOMBRES, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_apellidos", user.APELLIDOS, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_id_grado", user.ID_GRADO, DireccionParametro.Input, TipoParametro.Int32);
            parametro.AdicionarParametro(":p_id_unidad", user.ID_UNIDAD, DireccionParametro.Input, TipoParametro.Int32);
            parametro.AdicionarParametro(":p_email", user.EMAIL, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_contrasena", user.CONTRASENA, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_telefono", user.TELEFONO, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_usuario", user.USUARIO, DireccionParametro.Input, TipoParametro.Varchar2);
            parametro.AdicionarParametro(":p_perfil", user.PERFIL, DireccionParametro.Input, TipoParametro.Int32);
            parametro.AdicionarParametro(":p_resultado", null, DireccionParametro.Output, TipoParametro.RefCursor);

            var respuesta = EjecutarProcedure<ResultDTO>(parametro);
            if (respuesta == null)
            {
                throw new Exception();
            }
            return respuesta;

        }

        public IEnumerable<ResultDTO> eliminarUsuario(int id)
        {
            ProcedimientoParametroDTO parametro = new ProcedimientoParametroDTO();
            parametro.NombreProcedimiento = "PKG_CRUDS.PRC_DELETE_USUARIO";
            parametro.AdicionarParametro(":p_id_usuario", id, DireccionParametro.Input, TipoParametro.Int32);
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
