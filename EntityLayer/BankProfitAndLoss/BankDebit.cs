using EntityLayer.CustomerDetails;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityLayer.BankProfitAndLoss
{
    public class BankDebit: BankUtility
    {
        [Column(TypeName = "decimal(18, 6)")]
        public decimal DebitAmount { get; set; }
 

        ///Navigation property
        public IEnumerable<CustomerProfile> CustomerProfiles { get; set; }
    }
}
