using AutoMapper;
using EntityLayer.DataAccess;
using EntityLayer.Dto;
using EntityLayer.SavingsRepository.ISavingsRepositorys;
using EntityLayer.Transaction;
using EntityLayer.Utility;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.SavingsRepository
{

    public class SavingsRepo : ISavingsRepository
    {

        private readonly ApplicationDbContext _appDbContext;
        private readonly IMapper _mapper;
        // private readonly ILogger logger;

        public SavingsRepo(ApplicationDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;

        }

        // CREATE
        public async Task Add<T>(T entity) where T : class
        {
            await _appDbContext.AddAsync(entity);
        }

        //READING A SINGLE DATA FROM THE DB
        public async Task<SavingsAccount> GetOneSavingsAccount(int id)
        {
            return await _appDbContext.SavingsAccounts.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<SavingsAccount>> GetAllSavingsAccount()
        {
            List<SavingsAccount> result = new List<SavingsAccount>();
            try
            {
                result = await _appDbContext.SavingsAccounts
                   .OrderBy(s => s.FirstName)
                   .ToListAsync();
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }

        // UPDATE DB
        public void Update<T>(T entity) where T : class
        {
            _appDbContext.Entry(entity).State = EntityState.Modified;
        }
        public async Task<bool> SaveAllChangesAsync()
        {
            if (await _appDbContext.SaveChangesAsync() > 0)
                return true;
            return false;
        }

        //DELETE
        public void Delete<T>(T entity) where T : class
        {
            _appDbContext.Entry(entity).State = EntityState.Deleted;
        }

        // READ FOR CASH DEPOSIT CLASS
        public async Task<CashDeposit> GetOneCashDeposit(int id)
        {
            return await _appDbContext.CashDeposits.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<CashDeposit>> GetAllCashDeposit()
        {
            List<CashDeposit> result = new List<CashDeposit>();
            try
            {
                result = await _appDbContext.CashDeposits.ToListAsync();
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }

        // READ FOR ROUNDUP SAVINGS CLASS
        public async Task<RoundUpSaving> GetOneRoundUpSavings(int id)
        {
            return await _appDbContext.RoundUpSavings.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<RoundUpSaving>> GetAllRoundUpSavings()
        {
            List<RoundUpSaving> result = new List<RoundUpSaving>();
            try
            {
                result = await _appDbContext.RoundUpSavings.ToListAsync();
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }
        //checks if a savings account exit or if a customer already has a savings account
        public bool IsSavingsAccountExits(int SavingsId)
        {
            SavingsAccount savings = new SavingsAccount();
            if (SavingsId == 0)
            {
               
                throw new ArgumentNullException(nameof(SavingsId));
            }


            return _appDbContext.SavingsAccounts.Any(s => s.Id == SavingsId);
        }
















        public async Task<SavingsAccountDto> OpenSavingsAccount(SavingsAccountDto savingsAccount)
        {

            //var depositValue = HelperMethods.DepositFunds(savingsAccount.CurrentBalance);
            var savings = _mapper.Map<SavingsAccount>(savingsAccount);


            await _appDbContext.SavingsAccounts.AddAsync(savings);
            await _appDbContext.SaveChangesAsync();

            return savingsAccount;

        }
        public async Task<DepositDto> SaveMoney(DepositDto deposit)
        {
            SavingsAccount savings = new SavingsAccount();
            if (deposit.AccountNumber != savings.AccountNumber && deposit.FirstName != savings.FirstName)
            {
                
                //throw new ArgumentNullException(nameof(deposit.AccountNumber));
            }
            var initialBalance = _appDbContext.SavingsAccounts
                 .Where(s => s.Id == deposit.SavingsAccountId)
                 .Select(x => x.InitialBal).FirstOrDefault();

            var currentBalance = initialBalance + HelperMethods.DepositFunds(deposit.Amount);
            deposit.CurrentBalance = currentBalance;
            var saveMoney = _mapper.Map<DepositMoney>(deposit);

            await _appDbContext.DepositMonies.AddAsync(saveMoney);
            await _appDbContext.SaveChangesAsync();

            return deposit;
        }

        public async Task<DepositDto> WithdrawFunds(WithdrawDto withdraw)
        {
            DepositDto deposit = new DepositDto();
            DepositMoney dp = new DepositMoney();

            decimal availableBalance = _appDbContext.DepositMonies.Where(d => d.Id == withdraw.DepositMoneyId)
                .Select(d => d.CurrentBalance).FirstOrDefault();

            if (availableBalance >= withdraw.AmountWithdraw)
            {
                availableBalance -= withdraw.AmountWithdraw;
                
                deposit.CurrentBalance = availableBalance;
            }

          

            var withdrawls = _mapper.Map<DepositMoney>(deposit);
            await _appDbContext.DepositMonies.AddAsync(withdrawls);
            await _appDbContext.SaveChangesAsync();

            return deposit;
        }


        //Gets all transcation histories i.e debit and credit histories and projects into one list
        public async Task<IEnumerable<TranscationHistoryDto>> GetAllTransactionHistory()
        {
            /*selects all the entire records in the DepositmONEY table*/
            //List<DepositMoney> allCreditHistory = await  _appDbContext.DepositMonies.ToListAsync();


            /*filter all the entire records in the DepositmONEY table to select the fields that I 
            need using an anonymous object to project the actual fields I needed*/

            //var credit =  from creditHistory in allCreditHistory 
                        //select new {creditHistory.NameofDepositor, creditHistory.Amount, creditHistory.DepositDate};

            /*selects all the entire records in the Withdarw Money table*/

            //List<WithdrawMoney> allDebitHistory =   await _appDbContext.WithdrawMoney.ToListAsync();


            /*filter all the entire records in the Withdarw Money table to select the fields that I 
            need using an anonymous object to project the actual fields I needed*/


            //var debit = from debitHistory in allDebitHistory
                        //select new {debitHistory.Narrative, debitHistory.AmountWithdraw,debitHistory.WithdrawlDate};

            /*Joins the two separate list above into one single histroy list*/

            var transactionHistory = await (from credit in _appDbContext.DepositMonies
                                      join debit in _appDbContext.WithdrawMoney
                            on credit.Id equals debit.DepositMoneyId
                            orderby credit.DepositDate
                            select new
                            {
                                credit.NameofDepositor,
                                credit.Amount,
                                credit.DepositDate,
                                debit.Narrative,
                                debit.AmountWithdraw,
                                debit.WithdrawlDate

                            }).ToListAsync();
               
            //var transactHistory =  await _appDbContext.TransactionHistories.ToListAsync();
            
           return  _mapper.Map<IEnumerable<TranscationHistoryDto>>(transactionHistory);

        }

        public async Task<IEnumerable<TranscationHistoryDto>> GetTransactionHistory(int transactionId)
        {

            return _mapper.Map<IEnumerable<TranscationHistoryDto>>(await _appDbContext.TransactionHistories
                .Where(t => t.Id == transactionId).FirstOrDefaultAsync());


           //var d =  _appDbContext.CustomerProfiles.Where(c => c.SavingsAccounts.Id == transactionId)
               // .Select(c => c.FixedDeposits);
            
        }

        public async Task<IEnumerable<TranscationHistoryDto>> GetTransactionHistory(DateTime date)
        {

            return _mapper.Map<IEnumerable<TranscationHistoryDto>>(await _appDbContext.TransactionHistories
                .Where(t => t.WithdrawlDate == date || t.DepositDate == date).FirstOrDefaultAsync());
               


            //var d =  _appDbContext.CustomerProfiles.Where(c => c.SavingsAccounts.Id == transactionId)
            // .Select(c => c.FixedDeposits);

        }

        public async Task<IEnumerable<TranscationHistoryDto>> GetTransactionHistory(decimal amount)
        {
            
            TransactionHistory transHistory = await _appDbContext.TransactionHistories
               .Where(t =>t .Amount == amount || t.AmountWithdraw == amount)
               .FirstOrDefaultAsync();
            

           return  _mapper.Map <IEnumerable<TranscationHistoryDto>>(transHistory);
                
            
        }

        public async Task<IEnumerable<TranscationHistoryDto>> GetOneTransactionHistory(int transactionId, decimal amount, string name)
        {

            TransactionHistory transHistory = await _appDbContext.TransactionHistories
               .Where(t => t.Amount == amount || t.AmountWithdraw == amount ||
               t.NameOfDepositor == name || t.Narrative == name || t.Id == transactionId)
               .FirstOrDefaultAsync();

            return _mapper.Map <IEnumerable<TranscationHistoryDto>>(transHistory);


        }
    }


    
}
