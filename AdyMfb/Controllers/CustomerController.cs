using AutoMapper;
using EntityLayer.CustomerDetails;
using EntityLayer.CustomerRepository;
using EntityLayer.Dto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AdyMfb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _repository;
        private readonly IMapper _mapper;

        public CustomerController(ICustomerRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        // GET: api/<CustomerController>
       

        [HttpPost]
        public async Task<IActionResult> OpenAccount([FromBody] CustomerDto customerDto)
        {

            
           var customer = _mapper.Map<CustomerProfile>(customerDto);
           await _repository.CreateCustomerAsync(customer);
            return Ok(customer);
        }

    }
}
