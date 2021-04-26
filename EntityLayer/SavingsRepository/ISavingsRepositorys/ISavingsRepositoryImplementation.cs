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
        Task<DepositDto> SaveMoney(DepositDto deposit );
        Task<DepositDto> WithdrawFunds(WithdrawDto withdraw);
        Task<IEnumerable<TranscationHistoryDto>> GetAllTransactionHistory();
        Task<IEnumerable<TranscationHistoryDto>> GetTransactionHistory(int transactionId);
        Task<IEnumerable<TranscationHistoryDto>> GetTransactionHistory(DateTime  date);
        Task<IEnumerable<TranscationHistoryDto>> GetTransactionHistory(decimal amount);
        Task<IEnumerable<TranscationHistoryDto>> GetOneTransactionHistory(int transactionId, decimal amount, string name);








        Task<SavingsAccount> GetOneSavingsAccount(int transactionId);
        Task<List<SavingsAccount>> GetAllSavingsAccount();
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAllChangesAsync();
        void Update<T>(T entity) where T : class;
        bool IsSavingsAccountExits(int id);

        Task<CashDeposit> GetOneCashDeposit(int id);
        Task<List<CashDeposit>> GetAllCashDeposit();

        Task<RoundUpSaving> GetOneRoundUpSavings(int id);
        Task<List<RoundUpSaving>> GetAllRoundUpSavings();

    }


}
