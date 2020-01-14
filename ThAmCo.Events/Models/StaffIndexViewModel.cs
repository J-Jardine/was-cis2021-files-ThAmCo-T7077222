using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ThAmCo.Events.Data;

namespace ThAmCo.Events.Models
{
    /// <summary>
    /// pulls staff index information
    /// </summary>
    public class StaffIndexViewModel
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
        /// stafff first name
        /// </summary>
        public String FirstName { get; set; }

        /// <summary>
        /// staff full name
        /// </summary>
        public String FullName { get; set; }

        /// <summary>
        /// if the staff is a first aider or not
        /// </summary>
        public bool FirstAider { get; set; }

        /// <summary>
        /// staff email address
        /// </summary>
        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }
        
        /// <summary>
        /// staffing list 
        /// </summary>
        public List<Staffing> Staffings { get; set; }
    }
}