using EntityLayer.CustomerDetails;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityLayer.FixDeposit
{
    public class FixedDeposit 
    {
        //[ForeignKey("CustomerProfile")]
        public int Id { get; set; }

        public decimal Principal { get; set; }
        public float Time { get; set; }
        public decimal Rate { get; set; }
        public decimal AmountDue { get; set; }
        public decimal Interest { get; set; }

        //navigation propertes
       // public virtual CustomerProfile CustomerProfiles { get; set; }


    }
}
