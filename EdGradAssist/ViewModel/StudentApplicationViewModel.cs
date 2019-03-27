using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EdGradAssist.Models.Entities;

namespace EdGradAssist.ViewModel
{
	public class StudentApplicationViewModel
	{
		//public Student Students { get; set; }

		//public Application Applications { get; set; }


		//Student Data
		public string Enum { get; set; }
		public string Fname { get; set; }
		public string Mname { get; set; }
		public string Lname { get; set; }
		public int? Hours { get; set; }
		public string Email { get; set; }


		//Application Data
		public int FolderNum { get; set; }
		public DateTime? ApplicationDate { get; set; }
		//public string Enum { get; set; }
		public int? ConcentrationId { get; set; }
		public int? JobId { get; set; }
		public Concentration Concentration { get; set; }
		public Student EnumNavigation { get; set; }
		public Job Job { get; set; }
		public ICollection<Address> Address { get; set; }
		public ICollection<Review> Review { get; set; }
		public ICollection<Score> Score { get; set; }


		//Degree Data
		public int DegreeId { get; set; }
		public string Institution { get; set; }
		public string Major { get; set; }
		public string Degree1 { get; set; }
		public decimal? Gpa { get; set; }
		public DateTime? GraduationDate { get; set; }
		public string Graduated { get; set; }
		//public string Enum { get; set; }
		//public Student EnumNavigation { get; set; }


		//Student Course Data
		public string EtsucourseId { get; set; }
		//public string Enum { get; set; }
		public string CourseTerm { get; set; }
		public decimal? CourseGrade { get; set; }
		//public Student EnumNavigation { get; set; }
		public Course Etsucourse { get; set; }
	}
}
