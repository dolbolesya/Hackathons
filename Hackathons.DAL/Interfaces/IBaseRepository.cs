namespace Hackathons.DAL.Interfaces;

public interface IBaseRepository<T>
{
    // CRUD

    Task<bool> Create(T entity);

    Task<T> Get(int id);

    Task<bool> Delete(T entity);

    Task<T> Update(T entity);
}