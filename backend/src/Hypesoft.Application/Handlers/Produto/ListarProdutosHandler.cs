using Hypesoft.Application.DTOs;
using Hypesoft.Application.Queries.Produto;
using Hypesoft.Domain.Repositories;
using MediatR;

namespace Hypesoft.Application.Handlers.Produto;

public class ListarProdutosHandler : IRequestHandler<ListarProdutosQuery, IEnumerable<ProdutoDto>>
{
    private readonly IProdutoRepository _produtoRepository;
    private readonly ICategoriaRepository _categoriaRepository;

    public ListarProdutosHandler(IProdutoRepository produtoRepository, ICategoriaRepository categoriaRepository)
    {
        _produtoRepository = produtoRepository;
        _categoriaRepository = categoriaRepository;
    }

    public async Task<IEnumerable<ProdutoDto>> Handle(ListarProdutosQuery request, CancellationToken cancellationToken)
    {
        var produtos = await _produtoRepository.ListarAsync();
        var categorias = (await _categoriaRepository.ListarAsync()).ToDictionary(c => c.Id, c => c.Nome);

        return produtos.Select(p => new ProdutoDto
        {
            Id = p.Id,
            Nome = p.Nome,
            Descricao = p.Descricao,
            Preco = p.Preco,
            CategoriaId = p.CategoriaId,
            QuantidadeEstoque = p.QuantidadeEstoque,
            CategoriaNome = categorias.ContainsKey(p.CategoriaId) ? categorias[p.CategoriaId] : null
        });
    }
}
