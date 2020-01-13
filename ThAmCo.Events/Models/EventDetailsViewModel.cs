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

        public String EnoughStaff { get; set; }

        public String FirstAider { get; set; }

        public bool FirstAiderBool { get; set; }

        public bool EnoughStaffBool { get; set; }

        public List<GuestBooking> Bookings { get; set; }

        public IEnumerable<GuestViewModel> Guests { get; set; }

        public IEnumerable<StaffViewModel> Staff { get; set; }

        public string Venue { get; set; }

        public decimal VenueCost { get; set; }

        public DateTime WhenMade { get; set; }

        public string Description { get; set; }

        [Range(1, Int32.MaxValue)]
        public int Capacity { get; set; }
    }
}