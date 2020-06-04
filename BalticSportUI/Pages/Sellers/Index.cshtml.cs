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
    public class IndexModel : PageModel
    {
        private readonly BalticSportAPI.Models.BalticSportDbContext _context;

        public IndexModel(BalticSportAPI.Models.BalticSportDbContext context)
        {
            _context = context;
        }

        public IList<Seller> Seller { get;set; }

        public async Task OnGetAsync()
        {
            Seller = await _context.Sellers.ToListAsync();
        }
    }
}
