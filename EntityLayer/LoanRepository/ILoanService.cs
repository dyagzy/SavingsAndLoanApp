using EntityLayer.CustomerDetails;
using EntityLayer.Loans;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.LoanRepository
{
    public interface ILoanService
    {
     
       
        Task<IEnumerable<Loan>> GetLoanByAmount(decimal amount);
        Task<Loan> GetLoanById(int loandId);
        Task<IEnumerable<Loan>> GetAllLoan();
        Task<IEnumerable<Loan>> GetCustomerByLoan(int loanId);

        decimal CalculateInterest(decimal loanAmount, float rate, float time, decimal interest);
        bool LoanExists(int customerId);

        bool IsLoanExisting(CustomerProfile customer, Loan hasLoan);
    


            
    }
}
