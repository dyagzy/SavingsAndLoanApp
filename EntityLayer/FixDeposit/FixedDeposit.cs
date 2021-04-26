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

     
        //Navigation properties
        public int CustomerProfileId { get; set; }
        public  CustomerProfile CustomerProfiles { get; set; }

    }
}
