using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ThAmCo.Events.Data;

namespace ThAmCo.Events.Models
{
    public class StaffIndexViewModel
    {
        public int Id { get; set; }

        public String Surname { get; set; }

        public String FirstName { get; set; }

        public String FullName { get; set; }

        public bool FirstAider { get; set; }

        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }

        public List<Staffing> Staffings { get; set; }
    }
}