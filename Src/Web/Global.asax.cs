using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using Serilog;

namespace Web
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Log.Logger = Ajf.Nuget.Logging.StandardLoggerConfigurator.GetEnrichedLogger();

            Log.Logger.Information("Starting...");

            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
