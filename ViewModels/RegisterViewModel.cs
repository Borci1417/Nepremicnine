using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace RZ_nepremicnine.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Username is required.")]
        public string UserName { get; set; }
        
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(40, MinimumLength = 8, ErrorMessage = "Password needs a minimum of 8 charachers")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [Compare("ConfirmPassword", ErrorMessage = "Password doesn't match.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(40, MinimumLength = 8, ErrorMessage = "Password needs a minimum of 8 charachers")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]

        public string ConfirmPassword { get; set; }


    }
}