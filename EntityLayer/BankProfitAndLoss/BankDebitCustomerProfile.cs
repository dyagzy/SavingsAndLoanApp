using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.BankProfitAndLoss
{
    class BankDebitCustomerProfile : CustomerProfile
    {
        public DateTime TimeOfCustomerCredit { get; set; }
        public int CustomerCreditTransactionId { get; set; }
        public string CustomerCreditComment { get; set; }
        public decimal CustomerCreditAmount { get; set; }
    }
}
