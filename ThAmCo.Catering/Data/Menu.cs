using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ThAmCo.Catering.Controllers
{
    /// <summary>
    /// Menu that can be booked onto events
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Id for menu
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Starter of the food menu
        /// </summary>
        public string Starter { get; set; }

        /// <summary>
        /// Main course of food menu
        /// </summary>
        public string Main { get; set; }

        /// <summary>
        /// Desert of food menu
        /// </summary>
        public string Desert { get; set; }

        /// <summary>
        /// Cost of food menu
        /// </summary>
        public decimal Cost { get; set; }

        /// <summary>
        /// Bookings that the menu is booked on
        /// </summary>
        public IEnumerable<FoodBooking> Booking { get; set; }
    }
}
