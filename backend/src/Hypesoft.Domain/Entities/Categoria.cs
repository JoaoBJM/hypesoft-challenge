namespace Hypesoft.Domain.Entities;

public class Categoria
{
    public Guid Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public ICollection<Produto> Produtos { get; set; } = new List<Produto>();
}
