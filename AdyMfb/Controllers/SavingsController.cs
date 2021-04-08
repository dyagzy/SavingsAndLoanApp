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

        [HttpPost]

        public async Task<ActionResult<SavingsAccountDto>> OpenSavingsAccount([FromBody] SavingsAccountDto savingsDto)
        {
           await  _repository.OpenSavingsAccount(savingsDto);

            return Ok( savingsDto);
        }


        //[HttpPost]
        //public async Task<ActionResult<CustomerDto>> OpenAccount2([FromBody] CustomerDto customerDto)
        //{
        //    var customer = await _repository.CreateCustomerAsync(customerDto);
        //    return Ok(customer);
        //}


    }
}
