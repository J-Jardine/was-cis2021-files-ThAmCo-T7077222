using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ThAmCo.Events.Data
{
    /// <summary>
    /// Used o represent a Staff member
    /// </summary>
    public class Staff
    {
        /// <summary>
        /// Staff id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Staff surname
        /// </summary>
        public String Surname { get; set; }

        /// <summary>
        /// Staff first name
        /// </summary>
        public String FirstName { get; set; }

        /// <summary>
        /// Is staff a first aider or not
        /// </summary>
        public bool FirstAider { get; set; }

        /// <summary>
        /// Staff email address
        /// </summary>
        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }

        /// <summary>
        /// list of staff information 
        /// </summary>
        public List<Staffing> Staffings { get; set; }
        public string StaffCode { get; internal set; }
    }
}
