using Microsoft.EntityFrameworkCore;

namespace KiyokAPI.Models
{
    public class KiyokDBContext : DbContext
    {
        public KiyokDBContext(DbContextOptions<KiyokDBContext> options) : base (options)
        {

        }
        public DbSet<Localidad> Localidad { get; set; }
        public DbSet<Provincia> Provincia { get; set; }
        public DbSet<Pais> Pais { get; set; }

    }
}
