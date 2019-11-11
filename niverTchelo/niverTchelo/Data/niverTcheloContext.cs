using Microsoft.EntityFrameworkCore;
using niverTchelo.Models;

namespace niverTchelo.Data
{
    public class niverTcheloContext : DbContext
    {
        public niverTcheloContext(DbContextOptions<niverTcheloContext> options) : base(options) { }
        public DbSet<Convidados> Convidados { get; set; }
    }
}
