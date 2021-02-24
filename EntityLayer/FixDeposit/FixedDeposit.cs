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
<<<<<<< HEAD
     
        //Navigation properties
        public int CustomerProfileId { get; set; }
        public  CustomerProfile CustomerProfiles { get; set; }


=======

        //navigation propertes
        public CustomerProfile CustomerProfiles { get; set; }
        public int CustomerProfileId { get; set; }
>>>>>>> 990fe90084514b7631032ab0f149a0dfd896ba32
    }
}
