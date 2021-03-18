using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Authentication
{
    public class LoginInfo : CommonProperty
    {

        [Key]
        public int UserInfoId { get; set; }

        [Display (Name ="Email Address")]
        [EmailAddress (ErrorMessage = "Invalid Email Address")]
        [Required(ErrorMessage = "Email is required")]
        public string EmailId { get; set; }

        [Required(ErrorMessage = "Username is required")]
        [StringLength(16, ErrorMessage ="Must be between 5 and 16 characters", MinimumLength = 5)]

        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Compare("Password")]
        [NotMapped]
        public string ConfirmPassword { get; set; }

        public bool IsMailConfirmed { get; set; }
    }
}
