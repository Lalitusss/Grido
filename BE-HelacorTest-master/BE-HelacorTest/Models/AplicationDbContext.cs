using Microsoft.EntityFrameworkCore;
namespace BE_HelacorTest.Models
{
    public class AplicationDbContext: DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base(options)
        {

        }
        public DbSet<Repartos> Repartos { get; set; }
    }
}
