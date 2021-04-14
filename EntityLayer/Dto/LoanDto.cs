using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Dto
{
    public class LoanDto
    {
       
        [Required]
        [Column(TypeName = "decimal(18, 6)")]
        public decimal LoanAmount { get; set; }

        public float Tenor { get; set; }

        public int NumberOfPayment { get; set; }

        [Column(TypeName = "decimal(18, 6)")]
        public decimal InterestRate { get; set; }

        public string InterestType { get; set; }
        public DateTime RepaymentStartDate { get; set; }

    }
}
