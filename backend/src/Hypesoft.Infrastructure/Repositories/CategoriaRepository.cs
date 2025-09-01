using Hypesoft.Domain.Entities;
using Hypesoft.Domain.Repositories;
using MongoDB.Driver;

namespace Hypesoft.Infrastructure.Repositories;

public class CategoriaRepository : ICategoriaRepository
{
    private readonly IMongoCollection<Categoria> _collection;

    public CategoriaRepository(IMongoDatabase database)
    {
        _collection = database.GetCollection<Categoria>("categorias");
    }

    public async Task<IEnumerable<Categoria>> ListarAsync()
    {
        return await _collection.Find(_ => true).ToListAsync();
    }

    public async Task<Categoria?> ObterPorIdAsync(Guid id)
    {
        return await _collection.Find(c => c.Id == id).FirstOrDefaultAsync();
    }

    public async Task AdicionarAsync(Categoria categoria)
    {
        await _collection.InsertOneAsync(categoria);
    }

    public async Task AtualizarAsync(Categoria categoria)
    {
        await _collection.ReplaceOneAsync(c => c.Id == categoria.Id, categoria);
    }

    public async Task RemoverAsync(Guid id)
    {
        await _collection.DeleteOneAsync(c => c.Id == id);
    }
}
