using Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    [Table( "Expense" )]
    public class Expense : Base
    {
        public decimal Value { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public ExpenseTypeEnum ExpenseType { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime ModificationDate { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime DueDate { get; set; }
        public bool ItsPaid { get; set; }
        public bool OverdueExpense { get; set; }

        [ForeignKey( "FinancialSystem" )]
        [Column( Order = 1 )]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
