using System.ComponentModel.DataAnnotations;

namespace ASP_NETCore_RazorPages.Models
{
    public class Account
    {
        [EmailAddress(ErrorMessage ="Email address incorrect format.")]
        [Required(ErrorMessage = "Email is required.")]
        [Display(Name ="Email address (*)")]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required.")]
        [Display(Name ="Password (*)")]
        public string Password { get; set; }
    }
}
