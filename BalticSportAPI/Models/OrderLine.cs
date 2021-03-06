﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BalticSportAPI.Models
{
    public class OrderLine
    {
        public int OrderLineID { get; set; }
      
        public Order Order { get; set; }
      
        public Product Product { get; set; }
        public int OrderQuantity { get; set; }
    }
}
