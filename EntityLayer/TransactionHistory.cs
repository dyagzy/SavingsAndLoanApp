using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adyba.Savings.Loans.Models
{
    public class TransactionHistory : SavingsAccountModel
    {
        public DateTime TransactionHistorySearchPeriod { get; set; }

        public DateTime DateOfTransaction { get; set; }

        public int TransactionAmount { get; set; }

        public string TransactionRecipientName { get; set; }

        public string TransactionRecipientBankName { get; set; }

        public string TransactionComment { get; set; }

        public string TransactionType { get; set; }
    }
}
