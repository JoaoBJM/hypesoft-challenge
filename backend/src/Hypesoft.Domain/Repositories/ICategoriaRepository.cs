using Hypesoft.Domain.Entities;

namespace Hypesoft.Domain.Repositories;

public interface ICategoriaRepository
{
    Task<IEnumerable<Categoria>> ListarAsync();
    Task<Categoria?> ObterPorIdAsync(Guid id);
    Task AdicionarAsync(Categoria categoria);
    Task AtualizarAsync(Categoria categoria);
    Task RemoverAsync(Guid id);
}
