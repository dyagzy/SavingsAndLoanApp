
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

      
        [Required, MinLength(3), MaxLength(40), Display(Name = "Last Name")]
        public string SurName { get; set; }

        [Required, MinLength(3), MaxLength(40), Display(Name = "Fisrt Name")]
        public string FirstName { get; set; }

        [Required, MinLength(3), MaxLength(40), Display(Name = "Middle Name")]
        public string OtherNames { get; set; }

        [Required, Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }


        [Required, Display(Name = "Phone Number")]
        //[RegularExpression(@"[0]{1}[0-9]{10}$")] //  works well accepts normla numbers like 08060335875

        [RegularExpression(@"^([0]{1})([0-9]{10})$")]  //  works well accepts normla numbers like 08060335875, ^ ==> it must start with a particular charater
        //[RegularExpression(@"^\+([0-9]{3})([0-9]{10}) | ^\([0]{1})([0-9]{10})$")] // throw
        public string PhoneNumber { get; set; }

        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Address { get; set; }
        public string Occupation { get; set; }

        [Required, MinLength(3), MaxLength(40)]
        public string NameOfNextOfKin { get; set; }

        [Required]
        [RegularExpression(@"^[0]{1}[0-9]{10}$")] 
        public string PhoneNumberOfNextOfKin { get; set; }
        public string AddressOfNextOfKin { get; set; }

        [Required]
        public string Signature { get; set; }
    }
}
