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
    [RoutePrefix("api/Investigadores")]
    public class InvestigadoresController : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("ConsultaInvestigadores")]
        public IHttpActionResult ConsultaInvestigadores()
        {
            InvestigadoresHandler handler = new InvestigadoresHandler();
            return Content(HttpStatusCode.OK, handler.ConsultaInvestigadores());

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="investigador"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("CrearModificarInvestigador")]
        public IHttpActionResult CrearModificarInvestigador([FromBody] InvestigadorDTO investigador)
        {
            InvestigadoresHandler handler = new InvestigadoresHandler();
            return Content(HttpStatusCode.OK, handler.CrearModificarInvestigador(investigador));

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("EliminarInvestigador")]
        public IHttpActionResult EliminarInvestigador(int id)
        {
            InvestigadoresHandler handler = new InvestigadoresHandler();
            return Content(HttpStatusCode.OK, handler.EliminarInvestigador(id));

        }
    }
}
