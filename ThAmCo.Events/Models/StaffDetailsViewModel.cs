using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ThAmCo.Events.Data;

namespace ThAmCo.Events.Models
{
    /// <summary>
    /// pulls staff details information
    /// </summary>
    public class StaffDetailsViewModel
    {
        /// <summary>
        /// stafff id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// staff surname
        /// </summary>
        public String Surname { get; set; }
        
        /// <summary>
        /// staff first name
        /// </summary>
        public String FirstName { get; set; }

        /// <summary>
        /// staff full name
        /// </summary>
        public String FullName { get; set; }

        /// <summary>
        /// if the staff is a first aider
        /// </summary>
        public bool FirstAider { get; set; }

        /// <summary>
        /// staff email address
        /// </summary>
        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }

        /// <summary>
        /// events the staff is booked on
        /// </summary>
        public IEnumerable<Event> Events { get; set; }
    }
}