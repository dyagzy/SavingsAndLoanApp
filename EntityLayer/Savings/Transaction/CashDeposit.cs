using EntityLayer.CustomerDetails;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    public class CashDeposit
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string AccountNumberOfRecipient { get; set; }
        public DateTime DepositDate { get; set; }
        public string PhoneNumberOfDepositor { get; set; }
        public string AmountInWords { get; set; }
        public decimal Amount { get; set; }

        public IEnumerable<CustomerProfile> CustomerProfiles { get; set; }
    }
}
