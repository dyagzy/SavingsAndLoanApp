using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer
{
    public class RoundUpSaving
    {
        public int ID { get; set; }
        [Required, MaxLength(10), MinLength(10)]
        public string AccountNumber { get; set; }
        [Required]
        public DateTime AccountCreationDate { get; set; }
        public bool IsActive { get; set; }
        [Required]
        public int AccountOwnerID { get; set; }
    }
}
