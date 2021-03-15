using EntityLayer.CustomerDetails;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityLayer.Loans
{
    public class Loan 
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 6)")]
        public decimal LoanAmount { get; set; }

        public float Tenor { get; set; }
        
        public int NumberOfPayment { get; set; }
        public decimal InterestRate { get; set; }
       
        public string InterestType { get; set; }
        public DateTime RepaymentStartDate { get; set; }

        //Navigation properties



        public RepayLoan RepayLoan { get; set; }
        public PaymentRecord PaymentRecord { get; set; }
        public IEnumerable<LoanType> LoanType { get; set; }
        public TenorType TenorType { get; set; }
        public int CustomerProfileId { get; set; }
        public CustomerProfile CustomerProfile { get; set; }

     
     
        
        public PaymentMethod PaymentMethod { get; set; }
       // public PaymentRecord paymentRecord { get; set; }




    }
}
