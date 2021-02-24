using EntityLayer.Loans;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Loans
{
    public class RepayLoan
    {
        public int Id { get; set; }
  
        public DateTime RepaymentDate { get; set; }
        public decimal Amount { get; set; }
        public string ChequeNumber { get; set; }
        public string ChequeBankId { get; set; }
        public int TransactionId { get; set; }
        public string Notes { get; set; }
        public string ReferenceNumber { get; set; }



        //Navigation property
        public int LoadId { get; set; }
        public Loan Loan { get; set; }
<<<<<<< HEAD:EntityLayer/Loans/RepayLoan.cs
        public TenorType TenureType { get; set; }
=======
        public Tenor TenureType { get; set; }
        public int LoanId { get; set; }
>>>>>>> 990fe90084514b7631032ab0f149a0dfd896ba32:EntityLayer/RepayLoan.cs
        public PaymentMethod PaymentMethod { get; set; }

    }
}
