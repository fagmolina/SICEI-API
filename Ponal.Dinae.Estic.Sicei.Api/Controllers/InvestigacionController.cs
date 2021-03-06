﻿using Ponal.Dinae.Estic.Sicei.Business;
using Ponal.Dinae.Estic.Sicei.Entities.DTO;
using Ponal.Dinae.Estic.Sicei.Entities.InvInstitucional;
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
        public IHttpActionResult MergeInvestigacion([FromBody] InvInstitucional investigacion)
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
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.Message);
            }
        }



        [HttpDelete]
        [Route("EliminarInvestigacionInstitucional")]
        public IHttpActionResult EliminarInvestigacionInstitucional(string investigacion)
        {
            InvestigacionHandler handler = new InvestigacionHandler();
            try
            {
                return Content(HttpStatusCode.OK, handler.EliminarInvestigacionInstitucional(investigacion));
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [HttpGet]
        [Route("ConsultarInvestigacionesIns")]
        public IHttpActionResult ConsultarInvestigacionesIns()
        {
            InvestigacionHandler handler = new InvestigacionHandler();
            try
            {
                return Content(HttpStatusCode.OK, handler.ConsultarInvestigacionIns());
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


    }
}