using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP_NETCore_RazorPages.Pages
{
    public class Index2Model : PageModel
    {
        [BindProperty]
        public string Name {  get; set; }
        public void OnGet()
        {
        }
    }
}
