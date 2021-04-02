using EntityLayer.CustomerDetails;
using EntityLayer.DataAccess;
using EntityLayer.LoanRepository;
using EntityLayer.Loans;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
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
        private readonly ILogger<LoanService> _logger;
        public LoanService(ApplicationDbContext appDbContext, ILogger<LoanService> logger)
        {
            _appDbContext = appDbContext;
            _logger = logger;
        }
        public decimal CalculateInterest(decimal loanAmount, float rate, float time, decimal interest)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Loan>> GetAllCustomerByLoan()
        {
            _logger.LogInformation($"Gets all the customers whose loan has been approved");
            _appDbContext.Loans
            throw new NotImplementedException();
        }

       

        //Returns all list of loans
        public async Task<IEnumerable<Loan>> GetAllLoan()
        {
            return await _appDbContext.Loans.OrderBy(l => l.LoanType).ToListAsync();
        }

        //Get lists of customers who have taken a loan alongside their names and loans collected by firstname
        public async Task<IEnumerable<Loan>> GetOneCustomerByLoan(int loanId)
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

        

        public Task<IQueryable<RepayLoan>> GetRepayLoanByCustomer(string firstName, string lastName)
        {
            _logger.LogInformation($"Gets list of customers who have are paying back Loan{firstName.GetType()}");
            // complete this method after Amaka has run a migrtaion for you
            throw new NotImplementedException();
        }

        public Task<IQueryable<RepayLoan>> GetRepayLoanByCustomer(string phone)
        {
            // complete this method after Amaka has run a migrtaion for you
            throw new NotImplementedException();
        }

        public bool IsLoanExisting(CustomerProfile customer, Loan hasLoan)
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

        public bool ApproveLoan(CustomerProfile customer)
        {
            bool isApproved = false;
            if (customer.SavingsAccounts.IsActive)
            {
                isApproved = true;
            }
            return isApproved;
        }
    }
}
