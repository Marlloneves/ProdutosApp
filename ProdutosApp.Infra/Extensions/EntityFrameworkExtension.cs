using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProdutosApp.Domain.Interfaces.Repositories;
using ProdutosApp.Infra.Data.Contexts;
using ProdutosApp.Infra.Data.Repositories;

namespace ProdutosApp.Infra.Data.Extensions
{
    /// <summary>
    /// Classe de extensão para injeção de dependência do Entity Framework
    /// </summary>
    public static class EntityFrameworkExtension
    {
        /// <summary>
        /// Método de extensão para registrar o Entity Framework no serviço de injeção de dependência
        /// </summary>
        /// <returns></returns>
        public static IServiceCollection AddEntityFramework(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(options => 
                options.UseSqlServer(configuration.GetConnectionString("ProdutosAppBD")));

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
