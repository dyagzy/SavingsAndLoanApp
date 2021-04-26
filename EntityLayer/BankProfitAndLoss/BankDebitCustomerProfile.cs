using EntityLayer.CustomerDetails;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityLayer.BankProfitAndLoss
{
    public class BankDebitCustomerProfile: BankUtility
    {
        [Column(TypeName = "decimal(18, 6)")]

        public decimal DebitAmount { get; set; }
    }
}
