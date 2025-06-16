using PDV.Infrastructure.Interfaces;

namespace PDV.Infrastructure.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    public void Create(T obj)
    {
        throw new NotImplementedException();
    }

    public void Update(T obj)
    {
        throw new NotImplementedException();
    }

    public void Delete(T obj)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> GetAll()
    {
        throw new NotImplementedException();
    }

    public T GetById(int id)
    {
        throw new NotImplementedException();
    }

    public T GetByName(string nome)
    {
        throw new NotImplementedException();
    }
}