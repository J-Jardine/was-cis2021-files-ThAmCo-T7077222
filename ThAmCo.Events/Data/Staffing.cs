using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThAmCo.Events.Data
{
    /// <summary>
    /// Representing what events a staff member is on
    /// </summary>
    public class Staffing
    {
        /// <summary>
        /// Staff id
        /// </summary>
        public int StaffId { get; set; }

        /// <summary>
        /// Staff list
        /// </summary>
        public Staff Staff { get; set; }

        /// <summary>
        /// Event id
        /// </summary>
        public int EventId { get; set; }

        /// <summary>
        /// Event list
        /// </summary>
        public Event Event { get; set; }
    }
}
