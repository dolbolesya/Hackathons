using Hackathons.Domain.Users;

namespace Hackathons.DAL.Interfaces;

public interface IUserRepository : IBaseRepository<User>
{
    User GetByName(string name);
    
}