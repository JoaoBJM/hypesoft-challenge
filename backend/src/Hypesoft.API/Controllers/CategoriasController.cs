
using Hypesoft.Application.Commands.Categoria;
using Hypesoft.Application.DTOs;
using Hypesoft.Application.Queries.Categoria;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Hypesoft.API.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class CategoriasController : ControllerBase
    {
    private readonly IMediator _mediator;

    public CategoriasController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IEnumerable<CategoriaDto>> Listar()
    {
        return await _mediator.Send(new ListarCategoriasQuery());
    }

    [HttpPost]
    public async Task<ActionResult<CategoriaDto>> Criar([FromBody] CriarCategoriaCommand command)
    {
        var categoria = await _mediator.Send(command);
        return CreatedAtAction(nameof(Listar), new { id = categoria.Id }, categoria);
    }
}
