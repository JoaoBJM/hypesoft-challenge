using Hypesoft.Application.DTOs;
using Hypesoft.Application.Queries.Categoria;
using Hypesoft.Domain.Repositories;
using MediatR;

namespace Hypesoft.Application.Handlers.Categoria;

public class ListarCategoriasHandler : IRequestHandler<ListarCategoriasQuery, IEnumerable<CategoriaDto>>
{
    private readonly ICategoriaRepository _categoriaRepository;

    public ListarCategoriasHandler(ICategoriaRepository categoriaRepository)
    {
        _categoriaRepository = categoriaRepository;
    }

    public async Task<IEnumerable<CategoriaDto>> Handle(ListarCategoriasQuery request, CancellationToken cancellationToken)
    {
        var categorias = await _categoriaRepository.ListarAsync();
        return categorias.Select(c => new CategoriaDto { Id = c.Id, Nome = c.Nome });
    }
}
