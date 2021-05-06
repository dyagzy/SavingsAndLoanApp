using AutoMapper;
using EntityLayer.CustomerDetails;
using EntityLayer.CustomerRepository;
using EntityLayer.DataAccess;
using EntityLayer.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.CustomerRepositoryServices
{
    public class CustomerService : ICustomerRepository
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public CustomerService(ApplicationDbContext dbContext, IMapper mapper) 
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        //public async Task<CustomerDto> CreatCustomerAsync(CustomerProfile customer)
        //{
             
        //    var newCustomer = await _dbContext.AddAsync (customer);
        //    var newCustomerDto = _mapper.Map<CustomerDto>(newCustomer);
        //   await  _dbContext.SaveChangesAsync();
        //    return newCustomerDto;
            
        //}

        
        public async Task<CustomerDto> CreateCustomerAsync(CustomerDto customerDto)
        {
           var newCustomer = _mapper.Map<CustomerProfile>(customerDto);
            await  _dbContext.CustomerProfiles.AddAsync(newCustomer);
           await _dbContext.SaveChangesAsync();
           var convertedCustomerdto =  _mapper.Map<CustomerDto>(newCustomer);
            return convertedCustomerdto;
            
        }

        public CustomerProfile DeleteCustomer(CustomerProfile name)
        {
            throw new NotImplementedException();
        }

        //public SavingsAccount DepositFunds(decimal amount)
        //{
        //    decimal initBal = 0;
        //    decimal currentBal;
        //    currentBal = initBal + amount;
        //    //return CurrentBalance;

        //}

        public SavingsAccount DepsoitFunds(decimal amount)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CustomerListDto>> GetAll()
        {

            var customers = await (from myCust in _dbContext.CustomerProfiles
                             select new CustomerProfile
                                {
                                 FirstName = myCust.FirstName,
                                 SurName = myCust.SurName,
                                 Occupation = myCust.Occupation,
                                 Email = myCust.Email,
                                 PhoneNumber = myCust.PhoneNumber

                                }).ToListAsync();

            var allCustomer = _mapper.Map<IEnumerable<CustomerListDto>>(customers);

            //var allCustomers = await _dbContext.CustomerProfiles.ToListAsync();
            return allCustomer;

            //var customerList = (from customer in allCustomers
            //                    select new
            //                    {
            //                        customer.FirstName,
            //                        customer.SurName,
            //                        customer.Email,
            //                        customer.PhoneNumber,
            //                        customer.Occupation
                                    
            //                    }).ToListAsync();
            ////var allCustomer = _mapper.Map<IEnumerable<CustomerLsitDto>>(customerList);


            //return (IEnumerable<CustomerProfile>)customerList;
        }

        public CustomerProfile GetCustomerById(CustomerProfile Id)
        {
            throw new NotImplementedException();
        }

        public CustomerProfile GetCustomerByName(CustomerProfile name)
        {
            throw new NotImplementedException();
        }

        public CustomerProfile GetCustomerByPhoneNumber(CustomerProfile phonenumber)
        {
            throw new NotImplementedException();
        }

        public CustomerProfile UodateCustomer(CustomerProfile Id)
        {
            throw new NotImplementedException();
        }

        public CustomerProfile UpdateCustomer(CustomerProfile customerDetails)
        {
            throw new NotImplementedException();
        }

        //Task<CustomerProfile> ICustomerRepository.CreateCustomerAsync(CustomerProfile customer)
        //{
        //    throw new NotImplementedException();
        //}

       
    }
}
