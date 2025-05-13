using ProdutosApp.Domain.Entities;
using ProdutosApp.Domain.Interfaces.Repositories;
using ProdutosApp.Domain.Interfaces.Services;

namespace ProdutosApp.Domain.Services
{
    /// <summary>
    /// Implementação dos serviços de domínio de categoria
    /// </summary>
    public class CategoriaDomainService(IUnitOfWork _unitOfWork) : ICategoriaDomainService
    {

        public async Task<List<Categoria>> ObterTodos()
        {
           return await _unitOfWork.CategoriaRepository.GetAllAsync();
        }
    }
}
