using System.Web.Http;
using Ajf.Ms.MailService.Web.Models;

namespace Ajf.Ms.MailService.Web.Controllers
{
    public class MailController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Post(MailPostRequest mailPostRequest)
        {
            return Ok(mailPostRequest);
            //return Ok(new MailPostResponse());
        }
    }
}