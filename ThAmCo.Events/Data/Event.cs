using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ThAmCo.Events.Data
{
    public class Event
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public DateTime Date { get; set; }

        public TimeSpan? Duration { get; set; }

        [Required, MaxLength(3), MinLength(3)]
        public string TypeId { get; set; }

        public List<GuestBooking> Bookings { get; set; }

        public decimal VenueCost { get; set; }

        public string Venue { get; set; }

        public string Reference { get; set; }

        public DateTime WhenMade { get; set; }

        public string Description { get; set; }

        [Range(1, Int32.MaxValue)]
        public int Capacity { get; set; }

        public bool isDeleted { get; set; }
    }
}
