using ASP_NETCore_RazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace ASP_NETCore_RazorPages.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Account Account { get; set; }
        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetString("account") == null)
                return Page();
            else
                return RedirectToPage("Index");
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) 
            {
                return Page();
            }

            if(Account.Email.Equals("admin@fpt.edu.vn") && Account.Password.Equals("admin"))
            {
                HttpContext.Session.SetString("account", JsonSerializer.Serialize(Account));
                return RedirectToPage("Product");
            }

            TempData["msg"] = "Email or password incorrect.";
            return Page();
        }
    }
}
