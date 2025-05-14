using ProdutosApp.Domain.Entities;

namespace ProdutosApp.Domain.Interfaces.Services
{
    /// <summary>
    /// Interface para operações de serviço de domínio de produto
    /// </summary>
    public interface IProdutoDomainService
    {
        Task Adicionar(Produto produto);
        Task Atualizar(Produto produto);
        Task<Produto> Inativar(Guid? id);
        Task<List<Produto>> ObterTodos();
        Task<Produto?> ObterPorId(Guid? id);
    }
}
