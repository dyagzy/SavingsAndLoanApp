using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    public class Loan //inherit from customer profile class
    {
        public int CustomerId { get; set; }
        public float Tenure { get; set; }
        
        public int NumberOfPayment { get; set; }
        public decimal InterestRate { get; set; }
        public Enum AmortizationType { get; set; }
        public string InterestType { get; set; }
        public DateTime RepaymentStartDate { get; set; }

        //Navigation propeerties

        public RepayLoan RepayLoan { get; set; }
        public PaymentRecord PaymentRecord { get; set; }
        public LoanType LoanType { get; set; }
        public TenureType TenureType { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

    }
}
