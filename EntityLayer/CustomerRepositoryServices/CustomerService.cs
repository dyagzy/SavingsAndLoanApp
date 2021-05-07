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

            var customers = await (from cuustomer in _dbContext.CustomerProfiles
                                   select new CustomerProfile
                                   {
                                       FirstName = cuustomer.FirstName,
                                       SurName = cuustomer.SurName,
                                       Occupation = cuustomer.Occupation,
                                       Email = cuustomer.Email,
                                       PhoneNumber = cuustomer.PhoneNumber

                                   }).ToListAsync();

            var allCustomer = _mapper.Map<IEnumerable<CustomerListDto>>(customers);


            return allCustomer;


        }

        public async Task<CustomerDto> GetCustomer(string  name , string  phone , int? customerId)
        {
            var customerSearched = new CustomerDto();
            if (!String.IsNullOrEmpty(name) || !String.IsNullOrEmpty(phone) || customerId.HasValue)
            {

               var customers = await (from customer in _dbContext.CustomerProfiles where
                  customer.Id == customerId || customer.PhoneNumber == phone || customer.FirstName == name
                  || customer.SurName == name select customer).ToListAsync();
                
                 customerSearched = _mapper.Map<CustomerDto>(customers);
            }
            return customerSearched;



            // )
            //_dbContext.CustomerProfiles
            //    .Where(c => c.Id == id || c.PhoneNumber == phone || c.FirstName == name || c.SurName == name)
            //    .Select( c => c.FirstName, )



        }

        public async Task<IEnumerable<SavingsAccountDto>> GetCustomerByPhoneNumber(string phone)
        {
            if (String.IsNullOrEmpty(phone))
            {
                
            }
            if (_dbContext.CustomerProfiles.Any(c => c.PhoneNumber != phone))
            {
                throw new NotImplementedException();
            }

            var customer = await _dbContext.CustomerProfiles.Where(c => c.PhoneNumber == phone)
                           .Select(c => c.SavingsAccounts).OrderBy(c => c.AccountNumber).FirstOrDefaultAsync();

            var allCustomer = _mapper.Map<IEnumerable<SavingsAccountDto>>(customer);
            return allCustomer;


        }



        public CustomerProfile GetCustomerById(CustomerProfile Id)
        {
            throw new NotImplementedException();
        }

        Task<CustomerDto> GetCustomer(string name)
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

        Task<CustomerDto> ICustomerRepository.GetCustomer(string name)
        {
            throw new NotImplementedException();
        }

        

        //Task<CustomerProfile> ICustomerRepository.CreateCustomerAsync(CustomerProfile customer)
        //{
        //    throw new NotImplementedException();
        //}


    }
}
