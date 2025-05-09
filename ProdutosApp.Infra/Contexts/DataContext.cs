using Microsoft.EntityFrameworkCore;
using ProdutosApp.Infra.Data.Mappings;

namespace ProdutosApp.Infra.Data.Contexts
{
    /// <summary>
    /// Calsse de contexto para configuração do entity framework
    /// </summary>
    public class DataContext : DbContext
    {
        /// <summary>
        /// Construtor para injeção de dependencia
        /// </summary>
        /// <param name=""></param>
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }

        /// <summary>
        /// Método para adicionar as classes de mapeamento feitas no projeto
        /// </summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            modelBuilder.ApplyConfiguration(new CategoriaMap());
        }
    }
}
