using System.Web.Http;
using WebActivatorEx;
using Ponal.Dinae.Estic.Sicei.Api;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace Ponal.Dinae.Estic.Sicei.Api
{
    /// <summary>
    /// 
    /// </summary>
    public class SwaggerConfig
    {
        /// <summary>
        /// 
        /// </summary>
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
              .EnableSwagger(c =>
              {
                  c.SingleApiVersion("v1", "API Sistema de Información, Ciencia e Innovación");                  
                  c.IncludeXmlComments(string.Format(@"{0}\bin\Ponal.Dinae.Estic.Sicei.Api.xml",
                                       System.AppDomain.CurrentDomain.BaseDirectory));
              })
              .EnableSwaggerUi();
        }
    }
}
