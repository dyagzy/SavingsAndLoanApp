using EntityLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdyMfb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var lead = new SavingsAccount();
            lead.AccountCreationDate = DateTime.Now;
            lead.AccountNumber = "4578906643";
            lead.IsActive = true;
            return Ok(lead);
                
        }
    }
}
