using Domain.Interfaces.Generics;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.IExpense
{
    public interface IExpense : IGeneric<Expense>
    {
        Task<List<Expense>> UserExpensesList ( string email );
        Task<List<Expense>> GetUnpaidExpensesList ( string email );
    }
}
