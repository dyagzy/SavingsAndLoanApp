using EntityLayer.CustomerDetails;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.BankProfitAndLoss
{
   public class BankCredit: BankUtility
    {
        public decimal CreditAmount { get; set; }

        ///Navigation property
        public IEnumerable<CustomerProfile> CustomerProfiles { get; set; }
    }
}
