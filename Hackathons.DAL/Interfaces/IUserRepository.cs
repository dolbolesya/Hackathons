using Hackathons.Domain.Users;

namespace Hackathons.DAL.Interfaces;

public interface IUserRepository : IBaseRepository<User>
{
     Task<User> GetByUsername(string username);
}