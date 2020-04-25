using Ponal.Dinae.Estic.Sicei.Business;
using Ponal.Dinae.Estic.Sicei.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Ponal.Dinae.Estic.Sicei.Api.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/redInves")]
    public class RedInvestigacionController: ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("MergeRedInvestigacion")]
        public IHttpActionResult MergeRedInvestigacion(RedInvestigacionBaseDTO red)
        {
            RedInvestigacionHandler handler = new RedInvestigacionHandler();
            try
            {
                return Content(HttpStatusCode.OK, handler.MergeRedInvestigacion(red));
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}