using System;
using System.Collections.Generic;

namespace EdGradAssist.Models.Entities
{
    public partial class Concentration
    {
        public Concentration()
        {
            Application = new HashSet<Application>();
            Course = new HashSet<Course>();
            Criteria = new HashSet<Criteria>();
        }

        public int ConcentrationId { get; set; }
        public string ConcentrationDescription { get; set; }

        public ICollection<Application> Application { get; set; }
        public ICollection<Course> Course { get; set; }
        public ICollection<Criteria> Criteria { get; set; }
    }
}
