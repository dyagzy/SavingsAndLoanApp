using AutoMapper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio.Clients;
using Twilio.Http;

namespace EntityLayer.Service.SmS
{
    public class TwilioClient 
    {
        private readonly ITwilioRestClient _innerClient;
        //public TwilioClient(IConfiguration config, SystemHttpClient httpClient)
        //{
        //    httpClient.DefaultRequestHeaders.Add("X-Custom-Header", "CustomTwilioRestClient-Demo");
        //    _innerClient = new TwilioRestClient(
        //        config["Twilio:AccountSid"],
        //        config["Twilio: AuthToken"],
        //        httpClient: new SystemNetHttpClient(httpClient));

        //}

        //public string AccountSid => _innerClient.AccountSid;

        //public string Region => _innerClient.Region;

        //public Twilio.Http.HttpClient HttpClient =>  _innerClient.HttpClient;

        //public Response Request(Request request) => _innerClient.Request(request);

        //public Task<Response> RequestAsync(Request request) => _innerClient.RequestAsync(request);
        
    }
}
