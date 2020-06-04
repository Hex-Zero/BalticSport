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
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string SupplierName { get; set; }
        public List<Phone> Phone { get; set; }
        public string CustomerAddress { get; set; }
    }
}
