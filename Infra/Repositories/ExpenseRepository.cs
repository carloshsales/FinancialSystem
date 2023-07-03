using Domain.Interfaces.IExpense;
using Entities.Entities;
using Infra.Repositories.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class ExpenseRepository : GenericRepository<Expense>, IExpense
    {
        public async Task<List<Expense>> GetUnpaidExpensesList ( string email )
        {
            throw new NotImplementedException();
        }

        public async Task<List<Expense>> UserExpensesList ( string email )
        {
            throw new NotImplementedException();
        }
    }
}
