using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThAmCo.Events.Models
{
  /// <summary>
  /// Used to pull availbale venues
  /// </summary>
    public class AvailableVenues
    {
        /// <summary>
        /// Venue code
        /// </summary>
        [Key, MinLength(5), MaxLength(5)]
        public string Code { get; set; }

        /// <summary>
        /// Venue name
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Venue description
        /// </summary>
        [Required]
        public string Description { get; set; }

        /// <summary>
        /// Venue capacity
        /// </summary>
        [Range(1, Int32.MaxValue)]
        public int Capacity { get; set; }

        /// <summary>
        /// Venue date
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        /// <summary>
        /// Venue cost per hour
        /// </summary>
        [Range(0.0, Double.MaxValue)]
        public double CostPerHour { get; set; }

        /// <summary>
        /// staff code to allow for api call
        /// </summary>
        public string StaffCode { get; set; }

    }
}
