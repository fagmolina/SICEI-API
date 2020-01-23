using Ponal.Dinae.Estic.Sicei.Business;
using Ponal.Dinae.Estic.Sicei.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ponal.Dinae.Estic.Sicei.Api.Controllers
{
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
    }
}