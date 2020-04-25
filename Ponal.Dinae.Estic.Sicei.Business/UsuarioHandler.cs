using Ponal.Dinae.Estic.Sicei.DataAccess.Base;
using Ponal.Dinae.Estic.Sicei.Entities;
using Ponal.Dinae.Estic.Sicei.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponal.Dinae.Estic.Sicei.Business
{
    public  class UsuarioHandler
    {

        protected UOW uow { get; set; }
        public IEnumerable<UsuarioDTO> ConsultaUsuarios()
        {
            using (uow = new UOW())
            {
                var resultado = uow.UsuarioRepository.ConsultaUsuarios();
                return resultado;
            }
        }

        public IEnumerable<ResultDTO> EliminarUsuario(int id)
        {
            using (uow = new UOW())
            {
                var resultado = uow.UsuarioRepository.eliminarUsuario(id);
                return resultado;
            }
        }


        public int Login(LoginRequest user)
        {
            using (uow = new UOW())
            {
                var resultado = uow.UsuarioRepository.Login(user);
                return resultado;
            }
        }


        public IEnumerable<ResultDTO> CrearModificarUsuario(UsuarioDTO  user)
        {
            using (uow = new UOW())
            {
                var resultado = uow.UsuarioRepository.crearModificarUsuario(user);
                return resultado;
            }
        }
    }
}
