using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ThAmCo.Events.Data
{
    public class Staff
    {
        public int Id { get; set; }

        public String Surname { get; set; }

        public String FirstName { get; set; }

        public bool FirstAider { get; set; }

        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }

        public List<Staffing> Staffings { get; set; }
        public string StaffCode { get; internal set; }
    }
}
