using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ThAmCo.Catering.Controllers
{   /// <summary>
    /// Used to store the menues that are booked onto an event
    /// </summary>
    public class FoodBooking
    {
        /// <summary>
        /// Id of Menu
        /// </summary>
        public int MenuId { get; set; }
    
        /// <summary>
        /// Menu object that is being booked
        /// </summary>
        public Menu Menu { get; set; }

        /// <summary>
        /// id of an event that the menu is booked on
        /// </summary>
        public int EventId { get; set; }


    }
}
