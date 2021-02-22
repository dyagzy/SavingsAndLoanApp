using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    public class DisburseLoan
    {
        public int AccountId { get; set; }
        public DateTime DisbursementDate { get; set; }
        public DateTime FirstRepaymentDate { get; set; }
        public decimal Payments { get; set; }

    }
}
