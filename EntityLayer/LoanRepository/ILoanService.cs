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
       decimal CalculateInterest(decimal loanAmount, float rate, float time, decimal interest);


            
    }
}
