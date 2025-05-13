namespace ProdutosApp.Domain.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        #region Gerenciamento de transações
        Task SaveChangesAsync();
        void BeginTransaction();
        void Commit();
        void RollBack();
        #endregion
        #region Propriedades para acesso aos repositórios
        ICategoriaRepository CategoriaRepository { get; }
        IProdutoRepository ProdutoRepository { get; }
        #endregion
    }
}
