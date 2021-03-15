using EntityLayer.CustomerDetails;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityLayer.FixDeposit
{
    public class FixedDeposit 
    {
        //[ForeignKey("CustomerProfile")]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 6)")]
        public decimal Principal { get; set; }
        public float Time { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 6)")]
        public decimal Rate { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 6)")]
        public decimal AmountDue { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 6)")]
        public decimal Interest { get; set; }

        //navigation propertes
        public CustomerProfile CustomerProfiles { get; set; }
        public int CustomerProfileId { get; set; }
    }
}
