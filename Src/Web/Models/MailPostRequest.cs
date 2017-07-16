using System;

namespace Ajf.Ms.MailService.Web.Models
{
    [Serializable]
    public class MailPostRequest
    {
        public string To;
        public string Subject;
        public string Cc;
        public string Body;
    }
}