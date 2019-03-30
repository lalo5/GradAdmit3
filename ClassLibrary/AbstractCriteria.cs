using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    /// <summary>
    /// The template for the leaf of the tree structure
    /// </summary>
    public abstract class AbstractCriteria
    {
        protected String Status;
        protected String Description;
        protected String DisplayOrder;
        protected String Type;

        /// <summary>
        /// The parameterized constructor
        /// </summary>
        /// <param name="StatusIn"></param>
        /// <param name="DescriptionIn"></param>
        /// <param name="DisplayOrderIn"></param>
        /// <param name="TypeIn"></param>
        public AbstractCriteria(String StatusIn, String DescriptionIn, String DisplayOrderIn, String TypeIn)
        {
            this.Status = StatusIn;
            this.Description = DescriptionIn;
            this.DisplayOrder = DisplayOrderIn;
            this.Type = TypeIn;
        }//end AbstractCriteria()

        /// <summary>
        /// The copy constructor for abstract criteria
        /// </summary>
        /// <param name="CriteriaIn"> The Criteria object to be copied </param>
        public AbstractCriteria(AbstractCriteria CriteriaIn)
        {
            this.Status = CriteriaIn.Status;
            this.Description = CriteriaIn.Description;
            this.DisplayOrder = CriteriaIn.DisplayOrder;
            this.Type = CriteriaIn.Type;
        }//end AbstractCriteria(AbstractCriteria)

        public String GetStatus()
        {
            return this.Status;
        }//end GetStatus()

        public String GetDescription()
        {
            return this.Description;
        }//end GetDescription()

        public String GetDisplayOrder()
        {
            return this.DisplayOrder;
        }//end GetDisplayOrder()

        public String GetCriteriaType()
        {
            return this.Type;
        }//end GetType()

        /// <summary>
        /// Abstract method to add a Criteria to the tree
        /// </summary>
        /// <param name="Criteria"> The Criteria to add </param>
        public abstract void Add(AbstractCriteria Criteria);

        /// <summary>
        /// Template method to remove a Criteria from the tree
        /// </summary>
        /// <param name="Criteria"> The Criteria to remove </param>
        public abstract void Remove(AbstractCriteria Criteria);

        /// <summary>
        /// Template method to remove a Criteria at a specific position in the hosted list
        /// </summary>
        /// <param name="position"> The 0-based position from which to remove a Criteria </param>
        public abstract void RemoveAt(int position);


    }//end AbstractCriteria
}
