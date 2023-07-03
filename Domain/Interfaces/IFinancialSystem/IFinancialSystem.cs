using Domain.Interfaces.Generics;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.IFinancialSystem
{
    public interface IFinancialSystem : IGeneric<FinancialSystem>
    {
        Task<List<FinancialSystem>> GetUserFinancialSystemList ( string userEmail );
    }
}
