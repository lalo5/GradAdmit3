using System;
using System.Collections.Generic;

namespace EdGradAssist.Models.Entities
{
    public partial class Application
    {
        public Application()
        {
            Address = new HashSet<Address>();
            Review = new HashSet<Review>();
            Score = new HashSet<Score>();
        }

        public int FolderNum { get; set; }
        public DateTime? ApplicationDate { get; set; }
        public string Enum { get; set; }
        public int? ConcentrationId { get; set; }
        public int? JobId { get; set; }

        public Concentration Concentration { get; set; }
        public Student EnumNavigation { get; set; }
		//public Student Enum { get; set; }
        public Job Job { get; set; }
        public ICollection<Address> Address { get; set; }
        public ICollection<Review> Review { get; set; }
        public ICollection<Score> Score { get; set; }
    }
}
