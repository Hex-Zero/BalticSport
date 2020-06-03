using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BalticSportAPI.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public int PhoneID { get; set; }
        public string CustomerAddress { get; set; }
    }
}
