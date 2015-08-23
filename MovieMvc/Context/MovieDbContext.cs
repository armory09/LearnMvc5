using MovieMvc.Models;
using System.Data.Entity;

namespace MovieMvc.Context
{
    public class MovieDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}