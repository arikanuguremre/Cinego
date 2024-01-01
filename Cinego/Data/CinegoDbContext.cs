using Cinego.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Cinego.Data
{
	public class CinegoDbContext:IdentityDbContext<User>
	{
		public DbSet<Director> Directors { get; set; }
		public DbSet<Cinema> Cinemas { get; set; }
		public DbSet<Actor> Actors { get; set; }
		public DbSet<Movie> Movies { get; set; }
		public DbSet<Actor_Movie> Actors_Movies { get; set; }
	
		public CinegoDbContext(DbContextOptions<CinegoDbContext>options):base(options)
        {
            
        }

		

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//Many to Many rel.
			modelBuilder.Entity<Actor_Movie>().HasKey(am => new
			{
				am.ActorId,
				am.MovieId
			});
			modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.MovieId);
			modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actor).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.ActorId);




			base.OnModelCreating(modelBuilder);
		}
		
	}
}
