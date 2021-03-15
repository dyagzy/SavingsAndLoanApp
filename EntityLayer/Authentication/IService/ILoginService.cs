using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Authentication.IService
{
   public interface ILoginService
    {
        Task<LoginInfo> SignUp(LoginInfo oLoginInfo);
        Task<string> ConfirmPassword(string username);
    }
}
