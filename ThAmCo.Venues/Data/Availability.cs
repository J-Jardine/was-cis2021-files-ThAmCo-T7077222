using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThAmCo.Venues.Data
{
    /// <summary>
    /// Avilablily of a venue
    /// </summary>
    public class Availability
    {
        /// <summary>
        /// Date for when the venue will be booked from and to
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        /// <summary>
        /// Venue code
        /// </summary>
        public string VenueCode { get; set; }

        /// <summary>
        /// venue name
        /// </summary>
        [ForeignKey(nameof(VenueCode))]
        public Venue Venue { get; set; }

        /// <summary>
        /// cost of the venue per hour
        /// </summary>
        [Range(0.0, Double.MaxValue)]
        public double CostPerHour { get; set; }

        /// <summary>
        /// Reservation for the venue
        /// </summary>
        public Reservation Reservation { get; set; }
    }
}
