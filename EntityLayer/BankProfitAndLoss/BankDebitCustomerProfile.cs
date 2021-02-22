using EntityLayer.CustomerDetails;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.BankProfitAndLoss
{
    public class BankDebitCustomerProfile: BankUtility
    {
        public decimal DebitAmount { get; set; }
    }
}
