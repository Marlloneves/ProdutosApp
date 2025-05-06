namespace ProdutosApp.Domain.Entities
{
    /// <summary>
    /// Modelo de entidade de domínio para Categoria
    /// </summary>
    public class Categoria
    {
        #region Propriedades
        public Guid? Id { get; set; }
        public string? Nome { get; set; }
        public bool? Ativo { get; set; }
        #endregion

        #region Relacionamento
        public ICollection<Produto>? Produtos { get; set; }
        #endregion
    }
}
