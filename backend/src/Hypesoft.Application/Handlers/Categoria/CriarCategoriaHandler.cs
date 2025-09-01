using Hypesoft.Application.Commands.Categoria;
using Hypesoft.Application.DTOs;
using Hypesoft.Domain.Entities;
using Hypesoft.Domain.Repositories;
using MediatR;

namespace Hypesoft.Application.Handlers.Categoria;

public class CriarCategoriaHandler : IRequestHandler<CriarCategoriaCommand, CategoriaDto>
{
    private readonly ICategoriaRepository _categoriaRepository;

    public CriarCategoriaHandler(ICategoriaRepository categoriaRepository)
    {
        _categoriaRepository = categoriaRepository;
    }

    public async Task<CategoriaDto> Handle(CriarCategoriaCommand request, CancellationToken cancellationToken)
    {
        var categoria = new Categoria
        {
            Id = Guid.NewGuid(),
            Nome = request.Nome
        };
        await _categoriaRepository.AdicionarAsync(categoria);
        return new CategoriaDto { Id = categoria.Id, Nome = categoria.Nome };
    }
}
