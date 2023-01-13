using Hackathons.DAL.Interfaces;
using Hackathons.Domain.Users;

namespace Hackathons.DAL.Repositories;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _db;

    public UserRepository(ApplicationDbContext db)
    {
        _db = db;
    }
    
    public bool Create(User entity)
    {
        throw new NotImplementedException();
    }

    public User Get(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<User> Select()
    {
        throw new NotImplementedException();
    }

    public bool Delete(User entity)
    {
        throw new NotImplementedException();
    }

    public User GetByName(string name)
    {
        throw new NotImplementedException();
    }
}