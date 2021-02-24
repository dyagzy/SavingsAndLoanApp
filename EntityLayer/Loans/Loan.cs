using EntityLayer.CustomerDetails;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Loans
{
    public class Loan 
    {
        public int Id { get; set; }
        public decimal LoanAmount { get; set; }

        public float Tenor { get; set; }
        
        public int NumberOfPayment { get; set; }
        public decimal InterestRate { get; set; }
       
        public string InterestType { get; set; }
        public DateTime RepaymentStartDate { get; set; }

        //Navigation properties

<<<<<<< HEAD

        public RepayLoan RepayLoan { get; set; }
        public PaymentRecord PaymentRecord { get; set; }
        public IEnumerable<LoanType> LoanType { get; set; }
        public TenorType TenorType { get; set; }
        //public PaymentMethod PaymentMethod { get; set; }
        public int CustomerProfileId { get; set; }
        public CustomerProfile CustomerProfile { get; set; }
=======
        public RepayLoan RepayLoan { get; set; }
        public PaymentRecord PaymentRecord { get; set; }
        public LoanType LoanType { get; set; }
        public Tenor TenureType { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public CustomerProfile CustomerProfile { get; set; }
        public int CustomerProfileId  { get; set; }
>>>>>>> 990fe90084514b7631032ab0f149a0dfd896ba32

    }
}
