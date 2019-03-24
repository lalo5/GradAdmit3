using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    /// <summary>
    /// The collection of reviews
    /// </summary>
    public class AppReviews : AbstractReview
    {
        List<AbstractReview> ReviewList = new List<AbstractReview>();

        /// <summary>
        /// The parameterized constructor that takes a student and datetime object, calls the parent class constructor
        /// </summary>
        /// <param name="subjectIn"> The student that is being reviewed </param>
        /// <param name="DateIn"> The date of the review </param>
        public AppReviews(Student subjectIn, DateTime DateIn) : base(subjectIn, DateIn)
        {

        }//end AppReview(Student, DateTime)

        #region Necessary Overrides
        public override void Add(AbstractReview Review)
        {
            ReviewList.Add(Review);
        }//end Add(AbstractReview)

        public override void Remove(AbstractReview Review)
        {
            ReviewList.Remove(Review);
        }//end Remove(AbstractReview)

        public override void RemoveAt(int position)
        {
            ReviewList.RemoveAt(position);
        }//end RemoveAt(int)
        #endregion
    }//end AppReviews
}
