using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ThAmCo.Catering.Controllers
{
    public class FoodBooking
    {
        public int MenuId { get; set; }
    
        public Menu Menu { get; set; }

        public int EventId { get; set; }


    }
}
