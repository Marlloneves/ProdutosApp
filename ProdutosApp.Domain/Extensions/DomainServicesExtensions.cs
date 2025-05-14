using Microsoft.Extensions.DependencyInjection;
using ProdutosApp.Domain.Interfaces.Services;
using ProdutosApp.Domain.Services;

namespace ProdutosApp.Domain.Extensions
{
    /// <summary>
    /// Classe de extensão para configurar as injeções de dependência dos serviços de domínio
    /// </summary>
    public static class DomainServicesExtensions
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoriaDomainService, CategoriaDomainService>();
            services.AddScoped<IProdutoDomainService, ProdutoDomainService>();
            return services;
        }
    }
}
