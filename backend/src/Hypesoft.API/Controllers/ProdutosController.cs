
using Hypesoft.Application.Commands.Produto;
using Hypesoft.Application.DTOs;
using Hypesoft.Application.Queries.Produto;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Hypesoft.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class ProdutosController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProdutosController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<ProdutoDto>> Listar()
        {
            return await _mediator.Send(new ListarProdutosQuery());
        }

        [HttpPost]
        public async Task<ActionResult<ProdutoDto>> Criar([FromBody] CriarProdutoCommand command)
        {
            var produto = await _mediator.Send(command);
            return CreatedAtAction(nameof(Listar), new { id = produto.Id }, produto);
        }
    }
}
