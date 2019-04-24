using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    /// <summary>
    /// A Grad Student's full application, including the pdf file (to be displayed)
    /// </summary>
    public class GradApplication : IComparable<GradApplication>
    {
        private double ComplexityRating;
        private Concentration ConcentrationApplied;
        private DateTime Date;
        private String Enum;
        private Student Applicant;
        private AbstractReview Review;

        public GradApplication()
        {
            ComplexityRating = 1.0;
            ConcentrationApplied = new Concentration();
            Date = DateTime.Now;
            Applicant = new Student();
        }//end GradApplication()

        public GradApplication(Concentration ConcIn, DateTime dateIn, String EnumIn, Student ApplicantIn)
        {
            this.ConcentrationApplied = new Concentration(ConcIn);
            this.Date = dateIn;
            this.Enum = EnumIn;
            this.Applicant = new Student(ApplicantIn);
            CalculateComplexity();
        }//end GradApplication(Concentration, DateTime, String, Student)

        public GradApplication(GradApplication AppIn)
        {
            this.ConcentrationApplied = new Concentration(AppIn.ConcentrationApplied);
            this.Date = AppIn.Date;
            this.Enum = AppIn.Enum;
            this.Applicant = new Student(AppIn.Applicant);
            CalculateComplexity();
        }//end GradApplication(GradApplication AppIn)

        /// <summary>
        /// Compare the applications based on complexity rating
        /// </summary>
        /// <param name="AppIn"></param>
        /// <returns> </returns>
        public int CompareTo(GradApplication AppIn)
        {
            return this.ComplexityRating.CompareTo(AppIn.ComplexityRating);
        }

        public double GetComplexityRating()
        {
            return this.ComplexityRating;
        }

        public Concentration GetConcentration()
        {
            return this.ConcentrationApplied;
        }

        public DateTime GetDate()
        {
            return this.Date;
        }

        public String GetEnum()
        {
            return this.Enum;
        }

        public Student GetApplicant()
        {
            return this.Applicant;
        }

        public void CalculateComplexity()
        {
            if(this.Applicant.GetAddress().GetCountry() != "USA" || this.Applicant.GetAddress().GetCountry() != "United States" || this.Applicant.GetAddress().GetCountry() != "US")
            {
                this.ComplexityRating = 1.5;
            }
            else
            {
                this.ComplexityRating = 1.0;
            }
        }//end CalculateComplexity()



    }// end of Grad Application
}
