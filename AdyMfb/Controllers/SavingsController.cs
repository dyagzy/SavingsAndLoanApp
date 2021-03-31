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


        //[HttpGet]
        //public IActionResult GetSavings()
        //{
        //    var savings= _repository.GetAllSavingsAccount();
        //    return Ok(savings);
        //}

        //[HttpPost]
        //public async Task<IActionResult> CreateSavings()
        //{
        //    var savings = await _repository.GetAllSavingsAccount();
        //    await _repository.SaveAllChangesAsync();
        //    return Ok(savings);
        //}
    }
}
