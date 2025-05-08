namespace ProdutosApp.Domain.Interfaces.Repositories
{
    /// <summary>
    /// Interface para repositório genérico
    /// </summary>
    public interface IBaseRepository<TEntity, TKey> 
        where TEntity : class
    {
        Task AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity?> GetByIdAsync(TKey id);
    }
}
