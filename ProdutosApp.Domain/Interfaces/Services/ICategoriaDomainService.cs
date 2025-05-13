using ProdutosApp.Domain.Entities;

namespace ProdutosApp.Domain.Interfaces.Services
{
    /// <summary>
    /// Inteface para operações de serviço
    /// </summary>
    public interface ICategoriaDomainService
    {
        Task<List<Categoria>> ObterTodos();
    }
}
