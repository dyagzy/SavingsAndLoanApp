using EntityLayer.CustomerDetails;
using EntityLayer.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Dto
{
    public class SavingsAccountDto
    {
        //private string accountNumber; // field
        public string AccountNumber   // property
        {
            get { return AccountNumberGenerator.NewSavingAccountNumbers(); }

        }

        //[Required, MaxLength(10), MinLength(10)]
        // public string AccountNumber { get; set; }
        [Required]
        public DateTime AccountCreationDate { get; set; }
        public int CustomerProfileId { get; set; }
        //public bool IsActive { get; set; }

        [Required]
        public int AccountOwnerID { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 6)")]
        public decimal InitialBal { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 6)")]
        public decimal CurrentBalance { get; set; }
        //public decimal Debit { get; set; }
        //public decimal Credit
        //{
        //    get
        //    {
        //        return this.am
        //    }
        //}
        public string Message
        {
            get { return HelperMethods.SavingsAccountWelcomeMessage(); }
        }

    }

    


  

}
