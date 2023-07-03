using Domain.Interfaces.Generics;
using Entities.Entities;

namespace Domain.Interfaces.ICategory
{
    public interface ICategory : IGeneric<Category>
    {
        Task<List<Category>> GetUserCategories ( string userEmail );
    }
}
