using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ThAmCo.Venues.Data
{
    /// <summary>
    /// Getting venue information
    /// </summary>
    public class Venue
    {
        /// <summary>
        /// venue code
        /// </summary>
        [Key, MinLength(5), MaxLength(5)]
        public string Code { get; set; }

        /// <summary>
        /// venue name
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// description of the venue
        /// </summary>
        [Required]
        public string Description { get; set; }

        /// <summary>
        /// capicity that the venue can hold
        /// </summary>
        [Range(1, Int32.MaxValue)]
        public int Capacity { get; set; }

        /// <summary>
        /// list suitable event types
        /// </summary>
        public List<Suitability> SuitableEventTypes { get; set; }

        /// <summary>
        /// list available venue dates
        /// </summary>
        public List<Availability> AvailableDates { get; set; }
    }
}
