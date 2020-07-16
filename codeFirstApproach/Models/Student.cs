using System;
using System.Collections.Generic;
using System.Text;

namespace codeFirstApproach.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public int GradeId { get; set; }
        public Grade Grade { get; set; }
    }



    public class Grade
    {
        public int Id { get; set; }
        public string Gradename { get; set; }
        public string Section { get; set; }

        public List<Student> Students { get; set; }
    }
}
