using Microsoft.EntityFrameworkCore;
using ProdutosApp.Infra.Data.Contexts;

namespace ProdutosApp.Infra.Data.Tests.Contexts
{
    /// <summary>
    /// Classe para contexto e preparação dos teste
    /// </summary>
    public class TestContext
    {
        /// <summary>
        /// Método para configurar e retornar uma instância da classe DataContext
        /// </summary>
        public static DataContext CreateDataContext()
        {
            var options = new DbContextOptionsBuilder<DataContext>()
                    .UseInMemoryDatabase(databaseName: "ProdutosAppTest")
                    .Options;

            return new DataContext(options);
        }
    }
}
