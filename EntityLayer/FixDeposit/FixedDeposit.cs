using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.FixDeposit
{
    public class FixedDeposit 
    {
        
        public decimal Principal { get; set; }
        public float Time { get; set; }
        public decimal Rate { get; set; }
        public decimal AmountDue { get; set; }
        public decimal Interest { get; set; }
        //Navigation

        public CustomerProfile CustomerProfile  { get; set; }


    }
}
