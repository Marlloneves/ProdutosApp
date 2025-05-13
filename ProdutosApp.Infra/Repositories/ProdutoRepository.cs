using ProdutosApp.Domain.Entities;
using ProdutosApp.Domain.Interfaces.Repositories;
using ProdutosApp.Infra.Data.Contexts;
using ProdutosApp.Infra.Data.Repositories;

namespace ProdutosApp.Infra.Repositories
{
    public class ProdutoRepository : BaseRepository<Produto, Guid?>, IProdutoRepository
    {
        public ProdutoRepository(DataContext dataContext)
            : base(dataContext)
        {
            
        }
    }
}
