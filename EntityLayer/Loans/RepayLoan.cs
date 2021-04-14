using EntityLayer.CustomerDetails;
using EntityLayer.Loans;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityLayer.Loans
{
    public class RepayLoan
    {
        public int Id { get; set; }
  
        public DateTime RepaymentDate { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 6)")]
        public decimal Amount { get; set; }
        public string ChequeNumber { get; set; }
        public string ChequeBankId { get; set; }
        public int TransactionId { get; set; }
        public string Notes { get; set; }
        public string ReferenceNumber { get; set; }



        //Navigation property
        public int LoanId { get; set; }
        public Loan Loan { get; set; }

        public Tenor TenureType { get; set; }

        public PaymentMethod PaymentMethod { get; set; }

        // Repayloan can be done by a Customer while a 
        public CustomerProfile CustomerProfile { get; set; }

    }
}
