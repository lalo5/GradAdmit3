using System;
using System.Collections.Generic;

namespace EdGradAssist.Models.Entities
{
    public partial class Score
    {
        public int ScoreId { get; set; }
        public int? Score1 { get; set; }
        public int? FolderNum { get; set; }
        public int? ScoreTypeId { get; set; }

        public Application FolderNumNavigation { get; set; }
        public ScoreType ScoreType { get; set; }
    }
}
