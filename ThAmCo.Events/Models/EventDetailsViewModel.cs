using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ThAmCo.Events.Data;

namespace ThAmCo.Events.Models
{   
    /// <summary>
    /// pulls inforation for event detials
    /// </summary>
    public class EventDetailsViewModel
    {
        /// <summary>
        /// event id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// event title
        /// </summary>
        [Required]
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
        /// event type id
        /// </summary>
        [Required, MaxLength(3), MinLength(3)]
        public string TypeId { get; set; }

        /// <summary>
        /// event guest count
        /// </summary>
        public int GuestCount { get; set; }

        /// <summary>
        /// event staff cout
        /// </summary>
        public int StaffCount { get; set; }

        /// <summary>
        /// string dispaying message
        /// </summary>
        public String EnoughStaff { get; set; }

        /// <summary>
        /// String displaying message
        /// </summary>
        public String FirstAider { get; set; }

        /// <summary>
        /// if first aider is on the event or not
        /// </summary>
        public bool FirstAiderBool { get; set; }

        /// <summary>
        /// if there are enough staff on the event or not
        /// </summary>
        public bool EnoughStaffBool { get; set; }

        /// <summary>
        /// list of guest booked on to the event
        /// </summary>
        public List<GuestBooking> Bookings { get; set; }

        /// <summary>
        /// Linking to the guest view model
        /// </summary>
        public IEnumerable<GuestViewModel> Guests { get; set; }

        /// <summary>
        /// Linking to the staff view model
        /// </summary>
        public IEnumerable<StaffViewModel> Staff { get; set; }

        /// <summary>
        /// venue name
        /// </summary>
        public string Venue { get; set; }

        /// <summary>
        /// venue cost
        /// </summary>
        public decimal VenueCost { get; set; }

        /// <summary>
        /// when the reservation was made
        /// </summary>
        public DateTime WhenMade { get; set; }

        /// <summary>
        /// venue description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// capcaity of the venue
        /// </summary>
        [Range(1, Int32.MaxValue)]
        public int Capacity { get; set; }
    }
}