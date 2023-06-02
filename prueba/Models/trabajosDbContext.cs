using Microsoft.EntityFrameworkCore;
using ProyectoTrabajos.Models;

namespace prueba.Models
{
    public class trabajosDbContext : DbContext
    {
        public trabajosDbContext(DbContextOptions<trabajosDbContext> options) : base(options)
        { }

        public DbSet<empresa> empresa { get; set; }
        public DbSet<testimonios> testimonios { get; set; }
        public DbSet<ofertas> ofertas { get; set; }
    }
}
