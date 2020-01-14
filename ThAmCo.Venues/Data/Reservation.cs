using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThAmCo.Venues.Data
{
    /// <summary>
    /// Reservation information for a venue
    /// </summary>
    public class Reservation
    {
        /// <summary>
        /// Reference of the reservation
        /// </summary>
        [Key, MinLength(13), MaxLength(13)]
        public string Reference { get; set; }

        /// <summary>
        /// Event date
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime EventDate { get; set; }

        /// <summary>
        /// venue code
        /// </summary>
        [Required]
        public string VenueCode { get; set; }

        /// <summary>
        /// availablity for venue
        /// </summary>
        [ForeignKey(nameof(EventDate) + ", " + nameof(VenueCode))]
        public Availability Availability { get; set; }

        /// <summary>
        /// When the reservation was made
        /// </summary>
        public DateTime WhenMade { get; set; }

        /// <summary>
        /// staff id in order for api to call
        /// </summary>
        [Required]
        public string StaffId { get; set; }
    }
}
