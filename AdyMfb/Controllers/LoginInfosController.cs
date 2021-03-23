using EntityLayer.Authentication;
using EntityLayer.Authentication.Common;
using EntityLayer.Authentication.IService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

<<<<<<< HEAD
namespace AdyMfb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginInfosController : ControllerBase
    {
        private readonly ILoginService _loginService;
        private readonly IMailService _mailService;

        public LoginInfosController(ILoginService loginService, IMailService mailService )
        {
            _loginService = loginService;
            _mailService = mailService;
        }


        // POST api/<LoginInfosController>
        [AllowAnonymous]
        [HttpPost("Signup")]
        public async Task<IActionResult>  SignUp([FromBody] LoginInfo oLoginInfo)
        {
            string sMessage = "";
            var user = await _loginService.SignUp(oLoginInfo);
            if (user == null) return BadRequest(new { message = Message.ErrorFound});
            if (user.Message == Message.VerifyMail)
            {
                MailClass oMailClass = this.GetMailObject(user);
                await _mailService.SendMail(oMailClass);
                return BadRequest(new {  message = Message.VerifyMail});

            }
            #region Send Confirmation Email
            if (user.Message == Message.Success)
            {
                MailClass oMailClass = this.GetMailObject(user);
                sMessage = await _mailService.SendMail(oMailClass);

            }
            if (sMessage != Message.MailSent) return BadRequest(new { message = sMessage });
            else return Ok(new { message = Message.UserCreatedVerifyEmial });


            
            #endregion

        }


        [AllowAnonymous]
        [HttpPost("ConfirmMail")]
        public async Task<IActionResult> ConfirmMail(string username)
        {
            string sMessage = await _loginService.ConfirmMail(username);
            return Ok(new {  message = sMessage});
        }
        public MailClass GetMailObject(LoginInfo user)
        {
            MailClass oMailClass = new MailClass();
            oMailClass.Subject = "Mail Confiremed";
            oMailClass.Body = _mailService.GetMailBody(user);
            oMailClass.ToMailIds = new List<string>()
                {
                    user.EmailId
                };
            return oMailClass;

        }

        // PUT api/<LoginInfosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LoginInfosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
=======
//namespace AdyMfb.Controllers
//{
//    [Route("api/[controller]/")]
//    [ApiController]
//    public class LoginInfosController : ControllerBase
//    {
//        private readonly ILoginService _loginService;
//        private readonly IMailService _mailService;

//        public LoginInfosController(ILoginService loginService, IMailService mailService)
//        {
//            _loginService = loginService;
//            _mailService = mailService;
//        }


//        // POST api/<LoginInfosController>
//        [AllowAnonymous]
//        [HttpPost("Signup")]
//        public async Task<IActionResult> SignUp([FromBody] LoginInfo oLoginInfo)
//        {
//            string sMessage = "";
//            var user = await _loginService.SignUp(oLoginInfo);
//            if (user == null) return BadRequest(new { message = Message.ErrorFound });
//            if (user.Message == Message.VerifyMail)
//            {
//                MailClass oMailClass = GetMailObject(user);
//                await _mailService.SendMail(oMailClass);
//                return BadRequest(new { message = Message.VerifyMail });

//            }
//            #region Send Confirmation Email
//            if (user.Message == Message.Success)
//            {
//                MailClass oMailClass = GetMailObject(user);
//                sMessage = await _mailService.SendMail(oMailClass);

//            }
//            if (sMessage != Message.MailSent) return BadRequest(new { message = sMessage });
//            else return Ok(new { message = Message.UserCreatedVerifyEmial });



//            #endregion

//        }


//        [AllowAnonymous]
//        [HttpPost("ConfirmMail")]
//        public async Task<IActionResult> ConfirmMail(string username)
//        {
//            string sMessage = await _loginService.ConfirmMail(username);
//            return Ok(new { message = sMessage });
//        }
//        private MailClass GetMailObject(LoginInfo user)
//        {
//            MailClass oMailClass = new MailClass();
//            oMailClass.Subject = "Mail Confiremed";
//            oMailClass.Body = _mailService.GetMailBody(user);
//            oMailClass.ToMailIds = new List<string>()
//                {
//                    user.EmailId
//                };
//            return oMailClass;

//        }

//        // PUT api/<LoginInfosController>/5
//        [HttpPut("{id}")]
//        public void Put(int id, [FromBody] string value)
//        {
//        }

//        // DELETE api/<LoginInfosController>/5
//        [HttpDelete("{id}")]
//        public void Delete(int id)
//        {
//        }
//    }
//}
>>>>>>> c25a47e37451c557c00693761f6a5f67f92fba30
