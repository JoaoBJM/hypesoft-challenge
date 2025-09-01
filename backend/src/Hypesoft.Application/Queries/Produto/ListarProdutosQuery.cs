using Hypesoft.Application.DTOs;
using MediatR;

namespace Hypesoft.Application.Queries.Produto;

public class ListarProdutosQuery : IRequest<IEnumerable<ProdutoDto>>
{
}
