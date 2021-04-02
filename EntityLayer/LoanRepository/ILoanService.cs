using EntityLayer.CustomerDetails;
using EntityLayer.Loans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.LoanRepository
{
    public interface ILoanService
    {
     
        Task<IEnumerable<Loan>> GetLoanByAmount(decimal amount);
        Task<Loan> GetLoanById(int loandId);
        Task<IEnumerable<Loan>> GetAllLoan();
        Task<IEnumerable<Loan>> GetOneCustomerByLoan(int loanId);
        Task<IQueryable<CustomerProfile>> GetAllCustomerWithApprovedLoan();
        Task<IQueryable<RepayLoan>> GetRepayLoanByCustomer(string firstName, string lastName);
        Task<IQueryable<RepayLoan>> GetRepayLoanByCustomer(string phone);
       

        decimal CalculateInterest(decimal loanAmount, float rate, float time, decimal interest);
        bool LoanExists(int customerId);

        bool IsLoanExisting(CustomerProfile customer, Loan hasLoan);
    


            
    }
}
