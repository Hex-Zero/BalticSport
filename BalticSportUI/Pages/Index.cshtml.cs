using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using BalticSportAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace BalticSportUI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly BalticSportDbContext _db;

        public IndexModel(ILogger<IndexModel> logger, BalticSportDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public void OnGet()
        {
            LoadSampleData();
        }
        private void LoadSampleData()
        {
            if(_db.Orders.Count() == 0)
            {
                string file = System.IO.File.ReadAllText("generated.json");
                var orders = JsonSerializer.Deserialize<List<Order>>(file);
                _db.AddRange(orders);
                _db.SaveChanges();
            }
        }
    }
}
