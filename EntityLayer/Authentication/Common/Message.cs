using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Authentication.Common
{
   public  class Message
    {
        public static string Success { get; set; } = "Succes";
        public static string ErrorFound { get; set; } = "Error found";
        public static string UserAllReadyCreated { get; set; } = "User already created please login";
        public static string VerifyMail { get; set; } = "User already created please verify your givem Gmail Id";
        public static string InvalidUser { get; set; } = "Invalid user please create account";
        public static string MailSent { get; set; } = "Mail sent";
        public static string UserCreatedVerifyEmial { get; set; } = "User all ready created verify email";
    }
}
