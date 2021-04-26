using EntityLayer.Service.SmS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Twilio.Clients;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace AdyMfb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SmsController : ControllerBase
    {
        private readonly ITwilioRestClient _client;
        public SmsController(ITwilioRestClient client)
        {
            _client = client;
        }

        //public IActionResult SendSms(SmsMessage model)
        //{
        //    var message = MessageResource.Create(
        //        to: new PhoneNumber(model.To),
        //        from: new PhoneNumber(model.From),
        //        body: model.Message,
        //        client: _client);


        //    return Ok("Success");
        //}
    }
}
