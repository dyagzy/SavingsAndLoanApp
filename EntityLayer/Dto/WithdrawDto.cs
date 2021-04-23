using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Dto
{
   public  class WithdrawDto
    {
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        
        public decimal AmountWithdraw { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime WithdrawlDate { get; set; }
        public int DepositMoneyId { get; set; }





    }
}
