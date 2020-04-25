using Ponal.Dinae.Estic.Sicei.Business;
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
    [RoutePrefix("api/Redes")]
    public class RedesController : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("ConsultaRedes")]
        public IHttpActionResult ConsultaRedes()
        {
            RedInvestigacionHandler handler = new RedInvestigacionHandler();
            return Content(HttpStatusCode.OK, handler.ConsultaUsuarios());

        }
    }
}
