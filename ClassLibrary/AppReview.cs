using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    /// <summary>
    /// Leaf node for the Review Tree
    /// </summary>
    public class AppReview : AbstractReview
    {
        /// <summary>
        /// The parameterized constructor that takes a student and datetime object, calls the parent class constructor
        /// </summary>
        /// <param name="subjectIn"> The student that is being reviewed </param>
        /// <param name="DateIn"> The date of the review </param>
        public AppReview(Student subjectIn, DateTime DateIn) : base(subjectIn, DateIn)
        {

        }//end AppReview(Student, DateTime)

        #region Necessary Overrides
        public override void Add(AbstractReview Review)
        {
            throw new InvalidOperationException();
        }//end Add(AbstractReview)

        public override void Remove(AbstractReview Review)
        {
            throw new InvalidOperationException();
        }//end Remove(AbstractReview)

        public override void RemoveAt(int position)
        {
            throw new InvalidOperationException();
        }//end RemoveAt(int)
        #endregion

    }//end AppReview
}
