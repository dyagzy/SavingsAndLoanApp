using EntityLayer.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.SavingsRepository.ISavingsRepositorys
{
    public interface ISavingsRepository
    {
        Task Add<T>(T entity) where T : class;
        Task<SavingsAccountDto> OpenSavingsAccount(SavingsAccountDto savingsAccount);
        Task<SavingsAccount> GetOneSavingsAccount(int id);
        Task<List<SavingsAccount>> GetAllSavingsAccount();
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAllChangesAsync();
        void Update<T>(T entity) where T : class;
        bool SavingsAccountExits(int id);

        Task<CashDeposit> GetOneCashDeposit(int id);
        Task<List<CashDeposit>> GetAllCashDeposit();

        Task<RoundUpSaving> GetOneRoundUpSavings(int id);
        Task<List<RoundUpSaving>> GetAllRoundUpSavings();

    }


}
