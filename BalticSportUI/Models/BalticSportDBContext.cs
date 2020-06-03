using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BalticSportAPI.Models
{
    public class BalticSportDbContext : DbContext
    {
        public DbSet<> Type { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\sqlexpress;Initial Catalog=BalticSport;Integrated Security=True");
        }
    }
}
