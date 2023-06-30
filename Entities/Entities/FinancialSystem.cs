using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Entities
{
    [Table( "FinancialSystem" )]
    public class FinancialSystem : Base
    {
        public int Month { get; set; }
        public int Year { get; set; }
        public int ClosingDay { get; set; }
        public bool CreateADuplicateOfTheExpense { get; set; }
        public int CopyMonth { get; set; }
        public int CopyYear { get; set; }
    }
}
