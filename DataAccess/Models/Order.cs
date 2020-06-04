using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BalticSportAPI.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Customer CustomerId { get; set; }
        public Seller SellerId { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
