using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class AccountClosingModel : SavingsAccount
    {
        public int AccountClosingMinimumBalance { get; set; }
    }
}
