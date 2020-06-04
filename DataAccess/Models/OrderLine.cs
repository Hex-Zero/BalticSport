using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BalticSportAPI.Models
{
    public class OrderLine
    {
        public int Id { get; set; }
      
        public Order OrderId { get; set; }
      
        public Product ProductId { get; set; }
        public int OrderQuantity { get; set; }
    }
}
