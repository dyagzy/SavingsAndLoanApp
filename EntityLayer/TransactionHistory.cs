using EntityLayer.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class TransactionHistory 
    {

        public int Id { get; set; }
        public string NameOfDepositor { get; set; }
        public decimal Amount { get; set; }
        public DateTime DepositDate { get; set; }
        public string Narrative { get; set; }
        public decimal AmountWithdraw { get; set; }
        public DateTime WithdrawlDate { get; set; }


        //Nva

        public IEnumerable<DepositMoney> DepositMoney { get; set; }
        public IEnumerable<WithdrawMoney> WithdrawMoney { get; set; }





















        //public string NameOfDepositor { get; set; }
        //public decimal[] Credit { get; set; }
        //public decimal[] Debit { get; set; }
        //public decimal CurrentBalance { get; set; }

        //public string Narrative { get; set; }

        //public DateTime StartDate { get; set; }
        //public DateTime EndDate { get; set; }



        //public DateTime TransactionHistorySearchPeriod { get; set; }

        //public DateTime DateOfTransaction { get; set; }

        //public int TransactionAmount { get; set; }

        //public string TransactionRecipientName { get; set; }

        //public string TransactionRecipientBankName { get; set; }

        //public string TransactionComment { get; set; }

        //public string TransactionType { get; set; }
    }
}
