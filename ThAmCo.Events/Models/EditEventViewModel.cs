using System;
using System.Collections.Generic;
using ThAmCo.Events.Data;

namespace ThAmCo.Events.Models
{
    public class EditEventViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime Date { get; set; }

        public TimeSpan? Duration { get; set; }

        public bool Attended { get; set; }

        public List<GuestBooking> Bookings { get; set; }
    }
}