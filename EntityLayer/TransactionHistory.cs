﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class TransactionHistory : CustomerProfile
    {
        public DateTime TransactionHistorySearchPeriod { get; set; }

        public DateTime DateOfTransaction { get; set; }

        public decimal TransactionAmount { get; set; }

        public string TransactionRecipientName { get; set; }

        public string TransactionRecipientBankName { get; set; }

        public string TransactionComment { get; set; }

        public string TransactionType { get; set; }

        public string TransactionID { get; set; }
    }
}
