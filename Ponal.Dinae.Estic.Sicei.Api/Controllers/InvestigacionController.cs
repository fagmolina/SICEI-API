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
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    /// <summary>
    /// 
    /// </summary>
    [RoutePrefix("api/Investigacion")]
    public class InvestigacionController : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("ConsultarInvestigaciones")]
        public IHttpActionResult ConsultarInvestigaciones()
        {
            InvestigacionHandler handler = new InvestigacionHandler();
            try
            {
                return Content(HttpStatusCode.OK, handler.ConsultarInvestigaciones());
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="investigacion"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("MergeInvestigacion")]
        public IHttpActionResult MergeInvestigacion(InvestigacionDTO investigacion)
        {
            InvestigacionHandler handler = new InvestigacionHandler();
            try
            {
                return Content(HttpStatusCode.OK, handler.MergeInvestigacion(investigacion));
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("ConsultarInvestigadores")]
        public IHttpActionResult ConsultarInvestigadores()
        {
            InvestigacionHandler handler = new InvestigacionHandler();
            try
            {
                return Content(HttpStatusCode.OK, handler.ConsultarInvestigadores());
            }
            catch(Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}