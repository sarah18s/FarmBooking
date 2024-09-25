using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmBookingBackend.Domain.Enum;

namespace FarmBookingBackend.Domain.Dto
{
    public class RegisterModel
    {

        public required string UserName { get; set; }
        [EmailAddress]
        public required string Email { get; set; }
        [DataType(DataType.Password)]
        public required string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]

        [NotMapped]
        public required string ConfirmPassword { get; set; }

        [Display(Name = "Phone Number")]
        public int PhoneNumber { get; set; }
        public string Role { get; set; }


    }
}
