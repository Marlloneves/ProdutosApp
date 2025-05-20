using ProdutosApp.API.Extensions;
using ProdutosApp.API.Middlewares;
using ProdutosApp.Application.Extensions;
using ProdutosApp.Domain.Extensions;
using ProdutosApp.Infra.Data.Extensions;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();

//Registrando os serviços de injeção de dependência
builder.Services.AddEntityFramework(builder.Configuration);
builder.Services.AddApplicationServices();
builder.Services.AddDomainServices();

//Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Somente PRD
if (builder.Environment.IsProduction())
{
    builder.Configuration.AddAzureIdentity(builder.Configuration);
}

var app = builder.Build();

//Middlewares
app.UseMiddleware<ExceptionHandlingMiddleware>();

//Swagger
app.UseSwagger();
app.UseSwaggerUI();

//Scalar
app.MapScalarApiReference(options => {
    options.WithTheme(ScalarTheme.BluePlanet);
});

app.UseAuthorization();
app.MapControllers();
app.Run();



