using Microsoft.Extensions.DependencyInjection;
using ProdutosApp.Application.Interfaces;
using ProdutosApp.Application.Services;

namespace ProdutosApp.Application.Extensions
{
    public static class ApplicationServicesExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services) 
        {
            services.AddScoped<ICategoriaAppService, CategoriaAppService>();

            return services;
        }
    }
}
