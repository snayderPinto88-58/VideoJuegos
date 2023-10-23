using Microsoft.EntityFrameworkCore;
using usuarioVideojuego.Models;

namespace usuarioVideojuego.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<VideoJuegos> videoJuegos { get; set; }
    }
}
