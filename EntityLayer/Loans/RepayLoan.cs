using EntityLayer.Loans;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
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
        public Loan Loan { get; set; }
        public int LoanId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

    }
}
