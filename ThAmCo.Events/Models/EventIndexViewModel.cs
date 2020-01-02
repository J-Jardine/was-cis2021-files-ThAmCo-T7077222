using System;
using System.ComponentModel.DataAnnotations;

namespace ThAmCo.Events.Models
{
    public class EventIndexViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public DateTime Date { get; set; }

        public TimeSpan? Duration { get; set; }

        public int GuestCount { get; set; }
    }
}