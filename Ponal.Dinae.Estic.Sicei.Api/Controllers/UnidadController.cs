using Ponal.Dinae.Estic.Sicei.Business;
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
    [RoutePrefix("api/Unidad")]
    public class UnidadController : ApiController 
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("ConsultaUnidades")]
        public IHttpActionResult ConsultaUnidades()
        {
            UnidadHandler handler = new UnidadHandler();
            return Content(HttpStatusCode.OK, handler.ConsultarUnidades());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("ConsultaEscuelas")]
        public IHttpActionResult ConsultaEscuelas()
        {
            UnidadHandler handler = new UnidadHandler();
            List<UnidadDTO> lstUnidades = handler.ConsultarUnidades().ToList();
            var escuelas = lstUnidades.Where(x => x.ID_TIPO == 1);
            return Content(HttpStatusCode.OK, escuelas);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("ConsultaDirecciones")]
        public IHttpActionResult ConsultaDirecciones()
        {
            UnidadHandler handler = new UnidadHandler();
            List<UnidadDTO> lstUnidades = handler.ConsultarUnidades().ToList();
            var escuelas = lstUnidades.Where(x => x.ID_TIPO == 2);
            return Content(HttpStatusCode.OK, escuelas);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("ConsultaTipos")]
        public IHttpActionResult ConsultaTipos()
        {
            UnidadHandler handler = new UnidadHandler();
            return Content(HttpStatusCode.OK, handler.ConsultaTipos());

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="unidad"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("MergeUnidad")]
        public IHttpActionResult MergeUnidad([FromBody] UnidadDTO unidad)
        {
            UnidadHandler handler = new UnidadHandler();
            return Content(HttpStatusCode.OK, handler.MergeUnidad(unidad));

        }
    }
}