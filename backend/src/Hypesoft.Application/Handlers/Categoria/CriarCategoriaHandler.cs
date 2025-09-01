using Hypesoft.Application.Commands.Categoria;
using Hypesoft.Application.DTOs;
using CategoriaEntity = Hypesoft.Domain.Entities.Categoria;
using Hypesoft.Domain.Repositories;
using MediatR;

namespace Hypesoft.Application.Handlers.CategoriaHandler;

public class CriarCategoriaHandler : IRequestHandler<CriarCategoriaCommand, CategoriaDto>
{
    private readonly ICategoriaRepository _categoriaRepository;

    public CriarCategoriaHandler(ICategoriaRepository categoriaRepository)
    {
        _categoriaRepository = categoriaRepository;
    }

    public async Task<CategoriaDto> Handle(CriarCategoriaCommand request, CancellationToken cancellationToken)
    {
    var categoria = new CategoriaEntity
        {
            Id = Guid.NewGuid(),
            Nome = request.Nome
        };
        await _categoriaRepository.AdicionarAsync(categoria);
        return new CategoriaDto { Id = categoria.Id, Nome = categoria.Nome };
    }
}
