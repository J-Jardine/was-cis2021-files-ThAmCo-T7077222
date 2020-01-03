using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ThAmCo.Events.Data;

namespace ThAmCo.Events.Models
{
    public class EventDetailsViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public DateTime Date { get; set; }

        public TimeSpan? Duration { get; set; }

        [Required, MaxLength(3), MinLength(3)]
        public string TypeId { get; set; }

        public int GuestCount { get; set; }

        public int StaffCount { get; set; }

        public List<GuestBooking> Bookings { get; set; }

        public IEnumerable<GuestViewModel> Guests { get; set; }

        public IEnumerable<StaffViewModel> Staff { get; set; }
    }
}