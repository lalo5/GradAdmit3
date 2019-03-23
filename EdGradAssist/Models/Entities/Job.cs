using System;
using System.Collections.Generic;

namespace EdGradAssist.Models.Entities
{
    public partial class Job
    {
        public Job()
        {
            Application = new HashSet<Application>();
        }

        public int JobId { get; set; }
        public string Name { get; set; }
        public decimal? BudgetAllocation { get; set; }
        public string Professor { get; set; }
        public int? RoomNumber { get; set; }
        public string Building { get; set; }

        public ICollection<Application> Application { get; set; }
    }
}
