using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ThAmCo.Events.Data;

namespace ThAmCo.Events.Models
{   
    /// <summary>
    /// Used to pull the customer index details
    /// </summary>
    public class CustomerIndexViewModel
    {
        /// <summary>
        /// customer id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// customer surname
        /// </summary>
        [Required]
        public string Surname { get; set; }

        /// <summary>
        /// customer first name
        /// </summary>
        [Required]
        public string FirstName { get; set; }

        /// <summary>
        /// customer fullname
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// customer email address
        /// </summary>
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        /// <summary>
        /// Booking a customer is on
        /// </summary>
        public List<GuestBooking> Bookings { get; set; }
    }
}