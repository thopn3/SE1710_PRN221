using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP_NETCore_RazorPages.Pages
{
    public class ProductModel : PageModel
    {
        [BindProperty]
        public string Message {  get; set; }
        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetString("account")==null)
            {
                return RedirectToPage("Index");
            }
            Message = "OnGet method";
            ViewData["data"] = new { id = "1", name = "Marry" };
            return Page();
        }

        public void OnPost()
        {
            // Lấy dữ liệu từ Input text trên View
            var msg = Request.Form["msg"];
            // Gán cho 1 ViewData
            ViewData["result"] = msg;
            Message = msg;
        }
    }
}
