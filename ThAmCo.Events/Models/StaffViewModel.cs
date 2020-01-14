using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ThAmCo.Events.Data;

namespace ThAmCo.Events.Models
{
    /// <summary>
    /// Pulls staff information
    /// </summary>
    public class StaffViewModel
    {
        /// <summary>
        /// staff id
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
        /// staff fullname
        /// </summary>
        public String FullName { get; set; }

        /// <summary>
        /// is the staff a first aider or not
        /// </summary>
        public bool FirstAider { get; set; }
    }
}