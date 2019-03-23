using System;
using System.Collections.Generic;

namespace EdGradAssist.Models.Entities
{
    public partial class ScoreType
    {
        public ScoreType()
        {
            Score = new HashSet<Score>();
        }

        public int ScoreTypeId { get; set; }
        public string ScoreTypeDesc { get; set; }

        public ICollection<Score> Score { get; set; }
    }
}
