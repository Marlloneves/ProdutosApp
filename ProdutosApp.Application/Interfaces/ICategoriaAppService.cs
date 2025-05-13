using ProdutosApp.Application.Dtos.Responses;

namespace ProdutosApp.Application.Interfaces
{
    /// <summary>
    /// Inteface para serviçoes de aplicação de categoria
    /// </summary>
    public interface ICategoriaAppService
    {
        Task<List<CategoriaResponse>> ObterTodos();
    }
}
