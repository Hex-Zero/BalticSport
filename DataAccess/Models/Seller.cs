using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BalticSportAPI.Models
{
    public class Seller
    {
        public int SellerID { get; set; }
        [Required]
        [MaxLength(50)]
        public string SellerName { get; set; }
        public List<Phone> Phone { get; set; }
    }
}
