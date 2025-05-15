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

var app = builder.Build();

//Middlewares
app.UseMiddleware<ExceptionHandlingMiddleware>();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

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



