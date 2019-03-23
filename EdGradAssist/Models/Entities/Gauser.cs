using System;
using System.Collections.Generic;

namespace EdGradAssist.Models.Entities
{
    public partial class Gauser
    {
        public Gauser()
        {
            Review = new HashSet<Review>();
        }

        public int UserId { get; set; }
        public string Useremail { get; set; }
        public string UserPassword { get; set; }
        public string UserType { get; set; }
        public string UserStatus { get; set; }

        public ICollection<Review> Review { get; set; }
    }
}
