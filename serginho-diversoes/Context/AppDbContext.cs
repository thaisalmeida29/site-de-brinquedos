using Microsoft.EntityFrameworkCore;
using serginho_diversoes.Models;

namespace serginho_diversoes.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Brinquedo> Brinquedos { get; set; }

    }
}
