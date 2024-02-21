using System.ComponentModel.DataAnnotations;

namespace ASP_NETCore_RazorPages.Models
{
    public class Account
    {
        [EmailAddress(ErrorMessage ="Email is required.")]
        [Display(Name ="Email")]
        public string Email { get; set; }
        [DataType(DataType.Password,ErrorMessage ="Password is required.")]
        [Display(Name ="Password")]
        public string Password { get; set; }
    }
}
