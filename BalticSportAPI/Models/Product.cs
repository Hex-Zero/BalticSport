using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BalticSportAPI.Models
{
    public class Product
    {
        public int ProductID { get; set; }
     
        public Supplier Supplier { get; set; }
        public int ProductQuantity { get; set; }
        public long ProductPrice { get; set; }
        [Required]
        [MaxLength(250)]
        public string ProductDescription { get; set; }
    }
}
