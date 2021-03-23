using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.BankProfitAndLoss
{
    public class BankUtility
    {
        public int Id { get; set; }
        public DateTime DateOfTransaction { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal Amount { get; set; }
    }
}
