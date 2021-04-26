﻿using AutoMapper;
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
       

        //[HttpPost]
        //public async Task<ActionResult<CustomerProfile>> OpenAccount([FromBody] CustomerDto customerDto)
        //{
        //    CustomerProfile nn = new CustomerProfile();
        //  var myMap =   _mapper.Map(customerDto, nn);
        //   //var customer = _mapper.Map<CustomerProfile>(customerDto);
        //   await _repository.CreateCustomerAsync(myMap);
        //    return Ok(myMap);
        //}

        [HttpPost]
        public async Task<ActionResult<CustomerDto>> OpenAccount2([FromBody] CustomerDto customerDto)
        {
           var customer =   await _repository.CreateCustomerAsync(customerDto);
            return Ok(customer);
        }

    }
}
