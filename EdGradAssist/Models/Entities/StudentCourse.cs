using System;
using System.Collections.Generic;

namespace EdGradAssist.Models.Entities
{
    public partial class StudentCourse
    {
        public string EtsucourseId { get; set; }
        public string Enum { get; set; }
        public string CourseTerm { get; set; }
        public decimal? CourseGrade { get; set; }

        public Student EnumNavigation { get; set; }
        public Course Etsucourse { get; set; }
    }
}
