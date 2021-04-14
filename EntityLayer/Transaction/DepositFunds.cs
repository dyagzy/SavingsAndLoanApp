using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Transaction
{
    public class DepositFunds
    {
        public int Id { get; set; }
        
        public decimal Amount { get; set; }
        
        public decimal CurrentBalance { get; set; }
        public string AccountNumber { get; set; }


       
    }
}
