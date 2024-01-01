using System.ComponentModel.DataAnnotations;

namespace Cinego.Data.ViewModel
{
    public class LoginViewModel
    {
        [Display(Name ="Email")]
        [Required(ErrorMessage="*Email address is required")]
        public string EmailAddress { get; set; }
        [Display(Name = "Password")]

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
