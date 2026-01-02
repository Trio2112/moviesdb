using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using moviesdb.api.Entities;
using moviesdb.api.Repositories.Interfaces;

namespace moviesdb.api.Repositories.Implementations
{
    public class MovieRepository : RepositoryBase<MovieEntity>, IMovieRepository
    {
        public MovieRepository(MoviesDbContext context) : base(context)
        {
        }

        // Use base implementations for common methods. Keep this class for movie-specific queries in future.
    }
}
