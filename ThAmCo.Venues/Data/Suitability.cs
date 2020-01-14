using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThAmCo.Venues.Data
{
    /// <summary>
    /// suitability of venue
    /// </summary>
    public class Suitability
    {
        /// <summary>
        /// event type id
        /// </summary>
        public string EventTypeId { get; set; }

        /// <summary>
        /// event type
        /// </summary>
        public EventType EventType { get; set; }

        /// <summary>
        /// venue code
        /// </summary>
        public string VenueCode { get; set; }

        /// <summary>
        /// Calling upon venue
        /// </summary>
        public Venue Venue { get; set; }
    }
}
