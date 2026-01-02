using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using moviesdb.api.Entities;

namespace moviesdb.api.Repositories.Interfaces
{
    public interface IActorRepository
    {
        Task<IEnumerable<ActorEntity>> GetAllAsync();
        Task<ActorEntity?> GetByIdAsync(Guid id);
        Task AddAsync(ActorEntity actor);
        Task SaveChangesAsync();
    }
}
