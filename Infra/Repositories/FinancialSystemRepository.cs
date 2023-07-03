using Domain.Interfaces.IFinancialSystem;
using Entities.Entities;
using Infra.Repositories.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class FinancialSystemRepository : GenericRepository<FinancialSystem>, IFinancialSystem
    {
        public Task<List<FinancialSystem>> GetUserFinancialSystemList ( string userEmail )
        {
            throw new NotImplementedException();
        }
    }
}
