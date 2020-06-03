using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BalticSportAPI.Models
{
    public class OrderLine
    {
        public int OrderLineID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int OrderQuantity { get; set; }
    }
}
