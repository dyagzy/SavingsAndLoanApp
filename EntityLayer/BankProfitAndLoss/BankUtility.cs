using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.BankProfitAndLoss
{
    public class BankUtility
    {
        public int Id { get; set; }
        public DateTime DateOfTransaction { get; set; }
        public decimal Amount { get; set; }
    }
}
