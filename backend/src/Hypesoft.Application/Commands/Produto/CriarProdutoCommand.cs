using MediatR;
using Hypesoft.Application.DTOs;

namespace Hypesoft.Application.Commands.Produto;

public class CriarProdutoCommand : IRequest<ProdutoDto>
{
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public decimal Preco { get; set; }
    public Guid CategoriaId { get; set; }
    public int QuantidadeEstoque { get; set; }
}
