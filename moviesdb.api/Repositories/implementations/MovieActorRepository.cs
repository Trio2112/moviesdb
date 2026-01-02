using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using moviesdb.api.Entities;
using moviesdb.api.Repositories.Interfaces;

namespace moviesdb.api.Repositories.Implementations
{
    public class MovieActorRepository : RepositoryBase<MovieActorEntity>, IMovieActorRepository
    {
        public MovieActorRepository(MoviesDbContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<MovieActorEntity>> GetAllAsync()
        {
            return await _context.Set<MovieActorEntity>()
                .Include(ma => ma.Movie)
                .Include(ma => ma.Actor)
                .AsNoTracking()
                .ToListAsync();
        }

        public override async Task<MovieActorEntity?> GetByIdAsync(Guid id)
        {
            return await _context.Set<MovieActorEntity>()
                .Include(ma => ma.Movie)
                .Include(ma => ma.Actor)
                .FirstOrDefaultAsync(ma => ma.MovieActorId == id);
        }
    }
}
