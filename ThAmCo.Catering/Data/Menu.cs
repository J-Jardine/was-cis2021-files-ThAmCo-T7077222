using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ThAmCo.Catering.Controllers
{
    public class Menu
    {
        public int Id { get; set; }

        public string Starter { get; set; }

        public string Main { get; set; }

        public string Desert { get; set; }

        public decimal Cost { get; set; }

        public IEnumerable<FoodBooking> Booking { get; set; }
    }
}
