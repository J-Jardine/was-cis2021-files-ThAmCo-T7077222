using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ThAmCo.Venues.Data
{
    /// <summary>
    /// Event type information
    /// </summary>
    public class EventType
    {
        /// <summary>
        /// string for event type
        /// </summary>
        [MinLength(3), MaxLength(3)]
        public string Id { get; set; }

        /// <summary>
        /// event title
        /// </summary>
        [Required]
        public string Title { get; set; }
        
        /// <summary>
        /// Listing the suitable venues
        /// </summary>
        public List<Suitability> SuitableVenues { get; set; }
    }
}
