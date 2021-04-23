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
        public decimal Credit { get; set; }
        public decimal Debit { get; set; }
        public decimal CurrentBalance { get; set; }

        public string WithdrawRemark { get; set; }

        public DateTime TransactionDate { get; set; }



        //public DateTime TransactionHistorySearchPeriod { get; set; }

        //public DateTime DateOfTransaction { get; set; }

        //public int TransactionAmount { get; set; }

        //public string TransactionRecipientName { get; set; }

        //public string TransactionRecipientBankName { get; set; }

        //public string TransactionComment { get; set; }

        //public string TransactionType { get; set; }
    }
}
