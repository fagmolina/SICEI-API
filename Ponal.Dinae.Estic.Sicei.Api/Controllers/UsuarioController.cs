using Ponal.Dinae.Estic.Sicei.Business;
using Ponal.Dinae.Estic.Sicei.Entities;
using Ponal.Dinae.Estic.Sicei.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Ponal.Dinae.Estic.Sicei.Api.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/Usuario")]
    public class UsuarioController : ApiController
    {
        [HttpGet]
        [Route("ConsultaUsuarios")]
        public IHttpActionResult ConsultaUsuarios()
        {
            UsuarioHandler handler = new UsuarioHandler();
            return Content(HttpStatusCode.OK, handler.ConsultaUsuarios());

        }


        [HttpPost]
        [Route("CrearModificarUsuario")]
        public IHttpActionResult CrearModificarUsuario([FromBody] UsuarioDTO user )
        {
            UsuarioHandler handler = new UsuarioHandler();
            return Content(HttpStatusCode.OK, handler.CrearModificarUsuario(user));

        }


        [HttpPost]
        [Route("Login")]
        public IHttpActionResult Login([FromBody] LoginRequest user)
        {
            UsuarioHandler handler = new UsuarioHandler();
            List<UsuarioDTO> users = handler.ConsultaUsuarios().ToList();
            var usuario = users.Find(x => x.USUARIO == user.Username && x.CONTRASENA == user.Password);
            return Content(HttpStatusCode.OK, usuario);

        }

    }
}