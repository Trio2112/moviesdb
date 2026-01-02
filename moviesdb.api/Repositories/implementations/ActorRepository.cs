using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using moviesdb.api.Entities;
using moviesdb.api.Repositories.Interfaces;

namespace moviesdb.api.Repositories.Implementations
{
    public class ActorRepository : RepositoryBase<ActorEntity>, IActorRepository
    {
        public ActorRepository(MoviesDbContext context) : base(context)
        {
        }

        // Actor-specific queries can be added here later.
    }
}
