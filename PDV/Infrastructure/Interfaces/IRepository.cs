namespace PDV.Infrastructure.Interfaces;

public interface IRepository<T> where T : class
{
    void Create(T obj);
    void Update(T obj);
    void Delete(T obj);
    IEnumerable<T> GetAll();
    T GetById(int id);
    T GetByName(string nome);
    
}