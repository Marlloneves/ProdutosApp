namespace ProdutosApp.Application.Dtos.Requests
{
    /// <summary>
    /// Modelo de dados da resposta da aplicação para uma operação de produto
    /// </summary>
    public class ProdutoRequest
    {
        public string? Nome { get; set; }
        public decimal? Preco { get; set; }
        public int? Quantidade { get; set; }
        public Guid? CategoriaId { get; set; }

    }
}
