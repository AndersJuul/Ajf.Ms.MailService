using System.Web.Http;
using RabbitMQ.Client;
using Serilog;
using Web;

namespace Ajf.Ms.MailService.Web
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var appSettings = new AppSettings();
            Log.Logger = Nuget.Logging.StandardLoggerConfigurator.GetEnrichedLogger();

            Log.Logger.Information("Starting...");

            var connectioFa = new ConnectionFactory
            {
                HostName = "ajf-elastic-01",
                UserName = "anders",
                Password = "21Bananer"
            };

            var connection = connectioFa.CreateConnection();
            var model = connection.CreateModel();

            model.QueueDeclare(appSettings.QueueName, true, false, false);

            model.ExchangeDeclare(appSettings.ExchangeName, ExchangeType.Topic);

            model.QueueBind(appSettings.QueueName, appSettings.ExchangeName, "");

            Log.Logger.Information("Done setting up queue and exchange...");

            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
