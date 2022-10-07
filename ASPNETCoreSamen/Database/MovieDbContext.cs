using ASPNETCoreSamen.Domain;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCoreSamen.Database
{
	public class MovieDbContext : DbContext
	{
		public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
		{

		}

		public DbSet<Movie> Movies { get; set; }
	}
}
