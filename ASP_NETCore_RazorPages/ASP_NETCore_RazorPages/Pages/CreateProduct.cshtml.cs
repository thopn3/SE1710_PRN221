using ASP_NETCore_RazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.SignalR;

namespace ASP_NETCore_RazorPages.Pages
{
    public class CreateProductModel : PageModel
    {
        private readonly SE1710_DBContext _context;
        private readonly IHubContext<HubServer> _hubContext;

        [BindProperty]
        public Product Product { get; set; }

        public CreateProductModel(SE1710_DBContext _context, IHubContext<HubServer> _hubContext)
        {
            this._context = _context;
            this._hubContext = _hubContext;
        }

        public IActionResult OnGet()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            await _context.Products.AddAsync(Product);
            await _context.SaveChangesAsync();
            await _hubContext.Clients.All.SendAsync("ReloadData");
            return Page();
        }
    }
}
