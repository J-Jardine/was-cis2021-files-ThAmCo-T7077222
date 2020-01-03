using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ThAmCo.Events.Data;

namespace ThAmCo.Events.Models
{
    public class GuestViewModel
    {
        public int EventId { get; set; }

        public int  Id { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string FullName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public bool Attended { get; set; }
    }
}