using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BalticSportAPI.Models
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        [Required]
        [MaxLength(50)]
        public string SupplierName { get; set; }
        public Phone Phone { get; set; }
        public string CustomerAddress { get; set; }
    }
}
