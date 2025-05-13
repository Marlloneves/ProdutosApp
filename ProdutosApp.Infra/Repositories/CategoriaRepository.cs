using ProdutosApp.Domain.Entities;
using ProdutosApp.Domain.Interfaces.Repositories;
using ProdutosApp.Infra.Data.Contexts;
using ProdutosApp.Infra.Data.Repositories;

namespace ProdutosApp.Infra.Repositories
{
    /// <summary>
    /// Repositório de dados para categoria
    /// </summary>
    public class CategoriaRepository : BaseRepository<Categoria, Guid?>, ICategoriaRepository
    {
        public CategoriaRepository(DataContext dataContext)
            : base(dataContext)
        {
            
        }
    }
}
