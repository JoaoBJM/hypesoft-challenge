namespace Hypesoft.Application.DTOs;

public class ProdutoDto
{
    public Guid Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public decimal Preco { get; set; }
    public Guid CategoriaId { get; set; }
    public int QuantidadeEstoque { get; set; }
    public string? CategoriaNome { get; set; }
}
