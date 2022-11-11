using Microsoft.EntityFrameworkCore;

namespace GlobalSolution_Polaris.Models
{
    public class MulherApiDbContext : DbContext
    {
        public MulherApiDbContext(DbContextOptions<MulherApiDbContext> options) : base(options)
        {

        }

        public DbSet<Mulher> Mulheres { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Bairro> Bairros { get; set; }

        public DbSet<Cidade> Cidades { get; set; }

        public DbSet<Estado> Estados { get; set; }

    }
}
