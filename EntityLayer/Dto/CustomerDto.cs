using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Dto
{
    public class CustomerDto
    {

        [Required]
        public byte CustomerImage { get; set; }

      
        [Required, MinLength(3), MaxLength(40)]
        public string SurName { get; set; }

        [Required, MinLength(3), MaxLength(40)]
        public string FirstName { get; set; }

        [Required, MinLength(3), MaxLength(40)]
        public string OtherNames { get; set; }

        [Required]
        public string DateOfBirth { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }
        public string Address { get; set; }
        public string Occupation { get; set; }

        [Required, MinLength(3), MaxLength(40)]
        public string NameOfNextOfKin { get; set; }

        [Required]
        public string PhoneNumberOfNextOfKin { get; set; }
        public string AddressOfNextOfKin { get; set; }

        [Required]
        public string Signature { get; set; }
    }
}
