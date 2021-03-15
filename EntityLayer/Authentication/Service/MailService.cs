using EntityLayer.Authentication.Common;
using EntityLayer.Authentication.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Authentication.Service
{
    public class MailService : IMailService
    {
        public string GetMailBody(LoginInfo oLoginInfo)
        {
            string url = Global.DomainName + "api/LoginInfo/ConfirmMail?username=" + oLoginInfo.UserName;
            return string.Format(@"<div style = 'text-align:center;'>  
                                    <h1> Welcome to Adyba Microfinance Bank </h1>
                                    <h3> Click here to verify your email Aaddress </h3>
                                    <form method = 'post'> action = '{0}' sytle = 'display: inline;'>
                                    <button type ='submit' style = 'display: block;
                                                                    text-align: center;
                                                                    font-weight: bold;
                                                                    background-color: #008CBA;
                                                                    font-size: 16px;
                                                                    border-radius: 10px;
                                                                    color-align: #ffffff;
                                                                    cursor-:pointer;
                                                                    width: 100%;
                                                                    padding:10px;>

                                    Confirm Mail
                                    </button>
                                    </form>
                                    </<div>", url,oLoginInfo.UserName);
        }





        public async Task<string> SendMail(MailClass oMailClass)
        {
            try
            {
                using(MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(oMailClass.FromMailId);
                    oMailClass.ToMailIds.ForEach(x =>
                    {
                        mail.To.Add(x);
                    });

                    mail.Subject = oMailClass.Subject;
                    mail.Body = oMailClass.Body;
                    mail.IsBodyHtml = oMailClass.IsBodyHtml;

                    oMailClass.Attachments.ForEach(x =>
                    {
                        mail.Attachments.Add( new Attachment(x));
                    });

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com"))
                    {
                        smtp.Credentials = new System.Net.NetworkCredential(oMailClass.FromMailId, oMailClass.FromMailIdPassword);
                        smtp.EnableSsl = true;

                       await  smtp.SendMailAsync(mail);
                        return Message.MailSent;
                    }

                }


            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
