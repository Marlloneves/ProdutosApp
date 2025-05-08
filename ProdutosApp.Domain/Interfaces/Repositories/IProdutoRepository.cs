using ProdutosApp.Domain.Entities;

namespace ProdutosApp.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository : IBaseRepository<Produto, Guid?>
    {
    }
}
