using EntityLayer.DataAccess;
using EntityLayer.LoanRepository;
using EntityLayer.Loans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.LoanRepositoryService
{
    public class LoanService : ILoanService
    {
        private readonly ApplicationDbContext _dB;
        

        public LoanService(ApplicationDbContext dB)
        {
           _dB  = dB;
        }
        public Task CreatLoanAysnc()
        {

            
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Loan> GetAllLoan()
        {
            throw new NotImplementedException();
        }

        public Loan GetLoanByAmount(decimal amount)
        {
           var loanAmount =  _dB.Loans.Where(f => f.LoanAmount == amount).FirstOrDefault();
            return loanAmount;
        }

        public Loan GetLoanById(int loanId)
        {
            var loan = _dB.Loans.Where(a => a.Id == loanId).FirstOrDefault();

            return loan;
        }

        public Task UpdateLoanAsync(Loan loan)
        {
            throw new NotImplementedException();
        }

        public Task UpdateLoanAsync(int id)
        {
            throw new NotImplementedException();
        }
        
    }
}
