using EntityLayer.CustomerDetails;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.BankProfitAndLoss
{
   public class BankCredit
    {
        public decimal BankCreditAmount { get; set; }
        public int Id { get; set; }
        public DateTime DateOfTransaction { get; set; }
        public decimal Amount { get; set; }

        ///Navigation property
        public IEnumerable<CustomerProfile> CustomerProfiles { get; set; }
    }
}
