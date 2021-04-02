using EntityLayer.CustomerDetails;
using EntityLayer.Loans;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityLayer
{
  public  class SavingsAccount
    {
        public int Id { get; set; }
        [Required, MaxLength(10), MinLength(10)]
        public string AccountNumber { get; set; }
        [Required]
        public DateTime AccountCreationDate { get; set; }
        public bool IsActive { get; set; }
        [Required]
        public int AccountOwnerID { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 6)")]
        public decimal InitialBal { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 6)")]
        public decimal CurrentBalance { get; set; }


        /// <summary>
        /// navigation property
        /// </summary>
        public CustomerProfile Customerprofiles { get; set; }
        public int CustomerProfileId { get; set; }
        public ApproveLoan ApproveLoan { get; set; }
        public int ApproveLoanId { get; set; }
    }
}
