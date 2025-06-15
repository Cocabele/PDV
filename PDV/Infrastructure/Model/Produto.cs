using System.ComponentModel.DataAnnotations;

namespace PDV.Infrastructure.Model
{
    public class Produto
    {
       public int Id { get; set; }
       public string Nome { get; set; }
       public string Descricao { get; set; }
       public double Custo { get; set; }
    }
}
