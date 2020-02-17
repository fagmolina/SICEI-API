using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Ponal.Dinae.Estic.Sicei.Api.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/casoEmblem")]
    public class CasoEmblematicoController : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("ConsultarCasosEmblem")]
        public IHttpActionResult ConsultarCasosEmblem()
        {
            CasoEmblematicoController handler = new CasoEmblematicoController();
            try
            {
                return Content(HttpStatusCode.OK, handler.ConsultarCasosEmblem());
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}