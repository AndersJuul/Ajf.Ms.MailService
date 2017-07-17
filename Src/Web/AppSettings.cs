using System.Configuration;
using Ajf.Nuget.Logging;

namespace Ajf.Ms.MailService.Web
{
    public class AppSettings : WebSettingsFromConfigFile, IAppSettings
    {
        public AppSettings()
        {
            QueueName = $"{Environment}.{SuiteName}.MailsToSend";
            ExchangeName = "";// $"{Environment}.{SuiteName}.MailsToSend";
        }

        public string ExchangeName { get; set; }

        public string QueueName { get; set; }
    }
}