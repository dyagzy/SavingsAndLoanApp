using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer
{
    public abstract class CustomerProfile
    {
        [Required]
        public byte CustomerImage { get; set; }
        [Required]
        public int ID { get; set; }
        //        public Guid CustomerUniqueIdentity { get; set; }
        [Required, MinLength(3), MaxLength(40)]
        public string SurName { get; set; }

        [Required, MinLength(3), MaxLength(40)]
        public string FirstName { get; set; }

        [Required, MinLength(3), MaxLength(40)]
        public string OtherNames { get; set; }

        [Required]
        public string DateOfBirth { get; set; }

        [Required, Phone]
        public string PhoneNumber { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }
        public string Address { get; set; }
        public string Occupation { get; set; }

        [Required]
        public string AccountType { get; set; }
        //A drop down is created here with the various account options (Savings, Loan, Wallet account, & dom account)
        public string AccountHolder { get; set; }
        //A drop down is created for account holder options(individual, cooperate or student)

        [Required, MinLength(3), MaxLength(40)]
        public string NameOfNextOfKin { get; set; }

        [Required, Phone]
        public string PhoneNumberOfNextOfKin { get; set; }
        public string AddressOfNextOfKin { get; set; }
    }
}
