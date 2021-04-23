using EntityLayer.CustomerDetails;
using EntityLayer.Loans;
using EntityLayer.Transaction;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityLayer
{
    public class SavingsAccount
    {

        public int Id { get; set; }
      
        public string AccountNumber { get; set; }

        [Required]
        public DateTime AccountCreationDate { get; set; }
        public string SurName { get; set; }

        public string FirstName { get; set; }
        public string OtherNames { get; set; }

        // Gets full name of the customer, which is a ombination of his first name initila letter of his other name and his surname 
        //eg Daniel A. Oyagha
        public string FullName
        {
            get
            {
                return FirstName + (string.IsNullOrEmpty(OtherNames) ? " " : (" " + (char?)OtherNames[0]) + " .").ToUpper() + SurName;
                
            }
        }
        [Required]
        public int AccountOwnerID { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal InitialBal { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal CurrentBalance { get; set; }


        /// <summary>
        /// navigation property
        /// </summary>
        public CustomerProfile Customerprofiles { get; set; }
        public int CustomerProfileId { get; set; }
        public DepositMoney DepositMoney { get; set; }


    }
}
