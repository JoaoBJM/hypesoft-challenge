using Hypesoft.Application.Commands.Produto;
using Hypesoft.Application.DTOs;
using Hypesoft.Domain.Entities;
using Hypesoft.Domain.Repositories;
using MediatR;

namespace Hypesoft.Application.Handlers.Produto;

public class CriarProdutoHandler : IRequestHandler<CriarProdutoCommand, ProdutoDto>
{
    private readonly IProdutoRepository _produtoRepository;
    private readonly ICategoriaRepository _categoriaRepository;

    public CriarProdutoHandler(IProdutoRepository produtoRepository, ICategoriaRepository categoriaRepository)
    {
        _produtoRepository = produtoRepository;
        _categoriaRepository = categoriaRepository;
    }

    public async Task<ProdutoDto> Handle(CriarProdutoCommand request, CancellationToken cancellationToken)
    {
        var categoria = await _categoriaRepository.ObterPorIdAsync(request.CategoriaId);
        if (categoria == null)
            throw new Exception("Categoria não encontrada");

        var produto = new Domain.Entities.Produto
        {
            Id = Guid.NewGuid(),
            Nome = request.Nome,
            Descricao = request.Descricao,
            Preco = request.Preco,
            CategoriaId = request.CategoriaId,
            QuantidadeEstoque = request.QuantidadeEstoque,
            Categoria = categoria
        };

        await _produtoRepository.AdicionarAsync(produto);

        return new ProdutoDto
        {
            Id = produto.Id,
            Nome = produto.Nome,
            Descricao = produto.Descricao,
            Preco = produto.Preco,
            CategoriaId = produto.CategoriaId,
            QuantidadeEstoque = produto.QuantidadeEstoque,
            CategoriaNome = categoria.Nome
        };
    }
}
