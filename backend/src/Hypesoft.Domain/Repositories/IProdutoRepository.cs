using Hypesoft.Domain.Entities;

namespace Hypesoft.Domain.Repositories;

public interface IProdutoRepository
{
    Task<IEnumerable<Produto>> ListarAsync();
    Task<Produto?> ObterPorIdAsync(Guid id);
    Task AdicionarAsync(Produto produto);
    Task AtualizarAsync(Produto produto);
    Task RemoverAsync(Guid id);
}
