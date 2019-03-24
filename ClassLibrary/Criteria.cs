using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    /// <summary>
    /// The composite of the criteria tree
    /// </summary>
    public class Criteria : AbstractCriteria
    {
        List<AbstractCriteria> CriteriaList;

        public Criteria(String StatusIn, String DescriptionIn, String DisplayOrderIn, String TypeIn) : base(StatusIn, DescriptionIn, DisplayOrderIn, TypeIn)
        {

        }//end Criterion(String String String String) : Base (String String)

        #region Necessary Overrides
        public override void Add(AbstractCriteria Criteria)
        {
            CriteriaList.Add(Criteria);
        }//end Add(AbstractCriteria)

        public override void Remove(AbstractCriteria Criteria)
        {
            CriteriaList.Remove(Criteria);
        }//end Remove(AbstractCriteria)

        public override void RemoveAt(int position)
        {
            CriteriaList.RemoveAt(position);
        }//end RemoveAt(int)
        #endregion
    }//end Criteria
}
