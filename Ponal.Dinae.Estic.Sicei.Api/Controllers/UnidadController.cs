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
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/Unidad")]
    public class UnidadController : ApiController 
    {
        [HttpGet]
        [Route("ConsultaUnidades")]
        public IHttpActionResult ConsultaUnidades()
        {
            UnidadHandler handler = new UnidadHandler();
            return Content(HttpStatusCode.OK, handler.ConsultarUnidades());

        }
    }
}