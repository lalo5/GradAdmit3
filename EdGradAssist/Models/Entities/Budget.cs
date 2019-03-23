using System;
using System.Collections.Generic;

namespace EdGradAssist.Models.Entities
{
    public partial class Budget
    {
        public int BudgetId { get; set; }
        public DateTime? Year { get; set; }
        public int? Amount { get; set; }
    }
}
