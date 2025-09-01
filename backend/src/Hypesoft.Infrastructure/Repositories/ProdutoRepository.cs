using Hypesoft.Domain.Entities;
using Hypesoft.Domain.Repositories;
using MongoDB.Driver;

namespace Hypesoft.Infrastructure.Repositories;

public class ProdutoRepository : IProdutoRepository
{
    private readonly IMongoCollection<Produto> _collection;

    public ProdutoRepository(IMongoDatabase database)
    {
        _collection = database.GetCollection<Produto>("produtos");
    }

    public async Task<IEnumerable<Produto>> ListarAsync()
    {
        return await _collection.Find(_ => true).ToListAsync();
    }

    public async Task<Produto?> ObterPorIdAsync(Guid id)
    {
        return await _collection.Find(p => p.Id == id).FirstOrDefaultAsync();
    }

    public async Task AdicionarAsync(Produto produto)
    {
        await _collection.InsertOneAsync(produto);
    }

    public async Task AtualizarAsync(Produto produto)
    {
        await _collection.ReplaceOneAsync(p => p.Id == produto.Id, produto);
    }

    public async Task RemoverAsync(Guid id)
    {
        await _collection.DeleteOneAsync(p => p.Id == id);
    }
}
