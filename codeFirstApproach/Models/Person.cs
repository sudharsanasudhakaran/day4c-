using System;
using System.Collections.Generic;
using System.Text;

namespace codeFirstApproach.Models
{
    //POCO
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

        public string Gender { get; set; }
        public int Age { get; set; }

        public int Status { get; set; }
    }
}
