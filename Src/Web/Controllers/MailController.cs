using System.Text;
using System.Web.Http;
using Ajf.Ms.MailService.Web.Models;
using RabbitMQ.Client;

namespace Ajf.Ms.MailService.Web.Controllers
{
    public class MailController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Post(MailPostRequest mailPostRequest)
        {
            var appSettings = new AppSettings();
            var connectioFa = new ConnectionFactory
            {
                HostName = "ajf-elastic-01",
                UserName = "anders",
                Password = "21Bananer"
            };

            var connection = connectioFa.CreateConnection();
            var model = connection.CreateModel();

            var properties = model.CreateBasicProperties();
            properties.Persistent = true;
            
            var messageBuffer = Encoding.Default.GetBytes("Hello");

            model.BasicPublish(appSettings.ExchangeName,appSettings.QueueName,properties,messageBuffer);

            return Ok(mailPostRequest);
            //return Ok(new MailPostResponse());
        }
    }
}