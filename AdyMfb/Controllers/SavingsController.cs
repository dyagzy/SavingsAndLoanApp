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
            //try
            //{
            //    if (!ModelState.IsValid) NotFound();

            //    await _repository.WithdrawFunds(withdraw);
            //}
            //catch (Exception)
            //{

            //    return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            //}
            if (!ModelState.IsValid) NotFound();

            await _repository.WithdrawFunds(withdraw);
       


            return Ok(withdraw);
        }

        //[HttpGet("AllTransactionHistory")]
        //public async Task<ActionResult> GetAllHistory()
        //{
        //    try
        //    {
        //        return Ok(await _repository.GetAllTransactionHistory());
        //    }
        //    catch (Exception)
        //    {

        //        return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
        //    }

          
        //}

        [HttpGet("GetTransactionById")]
        public async Task<ActionResult> GetTransactionHistory(int transactionId)
        {
            if (!ModelState.IsValid) NotFound();
            try
            {
                var transactionHistory = await _repository.GetTransactionHistory(transactionId);
                if (transactionHistory == null)
                {
                    return NotFound();
                }
                return Ok(transactionHistory);
            }
            catch (Exception)
            {

               return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }

        }

        [HttpGet("GetTransactionByAmount")]
        public async Task<ActionResult> GetTransactionHistory(decimal amount)
        {

            if (!ModelState.IsValid) NotFound();
            try
            {
                var transactionHistoryByAmount = await _repository.GetTransactionHistory(amount);
                if (transactionHistoryByAmount == null)
                {
                    return NotFound();
                }
                return Ok(transactionHistoryByAmount);
            }
            catch (Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }

        }


        [HttpGet("AllTransactionHistory")]
        public async Task<ActionResult> GetTransactionHistory()
        {

            if (!ModelState.IsValid) NotFound();
            try
            {
                var alltransactionHistory = await _repository.GetAllTransactionHistory();
                if (alltransactionHistory == null)
                {
                    return NotFound();
                }
                return Ok(alltransactionHistory);
            }
            catch (Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }



        }




    }
}
