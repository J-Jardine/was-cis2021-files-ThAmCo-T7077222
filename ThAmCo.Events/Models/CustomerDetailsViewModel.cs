using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ThAmCo.Events.Data;

namespace ThAmCo.Events.Models
{
    /// <summary>
    /// Used to pull customer details
    /// </summary>
    public class CustomerDetailsViewModel
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
        /// customer full name
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// customer email address
        /// </summary>
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        /// <summary>
        /// customer events they are on
        /// </summary>
        public IEnumerable<Event> Events { get; set; }

    }
}