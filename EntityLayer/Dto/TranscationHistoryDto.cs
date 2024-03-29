﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Dto
{
    public class TranscationHistoryDto
    {
        [Required]
        public string NameOfDepositor { get; set; }
        
        [Required]
        public decimal Amount { get; set; }
        public DateTime DepositDate { get; set; }

        [Required]
        public string Narrative { get; set; }
        [Required]
        public decimal AmountWithdraw { get; set; }
        [Required]
        public DateTime WithdrawlDate { get; set; }





        //[Required]
        //public decimal[] Debit { get; set; }
        //public decimal CurrentBalance { get; set; }
        //[Required]

        //public decimal[] Credit { get; set; }

        //public DateTime StartDate { get; set; }
        //public DateTime EndDate { get; set; }

    }
}
