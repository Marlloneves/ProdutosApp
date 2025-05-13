using ProdutosApp.Application.Dtos.Responses;
using ProdutosApp.Application.Interfaces;
using ProdutosApp.Domain.Interfaces.Services;

namespace ProdutosApp.Application.Services
{
    public class CategoriaAppService(ICategoriaDomainService _domainService) : ICategoriaAppService
    {
        public async Task<List<CategoriaResponse>> ObterTodos()
        {
            var categorias = await _domainService.ObterTodos();

            return categorias.Select(
                item => new CategoriaResponse
                {
                    Id = item.Id,
                    Nome = item.Nome,
                }
            ).ToList();
        }
    }
}
