using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EdGradAssist.Models.Entities;

namespace EdGradAssist.Models.Entities
{
	public class StudentApplicationViewModel
	{
		//public Student Students { get; set; }

		//public Application Applications { get; set; }

		//Address Data
		public int AddressId { get; set; }
		public string Street1 { get; set; }
		public string Street2 { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Zip { get; set; }
		public string Country { get; set; }
		public int? FolderNum { get; set; }

		public Application FolderNumNavigation { get; set; }

		//Budget Data
		public int BudgetId { get; set; }
		public DateTime? Year { get; set; }
		public int? Amount { get; set; }

		//Course Data
		public string EtsucourseId { get; set; }
		public string CourseTitle { get; set; }
		public string CourseStatus { get; set; }
		public int? ConcentrationId { get; set; }

		public Concentration Concentration { get; set; }
		public ICollection<StudentCourse> StudentCourse { get; set; }

		//GAuser Data
		public int UserId { get; set; }
		public string Useremail { get; set; }
		public string UserPassword { get; set; }
		public string UserType { get; set; }
		public string UserStatus { get; set; }

		public ICollection<Review> Review { get; set; }

		//Job Data
		public int JobId { get; set; }
		public string Name { get; set; }
		public decimal? BudgetAllocation { get; set; }
		public string Professor { get; set; }
		public int? RoomNumber { get; set; }
		public string Building { get; set; }

		public ICollection<Application> Application { get; set; }

		//Review Data
		public int ReviewId { get; set; }
		public DateTime? ReviewDate { get; set; }
		//public int? FolderNum { get; set; }
		//public int? UserId { get; set; }

		//public Application FolderNumNavigation { get; set; }
		public Gauser User { get; set; }
		public ICollection<ReviewCriteria> ReviewCriteria { get; set; }

		//Score Type Data
		public int ScoreTypeId { get; set; }
		public string ScoreTypeDesc { get; set; }

		public ICollection<Score> Score { get; set; }


		//Student Data
		public string Enum { get; set; }
		public string Fname { get; set; }
		public string Mname { get; set; }
		public string Lname { get; set; }
		public int? Hours { get; set; }
		public string Email { get; set; }


		//Application Data
		//public int FolderNum { get; set; }
		public DateTime? ApplicationDate { get; set; }
		//public string Enum { get; set; }
		//public int? ConcentrationId { get; set; }
		//public int? JobId { get; set; }
		//public Concentration Concentration { get; set; }
		public Student EnumNavigation { get; set; }
		public Job Job { get; set; }
		public ICollection<Address> Address { get; set; }
		//public ICollection<Review> Review { get; set; }
		//public ICollection<Score> Score { get; set; }


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
		//public string EtsucourseId { get; set; }
		//public string Enum { get; set; }
		public string CourseTerm { get; set; }
		public decimal? CourseGrade { get; set; }
		//public Student EnumNavigation { get; set; }
		public Course Etsucourse { get; set; }

		//Review Data
		//public int ReviewId { get; set; }
		//public DateTime? ReviewDate { get; set; }
		//public int? FolderNum { get; set; }
		//public int? UserId { get; set; }

		//public Application FolderNumNavigation { get; set; }
		//public Gauser User { get; set; }
		//public ICollection<ReviewCriteria> ReviewCriteria { get; set; }

		//Criteria Data
		public int CriteriaId { get; set; }
		public string CriteriaDescription { get; set; }
		public string CriteriaStatus { get; set; }
		public string CriteriaDisplayOrder { get; set; }
		//public int? ConcentrationId { get; set; }

		//public Concentration Concentration { get; set; }
		//public ICollection<ReviewCriteria> ReviewCriteria { get; set; }

		//Score Data
		public int ScoreId { get; set; }
		public int? Score1 { get; set; }
		//public int? FolderNum { get; set; }
		//public int? ScoreTypeId { get; set; }

		//public Application FolderNumNavigation { get; set; }
		public ScoreType ScoreType { get; set; }

		//Concentration Data
		//public int ConcentrationId { get; set; }
		public string ConcentrationDescription { get; set; }

		//public ICollection<Application> Application { get; set; }
		public ICollection<Course> Course { get; set; }
		public ICollection<Criteria> Criteria { get; set; }
	}
}
