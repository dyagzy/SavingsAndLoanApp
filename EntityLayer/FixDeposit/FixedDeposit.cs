using EntityLayer.CustomerDetails;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityLayer.FixDeposit
{
    public class FixedDeposit 
    {
        
        public int Id { get; set; }

        public decimal Principal { get; set; }
        public float Time { get; set; }
        public decimal Rate { get; set; }
        public decimal AmountDue { get; set; }
        public decimal Interest { get; set; }

     
        //Navigation properties
        public int CustomerProfileId { get; set; }
        public  CustomerProfile CustomerProfiles { get; set; }

    }
}
