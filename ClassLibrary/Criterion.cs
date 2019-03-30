using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    /// <summary>
    /// The leaf of the Criteria tree structure
    /// </summary>
    public class Criterion : AbstractCriteria
    {

        public Criterion(String StatusIn, String DescriptionIn, String DisplayOrderIn, String TypeIn) : base(StatusIn, DescriptionIn, DisplayOrderIn, TypeIn)
        {

        }//end Criterion(String String String String) : Base (String String)

        #region Necessary Overrides
        public override void Add(AbstractCriteria Criteria)
        {
            throw new InvalidOperationException();
        }//end Add(AbstractCriteria)

        public override void Remove(AbstractCriteria Criteria)
        {
            throw new InvalidOperationException();
        }//end Remove(AbstractCriteria)

        public override void RemoveAt(int position)
        {
            throw new InvalidOperationException();
        }//end RemoveAt(int)
        #endregion
    }//end Criterion
}
