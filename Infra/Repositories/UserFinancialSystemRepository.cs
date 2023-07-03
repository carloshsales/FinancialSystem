using Domain.Interfaces.IUser;
using Entities.Entities;
using Infra.Repositories.Generics;

namespace Infra.Repositories
{
    public class UserFinancialSystemRepository : GenericRepository<UserFinancialSystem>, IUserFinancialSystem
    {
        public Task<List<UserFinancialSystem>> GetListUsersFinancialSystem ( int idFinancialSystem )
        {
            throw new NotImplementedException();
        }

        public Task<UserFinancialSystem> GetUserFinancialSystemByEmail ( string email )
        {
            throw new NotImplementedException();
        }

        public Task RemoveUsers ( List<UserFinancialSystem> usersList )
        {
            throw new NotImplementedException();
        }
    }
}
