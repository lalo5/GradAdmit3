using System;
using System.Collections.Generic;

namespace EdGradAssist.Models.Entities
{
    public partial class Review
    {
        public Review()
        {
            ReviewCriteria = new HashSet<ReviewCriteria>();
        }

        public int ReviewId { get; set; }
        public DateTime? ReviewDate { get; set; }
        public int? FolderNum { get; set; }
        public int? UserId { get; set; }

        public Application FolderNumNavigation { get; set; }
        public Gauser User { get; set; }
        public ICollection<ReviewCriteria> ReviewCriteria { get; set; }
    }
}
