using System.Configuration;
using Ajf.Nuget.Logging;

namespace Ajf.Ms.MailService.Web
{
    public class AppSettings : SettingsFromConfigFile, IAppSettings
    {
        public AppSettings()
        {
            QueueName = $"{Environment}.{SuiteName}.{ComponentName}.MailsToSend";
            ExchangeName = $"{Environment}.{SuiteName}.{ComponentName}.MailsToSend";
        }

        public string ExchangeName { get; set; }

        public string QueueName { get; set; }
    }
}