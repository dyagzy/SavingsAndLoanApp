using EntityLayer.FixDeposit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.LoanRepository
{
    public interface IFixedDepositService
    {
        Task CreatAysnc(FixedDeposit fixedDeposit);
        IEnumerable<FixedDeposit> GetAll();
        FixedDeposit GetById(int fixedDepositId);
        Task UpdateAysnc(FixedDeposit fixedDeposit);
        Task UpdateAsync(int fixedDepositId);
        Task Delete(int fixedDepositId);

    }
}
