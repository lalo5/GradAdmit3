using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    /// <summary>
    /// The graduate's concentration, contains all of the coursework for the concentration
    /// </summary>
    public class Concentration
    {
        private AbstractCourse Courses;
        private AbstractCriteria Criteria;
        private String Description;

        public Concentration()
        {

        }//end Concentration()

        /// <summary>
        /// Copy Constructor for concentration
        /// </summary>
        /// <param name="ConcentrationIn"></param>
        public Concentration(Concentration ConcentrationIn)
        {
            this.Criteria = new Criteria(ConcentrationIn.Criteria.GetStatus(), ConcentrationIn.Criteria.GetDescription(), ConcentrationIn.Criteria.GetDisplayOrder(), ConcentrationIn.Criteria.GetCriteriaType());
            this.Courses = new Courses(ConcentrationIn.Courses.GetId(), ConcentrationIn.Courses.GetName(), ConcentrationIn.Courses.GetStatus());
            this.Description = ConcentrationIn.Description;
        }//end Concentration(ConcentrationIn)

        public AbstractCourse GetCourses()
        {
            return this.Courses;
        }//end GetCourses()

        public AbstractCriteria GetCriteria()
        {
            return this.Criteria;
        }//end GetCriteria()

    }//end Concentration
}
