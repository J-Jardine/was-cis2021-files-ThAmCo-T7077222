using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ThAmCo.Events.Data
{
    /// <summary>
    /// Used to represent guest booking
    /// </summary>
    public class GuestBooking
    {
        /// <summary>
        /// Customer id
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Customer name
        /// </summary>
        public Customer Customer { get; set; }

        /// <summary>
        /// Event id for event booked onto
        /// </summary>
        public int EventId { get; set; }

        /// <summary>
        /// Event customer booked on
        /// </summary>
        public Event Event { get; set; }

        /// <summary>
        /// Attendence for event
        /// </summary>
        public bool Attended { get; set; }
    }
}
