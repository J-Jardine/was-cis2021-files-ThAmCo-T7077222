using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;


namespace ThAmCo.Events.Models
{
    /// <summary>
    /// Pulls reservation information
    /// </summary>
    public class ReservationViewModel
    {
        /// <summary>
        /// Reservation reference
        /// </summary>
        public string Reference { get; set; }

        /// <summary>
        /// event date
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime EventDate { get; set; }

        /// <summary>
        /// the venue code
        /// </summary>
        public string VenueCode { get; set; }

        /// <summary>
        /// when the reservation was made
        /// </summary>
        public DateTime WhenMade { get; set; }

        /// <summary>
        /// staff id to create the api call
        /// </summary>
        public string StaffId { get; set; }
    }
}
