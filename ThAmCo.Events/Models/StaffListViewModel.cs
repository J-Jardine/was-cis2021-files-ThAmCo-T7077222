using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ThAmCo.Events.Models
{
    /// <summary>
    /// pulls staff list information
    /// </summary>
    public class StaffList
    {
        /// <summary>
        /// staff id
        /// </summary>
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// staff full name
        /// </summary>
        [Required]
        public string FullName { get; set; }

        /// <summary>
        /// staff code
        /// </summary>
        [Required]
        public string StaffCode { get; set; }
    }

}

