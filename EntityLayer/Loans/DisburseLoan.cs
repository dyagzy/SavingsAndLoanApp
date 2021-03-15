using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityLayer
{
    public class DisburseLoan
    {
        public int AccountId { get; set; }
        public DateTime DisbursementDate { get; set; }
        public DateTime FirstRepaymentDate { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 6)")]
        public decimal Payments { get; set; }

    }
}
