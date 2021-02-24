using EntityLayer.CustomerDetails;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.BankProfitAndLoss
{
    public class BankDebit: BankUtility
    {
        public decimal DebitAmount { get; set; }
 

        ///Navigation property
        public IEnumerable<CustomerProfile> CustomerProfiles { get; set; }
    }
}
