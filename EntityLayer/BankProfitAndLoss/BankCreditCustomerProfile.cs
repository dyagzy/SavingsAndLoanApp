using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityLayer.BankProfitAndLoss
{
  public  class BankCreditCustomerProfile: BankUtility
    {
        [Column(TypeName = "decimal(18, 6)")]
        public decimal CreditAmount { get; set; }
    
    }
}
