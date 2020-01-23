using Ponal.Dinae.Estic.Sicei.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ponal.Dinae.Estic.Sicei.Api.Controllers
{
    [RoutePrefix("api/Grado")]
    public class GradoController : ApiController
    {
        [HttpGet]
        [Route("ConsultaGrados")]
        public IHttpActionResult ConsultaGrados()
        {
            GradoHandler handler = new GradoHandler();
            return Content(HttpStatusCode.OK, handler.ConsultaGrados());

        }
    }
}