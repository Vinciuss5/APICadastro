using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using ApiCadastro.Services;
using ApiCadastro.Interfaces;
using ApiCadastro.Repository;
using ApiCadastro.Models;
using ApiCadastro.Data;

var builder = WebApplication.CreateBuilder(args);

// Adiciona controllers e Swagger
builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection"))
);

builder.Services.AddScoped<IDoadorService, DoadorService>();
builder.Services.AddScoped<IDoadorRepository, DoadorRepository>();

builder.Services.AddScoped<IBeneficiarioService, BeneficiarioService>();
builder.Services.AddScoped<IBeneficiarioRepository, BeneficiarioRepository>();

builder.Services.AddScoped<IProdutoService, ProdutoService>();
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();

builder.Services.AddScoped<ITipoProdutoService, TipoProdutoService>();
builder.Services.AddScoped<ITipoProdutoRepository, TipoProdutoRepository>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "API de Cadastro de Doações",
        Version = "v1",
        Description = "API para gerenciamento de doadores, beneficiários e roupas"
    });
});

// Configura CORS para permitir acesso do front-end (React)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy => policy
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod());
});

var app = builder.Build();

// Ativa Swagger em modo de desenvolvimento
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "API de Cadastro v1");
        c.RoutePrefix = string.Empty; // Swagger abre direto em localhost:5033
    });
}

// Ativa o CORS
app.UseCors("AllowAll");

// (não use HTTPS redirection pois sua API está em HTTP)
app.UseAuthorization();

app.MapControllers();

app.Run();
