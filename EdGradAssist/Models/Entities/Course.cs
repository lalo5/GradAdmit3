using System;
using System.Collections.Generic;

namespace EdGradAssist.Models.Entities
{
    public partial class Course
    {
        public Course()
        {
            StudentCourse = new HashSet<StudentCourse>();
        }

        public string EtsucourseId { get; set; }
        public string CourseTitle { get; set; }
        public string CourseStatus { get; set; }
        public int? ConcentrationId { get; set; }

        public Concentration Concentration { get; set; }
        public ICollection<StudentCourse> StudentCourse { get; set; }
    }
}
