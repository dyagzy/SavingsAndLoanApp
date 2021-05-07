using EntityLayer.CustomerDetails;
using EntityLayer.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.CustomerRepository
{
    public interface ICustomerRepository
    {
     
        Task<CustomerDto> CreateCustomerAsync(CustomerDto customerDto);

        Task<CustomerDto> GetCustomer(string name);
        Task<CustomerDto> GetCustomer(string name , string phone , int? id);
        CustomerProfile GetCustomerById(CustomerProfile Id);
        Task<IEnumerable<SavingsAccountDto>> GetCustomerByPhoneNumber(string phone);
        Task<IEnumerable<CustomerListDto>> GetAll();

        //Update
        CustomerProfile UpdateCustomer(CustomerProfile Id);
       // CustomerProfile UpdateCustomer(CustomerProfile customerDetails);
        //Delete
        CustomerProfile DeleteCustomer(CustomerProfile name);

        SavingsAccount DepsoitFunds(decimal amount);
    }
}
