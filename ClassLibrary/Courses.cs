using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    /// <summary>
    /// The composite of courses in the course tree
    /// </summary>
    public class Courses : AbstractCourse
    {
        List<AbstractCourse> CourseList = new List<AbstractCourse>();

        public Courses(String Id, String Name, bool status) : base(Id, Name, status)
        {

        }//end Course(String, String, bool) : Base (String, String, bool)

        #region Necessary Overrides

        public override void Add(AbstractCourse course)
        {
            CourseList.Add(course);
        }//end Add(AbstractCourse)

        public override void Remove(AbstractCourse course)
        {
            CourseList.Remove(course);
        }//end Remove(AbstractCourse)

        public override void RemoveAt(int position)
        {
            CourseList.RemoveAt(position);
        }//end RemoveAt(int)
        #endregion

    }//end Courses
}
