using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public interface ILoanService
    {
       Task CreatLoanAysnc();
       Loan GetLoanById();
       IEnumerable<Loan> GetAllLoan();
       Task UpdateLoanAsync(Loan loan);
       Task UpdateLoanAsync(int id);
       Task Delete(int id);

            
    }
}
