using ASP_NETCore_RazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ASP_NETCore_RazorPages.Pages
{
    public class ProductModel : PageModel
    {
        private readonly SE1710_DBContext _context;

        [BindProperty]
        public List<Product> listProducts { get; set; }
        
        public ProductModel(SE1710_DBContext _context)
        {
            this._context = _context;
        }

        public async Task<IActionResult> OnGet()
        {
            listProducts = await _context.Products.ToListAsync();
            return Page();
        }


    }
}
