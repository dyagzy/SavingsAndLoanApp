using EntityLayer.CustomerDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.CustomerRepository
{
    public interface ICustomerRepository
    {
        //CRUD
        //create 
        CustomerProfile CreateCustomer(CustomerProfile customerdetials);

        //Read .... GetbyName, GetById, GetAll

        CustomerProfile GetCustomerByName(CustomerProfile name);
        CustomerProfile GetCustomerById(CustomerProfile Id);
        CustomerProfile GetCustomerByPhoneNumber(CustomerProfile phonenumber);
        CustomerProfile GetAll();

        //Update
        CustomerProfile UpdateCustomer(CustomerProfile Id);
       // CustomerProfile UpdateCustomer(CustomerProfile customerDetails);
        //Delete
        CustomerProfile DeleteCustomer(CustomerProfile name);

        SavingsAccount DepsoitFunds(decimal amount);
    }
}
