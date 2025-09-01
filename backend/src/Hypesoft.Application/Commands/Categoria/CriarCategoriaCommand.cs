using MediatR;
using Hypesoft.Application.DTOs;

namespace Hypesoft.Application.Commands.Categoria;

public class CriarCategoriaCommand : IRequest<CategoriaDto>
{
    public string Nome { get; set; } = string.Empty;
}
