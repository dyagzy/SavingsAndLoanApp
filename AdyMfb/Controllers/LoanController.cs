using EntityLayer.Dto;
using EntityLayer.LoanRepository;
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
        private readonly ILoanService _loanService;

        public LoanController(ILoanService loanService)
        {
            _loanService = loanService;
        }


        [HttpPost("ApplyforLoan")]
        public async Task< ActionResult<LoanDto>> ApplyforLoan([FromBody] LoanDto loanDto)
        {
            var loan = await _loanService.CreateLoan(loanDto);
            return Ok(loan);

        }

        [HttpGet("interest")]
        public IActionResult CalculateLoan()
        {
            return null;
        }
    }
}

   
