using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using moviesdb.api.Entities;

namespace moviesdb.api.Repositories.Interfaces
{
    public interface IMovieActorRepository
    {
        Task<IEnumerable<MovieActorEntity>> GetAllAsync();
        Task<MovieActorEntity?> GetByIdAsync(Guid id);
        Task AddAsync(MovieActorEntity movieActor);
        Task SaveChangesAsync();
    }
}
