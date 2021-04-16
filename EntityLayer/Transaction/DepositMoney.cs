using EntityLayer.CustomerDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Transaction
{
    public class DepositMoney
    {
        public int Id { get; set; }
        
        public decimal Amount { get; set; }
        
        public decimal CurrentBalance { get; set; }
        public string AccountNumber { get; set; }

        //Navigation  property
        public int CustomerProfileId { get; set; }
        public CustomerProfile CustomerProfile { get; set; }



    }
}
