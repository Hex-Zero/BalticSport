using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BalticSportAPI.Models
{
    public class BalticSportDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Phone> PhoneNumbers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\sqlexpress;Initial Catalog=BalticSport;Integrated Security=True");
        }
    }
}
