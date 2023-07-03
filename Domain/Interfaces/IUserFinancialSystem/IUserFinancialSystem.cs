using Domain.Interfaces.Generics;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.IUser
{
    public interface IUserFinancialSystem : IGeneric<UserFinancialSystem>
    {
        Task<List<UserFinancialSystem>> GetListUsersFinancialSystem ( int idFinancialSystem );
        Task RemoveUsers ( List<UserFinancialSystem> usersList );
        Task<UserFinancialSystem> GetUserFinancialSystemByEmail ( string email );
    }
}
