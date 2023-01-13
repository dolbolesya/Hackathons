namespace Hackathons.DAL.Interfaces;

public interface IBaseRepository<T>
{
    // CRUD

    bool Create(T entity);

    T Get(int id);

    IEnumerable<T> Select();

    bool Delete(T entity);
}