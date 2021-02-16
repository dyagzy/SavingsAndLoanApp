using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Loans
{
    public class Loan : CustomerProfile
    {
        public int CustomerId { get; set; }
        public float Tenor { get; set; }
        
        public int NumberOfPayment { get; set; }
        public decimal InterestRate { get; set; }
        public Enum AmortizationType { get; set; }
        public string InterestType { get; set; }
        public DateTime RepaymentStartDate { get; set; }

        //Navigation properties

        public RepayLoan RepayLoan { get; set; }
        public PaymentRecord PaymentRecord { get; set; }
        public LoanType LoanType { get; set; }
        public TenureType TenureType { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public CustomerProfile CustomerProfile { get; set; }

    }
}
