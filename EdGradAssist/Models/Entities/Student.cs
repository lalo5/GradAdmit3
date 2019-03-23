using System;
using System.Collections.Generic;

namespace EdGradAssist.Models.Entities
{
    public partial class Student
    {
        public Student()
        {
            Application = new HashSet<Application>();
            Degree = new HashSet<Degree>();
            StudentCourse = new HashSet<StudentCourse>();
        }

        public string Enum { get; set; }
        public string Fname { get; set; }
        public string Mname { get; set; }
        public string Lname { get; set; }
        public int? Hours { get; set; }
        public string Email { get; set; }

        public ICollection<Application> Application { get; set; }
        public ICollection<Degree> Degree { get; set; }
        public ICollection<StudentCourse> StudentCourse { get; set; }
    }
}
