using System;
using System.Collections.Generic;

namespace EdGradAssist.Models.Entities
{
    public partial class ReviewCriteria
    {
        public int CriteriaId { get; set; }
        public int ReviewId { get; set; }
        public string CriteriaScore { get; set; }
        public string CriteriaComment { get; set; }

        public Criteria Criteria { get; set; }
        public Review Review { get; set; }
    }
}
