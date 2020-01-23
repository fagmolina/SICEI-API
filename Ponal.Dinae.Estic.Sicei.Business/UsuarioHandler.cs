using Ponal.Dinae.Estic.Sicei.DataAccess.Base;
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


        public String CrearModificarUsuario(UsuarioDTO  user)
        {
            using (uow = new UOW())
            {
                var resultado = uow.UsuarioRepository.crearModificarUsuario(user);
                return resultado;
            }
        }
    }
}
