using EntityLayer.CustomerDetails;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.BankProfitAndLoss
{
    public class BankDebitCustomerProfile
    {
        public DateTime TimeOfCustomerCredit { get; set; }
        public int CustomerCreditTransactionId { get; set; }
        public string CustomerCreditComment { get; set; }
        public decimal CustomerCreditAmount { get; set; }
    }
}
