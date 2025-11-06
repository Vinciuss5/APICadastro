using Microsoft.EntityFrameworkCore;
using ApiCadastro.Models;

namespace ApiCadastro.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Doador> Doadores { get; set; } = null!;
        public DbSet<Beneficiario> Beneficiarios { get; set; } = null!;
        public DbSet<Produto> Produtos { get; set; } = null!;
        public DbSet<TipoProduto> TiposProdutos { get; set; } = null!;
    }
}
