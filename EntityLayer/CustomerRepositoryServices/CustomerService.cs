using EntityLayer.CustomerDetails;
using EntityLayer.CustomerRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.CustomerRepositoryServices
{
    public class CustomerService : ICustomerRepository
    {
        public CustomerProfile CreatCustomer(CustomerProfile customerdetials)
        {
            throw new NotImplementedException();
        }

        public CustomerProfile CreateCustomer(CustomerProfile customerdetials)
        {
            throw new NotImplementedException();
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

        public CustomerProfile GetAll()
        {
            throw new NotImplementedException();
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
    }
}
