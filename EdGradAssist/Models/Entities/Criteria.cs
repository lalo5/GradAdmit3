using System;
using System.Collections.Generic;

namespace EdGradAssist.Models.Entities
{
    public partial class Criteria
    {
        public Criteria()
        {
            ReviewCriteria = new HashSet<ReviewCriteria>();
        }

        public int CriteriaId { get; set; }
        public string CriteriaDescription { get; set; }
        public string CriteriaStatus { get; set; }
        public string CriteriaDisplayOrder { get; set; }
        public int? ConcentrationId { get; set; }

        public Concentration Concentration { get; set; }
        public ICollection<ReviewCriteria> ReviewCriteria { get; set; }
    }
}
