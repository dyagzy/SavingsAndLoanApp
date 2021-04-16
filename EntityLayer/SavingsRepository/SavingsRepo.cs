using AutoMapper;
using EntityLayer.DataAccess;
using EntityLayer.Dto;
using EntityLayer.SavingsRepository.ISavingsRepositorys;
using EntityLayer.Transaction;
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
            return await _appDbContext.SavingsAccounts.FirstOrDefaultAsync(x=>x.Id == id);
        }

        public async Task<List<SavingsAccount>> GetAllSavingsAccount()
        {
            List<SavingsAccount> result = new List<SavingsAccount>();
            try
            {
                 result =  await _appDbContext.SavingsAccounts.ToListAsync();
            }
            catch(SqlException )
            {
                throw;
            }
            catch (Exception )
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
        public bool SavingsAccountExits(int id)
        {
            if (id == 0 ) throw new NotImplementedException(nameof(id));

            return _appDbContext.SavingsAccounts.Any(s => s.Id == id);
        }

        public async Task<SavingsAccountDto> OpenSavingsAccount(SavingsAccountDto savingsAccount)
        {
            //savingsAccount.AccountNumber = AccountNumberGenerator.NewSavingAccountNumbers();
            //await _appDbContext.CustomerProfiles.AddAsync(savingsAccount.Customerprofiles);
            var savings = _mapper.Map<SavingsAccount>(savingsAccount);

            // _appDbContext.SavingsAccounts.Include(s => s.AccountNumber == accountNumber);
            await _appDbContext.SavingsAccounts.AddAsync(savings);
            await _appDbContext.SaveChangesAsync();

            return savingsAccount;

        }

        public async Task<DepositDto> SaveMoney(DepositDto deposit)
        {
           var saveMoney = _mapper.Map<DepositMoney>(deposit);

            await _appDbContext.DepositMoney.AddAsync(saveMoney);
            
            return deposit;
        }
    }
}
