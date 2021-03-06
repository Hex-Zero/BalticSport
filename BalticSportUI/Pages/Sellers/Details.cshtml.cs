﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BalticSportAPI.Models;

namespace BalticSportUI.Pages.Sellers
{
    public class DetailsModel : PageModel
    {
        private readonly BalticSportAPI.Models.BalticSportDbContext _context;

        public DetailsModel(BalticSportAPI.Models.BalticSportDbContext context)
        {
            _context = context;
        }

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
    }
}
