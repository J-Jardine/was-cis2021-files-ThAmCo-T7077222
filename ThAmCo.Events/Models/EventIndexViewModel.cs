using System;
using System.ComponentModel.DataAnnotations;

namespace ThAmCo.Events.Models
{
    /// <summary>
    /// pulls event index information
    /// </summary>
    public class EventIndexViewModel
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
        /// event guest count
        /// </summary>
        public int GuestCount { get; set; }

        /// <summary>
        /// event staff count
        /// </summary>
        public int StaffCount { get; set; }
    }
}