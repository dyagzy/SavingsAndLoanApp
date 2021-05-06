using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Transaction
{
    public class DepositWithdraw
    {
        public int DepositMoneyId { get; set; }
        public int WithdrawMoneyId { get; set; }
        public DepositMoney DepositMoney { get; set; }
        public WithdrawMoney WithdrawMoney { get; set; }
    }
}
