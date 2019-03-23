using System;
using System.Collections.Generic;

namespace EdGradAssist.Models.Entities
{
    public partial class Degree
    {
        public int DegreeId { get; set; }
        public string Institution { get; set; }
        public string Major { get; set; }
        public string Degree1 { get; set; }
        public decimal? Gpa { get; set; }
        public DateTime? GraduationDate { get; set; }
        public string Graduated { get; set; }
        public string Enum { get; set; }

        public Student EnumNavigation { get; set; }
    }
}
