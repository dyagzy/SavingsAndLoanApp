using EntityLayer.CustomerDetails;
using EntityLayer.DataAccess;
using EntityLayer.LoanRepository;
using EntityLayer.Loans;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.LoanRepositoryService
{
    public class LoanService : ILoanService
    {
        private readonly ApplicationDbContext _appDbContext;
        public LoanService(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public decimal CalculateInterest(decimal loanAmount, float rate, float time, decimal interest)
        {
            throw new NotImplementedException();
        }

        //Returns all list of loans
        public async Task<IEnumerable<Loan>> GetAllLoan()
        {
            return await _appDbContext.Loans.OrderBy(l => l.LoanType).ToListAsync();
        }

        //Get lists of customers who have taken a loan alongside their names and loans collected by firstname
        public async Task<IEnumerable<Loan>> GetCustomerByLoan(int loanId)
        {

           IQueryable<Loan> query = (IQueryable <Loan>) _appDbContext.Loans
                                                            .Where(c => c.Id == loanId)
                                                            .Select(c => c.CustomerProfile)
                                                            .OrderBy(c => c.FirstName);
            
                                                            return await query.ToListAsync();
               
            
        }

        public Task<IEnumerable<Loan>> GetLoanByAmount(decimal amount)
        {
            throw new NotImplementedException();
        }

        public Task<Loan> GetLoanById(int loandId)
        {
            throw new NotImplementedException();
        }

        public bool IsLoanExisting(CustomerProfile customer, Loan hasLoan, )
        {
            try
            {
                _appDbContext.CustomerProfiles.

            }
            catch (Exception ex)
            {

                throw ex.Message ;
            }
            throw new NotImplementedException();
        }

        public bool IsLoanExisting(CustomerProfile customer, Loan hasLoan)
        {
            throw new NotImplementedException();
        }

        public bool LoanExists(int customerId)
        {
            if (customerId == 0)
            {
                throw new NotImplementedException(nameof(customerId));
            }
            
                return _appDbContext.Loans.Any(c => c.Id == customerId);
           
        }
    }
}
