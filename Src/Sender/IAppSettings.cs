namespace Ajf.Ms.MailService.Sender
{
    public interface IAppSettings
    {
        string ExchangeName { get; set; }
        string QueueName { get; set; }
    }
}