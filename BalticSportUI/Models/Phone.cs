using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BalticSportAPI.Models
{
    public class Phone
    {
        public int PhoneID { get; set; }
        public List<int> PhoneNumber { get; set; } = new List<int>();
    }
}
