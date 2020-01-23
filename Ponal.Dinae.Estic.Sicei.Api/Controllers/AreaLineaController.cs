using Ponal.Dinae.Estic.Sicei.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ponal.Dinae.Estic.Sicei.Api.Controllers
{
    [RoutePrefix("api/AreaLinea")]
    public class AreaLineaController : ApiController
    {
        [HttpGet]
        [Route("ConsultaAreaLinea")]
        public IHttpActionResult ConsultaAreaLinea()
        {
            AreaLineaHandler handler = new AreaLineaHandler();
            return Content(HttpStatusCode.OK, handler.ConsultaAreaLinea());

        }
    }
}