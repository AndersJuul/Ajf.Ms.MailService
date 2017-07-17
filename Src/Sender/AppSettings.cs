using Ajf.Nuget.Logging;

namespace Ajf.Ms.MailService.Sender
{
    public class AppSettings : ServiceSettingsFromConfigFile, IAppSettings
    {
        public AppSettings()
        {
            QueueName = $"{Environment}.{SuiteName}.MailsToSend";
            ExchangeName = $"{Environment}.{SuiteName}.MailsToSend";
        }

        public string ExchangeName { get; set; }

        public string QueueName { get; set; }
    }
}