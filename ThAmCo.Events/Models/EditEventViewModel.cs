using System;
using System.Collections.Generic;
using ThAmCo.Events.Data;

namespace ThAmCo.Events.Models
{
    /// <summary>
    /// Event edit information
    /// </summary>
    public class EditEventViewModel
    {
        /// <summary>
        /// event id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// event title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// event date
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// event duration
        /// </summary>
        public TimeSpan? Duration { get; set; }

        /// <summary>
        /// avent attended
        /// </summary>
        public bool Attended { get; set; }

        /// <summary>
        /// customer booked onto events
        /// </summary>
        public List<GuestBooking> Bookings { get; set; }
    }
}