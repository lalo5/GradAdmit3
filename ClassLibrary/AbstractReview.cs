using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    /// <summary>
    /// The abstract class which serves as a template for the leaf class
    /// </summary>
    public abstract class AbstractReview
    {
        protected Student Subject;
        protected DateTime ReviewDate;
        protected Criteria ReviewCriteria;
        public AbstractReview(Student SubjectIn, DateTime DateIn)
        {
            Subject = SubjectIn; //Replace with a call to the copy constructor later
            ReviewDate = DateIn;
        }//end AbstractReview(Student, DateIn)

        /// <summary>
        /// Abstract method to add a Review to the tree
        /// </summary>
        /// <param name="Review"> The Review to add </param>
        public abstract void Add(AbstractReview Review);

        /// <summary>
        /// Template method to remove a Review from the tree
        /// </summary>
        /// <param name="Review"> The Review to remove </param>
        public abstract void Remove(AbstractReview Review);

        /// <summary>
        /// Template method to remove a Review at a specific position in the hosted list
        /// </summary>
        /// <param name="position"> The 0-based position from which to remove a Review </param>
        public abstract void RemoveAt(int position);

        public Student GetSubject()
        {
            return this.Subject;
        }//end GetSubject()

        public DateTime GetReviewDate()
        {
                return this.ReviewDate;
        }//end GetReviewDate()

    }//end AbstractReview
}
