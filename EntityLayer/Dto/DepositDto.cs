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
        //[Required]
        //[Column(TypeName = "decimal(18, 6)")]
        //public decimal CurrentBalance { get; set; }

        [Required]
        public string AccountNumber { get; set; }
        public DateTime DepositDate { get; set; }

        public string SurName { get; set; }

        [Required, MinLength(3), MaxLength(40)]
        public string FirstName { get; set; }

        public decimal CurrentBalance   // property
        {
            get { return HelperMethods.Deposit(this.Amount); }

        }
    }
}
