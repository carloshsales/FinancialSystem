using Domain.Interfaces.ICategory;
using Entities.Entities;
using Infra.Repositories.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategory
    {
        public Task<List<Category>> GetUserCategories ( string userEmail )
        {
            throw new NotImplementedException();
        }
    }
}
