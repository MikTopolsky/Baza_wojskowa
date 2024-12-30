using Baza_wojskowa.Models;
using Microsoft.EntityFrameworkCore;
namespace Filmy.Models
{
    public class FilmsDbContext : DbContext
    {
        public FilmsDbContext(DbContextOptions<FilmsDbContext> options) :
        base(options)
        {
        }
        public DbSet<Film> Films { get; set; }
    }
}
