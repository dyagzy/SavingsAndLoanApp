using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Transaction
{
    public class WithdrawMoney
    {
       
        public int Id { get; set; }
        public decimal AmountWithdraw { get; set; }
        public decimal CurrentBalance { get; set; }
        public string Narrative { get; set; }
        //public decimal ClosingBalance { get; set; }
        public string FirstName { get; set; }
      
        public string LastName { get; set; }
        public DateTime WithdrawlDate { get; set; }


        //Navigation  property
        public int DepositMoneyId { get; set; }
        public DepositMoney DepositMoney { get; set; }
        public IEnumerable<TransactionHistory> TransactionHistories { get; set; }

    }
}
