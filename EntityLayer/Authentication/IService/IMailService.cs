using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Authentication.IService
{
   public interface IMailService
    {
        Task<string> SendMail(MailClass oMailClass);
        string GetMailBody(LoginInfo oLoginInfo);
    }
}
