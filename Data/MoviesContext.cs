using Microsoft.EntityFrameworkCore;
using Mayvue_Tech_Test.Models;

namespace Mayvue_Tech_Test.Data
{
    public class MoviesContext : DbContext
    {
        public MoviesContext(DbContextOptions<MoviesContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
