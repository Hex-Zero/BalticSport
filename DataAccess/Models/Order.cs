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
        public Customer Customer { get; set; }
        public Seller Seller { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
