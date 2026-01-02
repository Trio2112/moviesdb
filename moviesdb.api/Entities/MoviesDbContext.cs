using Microsoft.EntityFrameworkCore;

namespace moviesdb.api.Entities
{
    public class MoviesDbContext : DbContext
    {
        public MoviesDbContext(DbContextOptions<MoviesDbContext> options)
            : base(options)
        {
        }

        public DbSet<MovieEntity> Movies { get; set; } = null!;
        public DbSet<ActorEntity> Actors { get; set; } = null!;
        public DbSet<MovieActorEntity> MovieActors { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("MoviesDB");
            base.OnModelCreating(modelBuilder);
        }
    }
}
