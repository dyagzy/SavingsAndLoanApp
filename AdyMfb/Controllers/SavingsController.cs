using EntityLayer;
using EntityLayer.Dto;
using EntityLayer.SavingsRepository.ISavingsRepositorys;
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
    public class SavingsController : ControllerBase
    {
        private readonly ISavingsRepository _repository;

        public SavingsController(ISavingsRepository repository)
        {
           _repository = repository;
        }

        [HttpPost("OpenSavingsAccount")]

        public async Task<ActionResult<SavingsAccountDto>> OpenSavingsAccount([FromBody] SavingsAccountDto savingsDto)
        {
            if (ModelState.IsValid)
            {
                await _repository.OpenSavingsAccount(savingsDto);
            }

            return new JsonResult(savingsDto);

            
        }


        [HttpPost("Deposit")]
        public async Task<ActionResult<DepositDto>> DepositFunds([FromBody] DepositDto deposit)
        {
            if (ModelState.IsValid)
            {
                await _repository.SaveMoney(deposit);
            }

            return Ok(deposit);
        }

        [HttpPost("WithdrawMoney")]
        public async Task<ActionResult<DepositDto>> Withdraws([FromBody] WithdrawDto withdraw)
        {
            if (ModelState.IsValid)
            {
                await _repository.WithdrawFunds(withdraw);
            }
           
            return Ok(withdraw);
        }

        [HttpGet("TransactionHistory")]
        public async Task<ActionResult> GetBalance()
        {
            return new JsonResult(await _repository.GetAllTransactionHistory());
        }




    }
}
