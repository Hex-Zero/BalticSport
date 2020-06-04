using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BalticSportAPI.Models;

namespace BalticSportUI.Pages.Sellers
{
    public class DeleteModel : PageModel
    {
        private readonly BalticSportAPI.Models.BalticSportDbContext _context;

        public DeleteModel(BalticSportAPI.Models.BalticSportDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Seller Seller { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Seller = await _context.Sellers.FirstOrDefaultAsync(m => m.Id == id);

            if (Seller == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Seller = await _context.Sellers.FindAsync(id);

            if (Seller != null)
            {
                _context.Sellers.Remove(Seller);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
