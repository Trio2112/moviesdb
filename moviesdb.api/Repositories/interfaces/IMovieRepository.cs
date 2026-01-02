using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using moviesdb.api.Entities;

namespace moviesdb.api.Repositories.Interfaces
{
    public interface IMovieRepository
    {
        Task<IEnumerable<MovieEntity>> GetAllAsync();
        Task<MovieEntity?> GetByIdAsync(Guid id);
        Task AddAsync(MovieEntity movie);
        Task SaveChangesAsync();
    }
}
