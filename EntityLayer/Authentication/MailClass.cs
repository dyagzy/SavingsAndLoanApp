using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Authentication
{
    public class MailClass
    {
        public string FromMailId { get; set; } = "daniel.oyagha@gmail.com";
        public string FromMailIdPassword { get; set; } = "password";
        public List<string> ToMailIds { get; set; } = new List<string>();
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsBodyHtml { get; set; }
        public List<string> Attachments { get; set; } = new List<string>();

    }
}
