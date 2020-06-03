using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BalticSportAPI.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public int SupplierID { get; set; }
        public int ProductQuantity { get; set; }
        public long ProductPrice { get; set; }
        public string ProductDescription { get; set; }
    }
}
