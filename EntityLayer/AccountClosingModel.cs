using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adyba.Savings.Loans.Models
{
    public class AccountClosingModel : SavingsAccountModel
    {
        public int AccountClosingMinimumBalance { get; set; }
    }
}
