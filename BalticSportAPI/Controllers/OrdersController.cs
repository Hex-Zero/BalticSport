using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BalticSportAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BalticSportUI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
       
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            using (var context = new BalticSportDbContext())
            {
                return context.Orders.ToList();
            }
        }
    }
}
