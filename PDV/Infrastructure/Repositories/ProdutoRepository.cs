using PDV.Data;
using PDV.Infrastructure.Interfaces;
using PDV.Infrastructure.Model;

namespace PDV.Infrastructure.Repositories;

public class ProdutoRepository : Repository<Produto>
{
    public ProdutoRepository(ApplicationDbContext context) : base(context)
    {
    }
}