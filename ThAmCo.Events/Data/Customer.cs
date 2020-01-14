using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ThAmCo.Events.Data
{
    /// <summary>
    /// Used to represent a customer
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Id of a customer
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Customer surname
        /// </summary>
        [Required]
        public string Surname { get; set; }

        /// <summary>
        /// Customer first name
        /// </summary>
        [Required]
        public string FirstName { get; set; }

        /// <summary>
        /// Customer email address
        /// </summary>
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        /// <summary>
        /// Bookings that the customer is on
        /// </summary>
        public List<GuestBooking> Bookings { get; set; }
    }
}
