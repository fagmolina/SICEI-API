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
    /// <summary>
    /// 
    /// </summary>
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/Usuario")]
    public class UsuarioController : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("ConsultaUsuarios")]
        public IHttpActionResult ConsultaUsuarios()
        {
            UsuarioHandler handler = new UsuarioHandler();
            return Content(HttpStatusCode.OK, handler.ConsultaUsuarios());

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("CrearModificarUsuario")]
        public IHttpActionResult CrearModificarUsuario([FromBody] UsuarioDTO user )
        {
            UsuarioHandler handler = new UsuarioHandler();
            return Content(HttpStatusCode.OK, handler.CrearModificarUsuario(user));

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("EliminarUsuario")]
        public IHttpActionResult EliminarUsuario(int id)
        {
            UsuarioHandler handler = new UsuarioHandler();
            return Content(HttpStatusCode.OK, handler.EliminarUsuario(id));

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
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