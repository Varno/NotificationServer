using Microsoft.Owin;
using Microsoft.Owin.Extensions;
using NotificationService.Web;
using NotificationService.Web.App_Start;
using Owin;
using System.Web.Http;

[assembly: OwinStartup(typeof(Startup))]
namespace NotificationService.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            SwaggerConfig.Register(config);
            WebApiConfig.Register(config);

            app.UseWebApi(config);
            app.UseStageMarker(PipelineStage.MapHandler);
        }
    }
}