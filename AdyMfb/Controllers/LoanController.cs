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
    public class LoanController : ControllerBase
    {
        public LoanController()
        {

        }


        [HttpGet("interest")]
        public IActionResult CalculateLoan()
        {
            return null;
        }
    }
}

   
