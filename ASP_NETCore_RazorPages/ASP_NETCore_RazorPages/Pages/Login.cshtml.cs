using ASP_NETCore_RazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP_NETCore_RazorPages.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Account Account { get; set; }
        public IActionResult OnGet()
        {
            return Page();
        }


    }
}
