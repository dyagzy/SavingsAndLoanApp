using EntityLayer.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Dto
{
    public class DepositDto
    {
        
        [Required]
        [Column(TypeName = "decimal(18, 6)")]
        public decimal Amount { get; set; }
       
        [Required, Display(Name ="Account Number")]
        public string AccountNumber { get; set; }

        [Display(Name ="Deposit Date")]
        public DateTime DepositDate { get; set; }
      
        [Required, MinLength(3), MaxLength(40)]

        [Display(Name ="Name of Depositor")]
        public string NameOfDepositor { get; set; }
        [Required, MinLength(3), MaxLength(40)]

        [Display(Name = "Name of Account Holder")]
        public string BeneficiaryAccountName { get; set; }

        [Required, MinLength(3), MaxLength(40)]
        public string FirstName { get; set; }
        

        [Required, Display(Name = "Phone Number")]
        [RegularExpression(@"^([0]{1})([0-9]{10})$")]
        public string PhoneOfDepositor { get; set; }

        [Display(Name = "Account Balance")]
        public decimal CurrentBalance { get; set; } // property
        
        public int SavingsAccountId { get; set; }
    }
}
