using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BalticSportAPI.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        [Required]
        [MaxLength(50)]
        public string CustomerName { get; set; }
        public List<Phone> Phone { get; set; }
        [Required]
        [MaxLength(50)]
        public string CustomerAddress { get; set; }
    }
}
