using Hypesoft.Application.DTOs;
using MediatR;

namespace Hypesoft.Application.Queries.Categoria;

public class ListarCategoriasQuery : IRequest<IEnumerable<CategoriaDto>>
{
}
