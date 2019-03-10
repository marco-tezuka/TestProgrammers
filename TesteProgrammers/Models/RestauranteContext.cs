using Microsoft.EntityFrameworkCore;

namespace TesteProgrammers.Models
{
    public class RestauranteContext : DbContext
    {
        public RestauranteContext(DbContextOptions<RestauranteContext> options) : base(options)
        {
        }

        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Tamanho> Tamanhos { get; set; }
        public DbSet<Composicao> Composicoes { get; set; }
        public DbSet<Refeicao> Refeicoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Funcionario>().ToTable("Funcionario");            
            modelBuilder.Entity<Tamanho>().ToTable("Tamanho");
            modelBuilder.Entity<Composicao>().ToTable("Composicao");
            modelBuilder.Entity<Refeicao>().ToTable("Refeicao");
            modelBuilder.Query<RefeicaoCliente>();
        }
    }
}
