using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ThAmCo.Events.Data;

namespace ThAmCo.Events.Models
{
    /// <summary>
    /// Pulls guest information
    /// </summary>
    public class GuestViewModel
    {
        /// <summary>
        /// event id the guest is booked on
        /// </summary>
        public int EventId { get; set; }

        /// <summary>
        /// guest id
        /// </summary>
        public int  Id { get; set; }

        /// <summary>
        /// guest surame
        /// </summary>
        [Required]
        public string Surname { get; set; }

        /// <summary>
        /// guest first name
        /// </summary>
        [Required]
        public string FirstName { get; set; }

        /// <summary>
        /// guest fullname
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// guest email address
        /// </summary>
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        /// <summary>
        /// if the guest has attended or not
        /// </summary>
        public bool Attended { get; set; }
    }
}