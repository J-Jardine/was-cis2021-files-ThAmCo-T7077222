using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ThAmCo.Events.Data
{
    /// <summary>
    /// Represents an event
    /// </summary>
    public class Event
    {
        /// <summary>
        /// Event id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Event title
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// Event date
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Event duration
        /// </summary>
        public TimeSpan? Duration { get; set; }

        /// <summary>
        /// event typeid
        /// </summary>
        [Required, MaxLength(3), MinLength(3)]
        public string TypeId { get; set; }

        /// <summary>
        /// event booking
        /// </summary>
        public List<GuestBooking> Bookings { get; set; }

        /// <summary>
        /// venue cost for event
        /// </summary>
        public decimal VenueCost { get; set; }

        /// <summary>
        /// venue name 
        /// </summary>
        public string Venue { get; set; }

        /// <summary>
        /// venue reference
        /// </summary>
        public string Reference { get; set; }

        /// <summary>
        /// When the venue reservation was made
        /// </summary>
        public DateTime WhenMade { get; set; }

        /// <summary>
        /// Description of the venue
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The capacity of venue
        /// </summary>
        [Range(1, Int32.MaxValue)]
        public int Capacity { get; set; }

        /// <summary>
        /// Boolean to check if the venue has been removed
        /// </summary>
        public bool isDeleted { get; set; }
    }
}
