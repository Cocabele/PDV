using Microsoft.EntityFrameworkCore;
using PDV.Data;
using PDV.Infrastructure.Interfaces;

namespace PDV.Infrastructure.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    protected readonly ApplicationDbContext _context;
    protected readonly DbSet<T> _dbSet;
    public Repository(ApplicationDbContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }
    // TODO: criar cadastro genérico
    public void Create(T obj)
    {
        throw new NotImplementedException();
    }
    // TODO: criar update genérico
    public void Update(T obj)
    {
        throw new NotImplementedException();
    }
    // TODO: criar delete genérico
    public void Delete(T obj)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> GetAll()
    {
        return _dbSet.ToList();
    }

    public T GetById(int id)
    {
        return  _dbSet.Find(id);
    }
    // TODO: criar busca por nome genérico
    public T GetByName(string nome)
    {
        throw new NotImplementedException();
    }
}