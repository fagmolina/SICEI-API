using Ponal.Dinae.Estic.Sicei.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ponal.Dinae.Estic.Sicei.Api.Controllers
{
    [RoutePrefix("api/Area")]
    public class AreaController : ApiController
    {

        [HttpGet]
        [Route("ConsultaAreas")]
        public IHttpActionResult ConsultaAreas()
        {
            AreaHandler handler = new AreaHandler();
            return Content(HttpStatusCode.OK, handler.ConsultaAreas());

        }

    }
}