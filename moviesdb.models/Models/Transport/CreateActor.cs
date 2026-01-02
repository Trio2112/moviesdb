using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace moviesdb.models.transport
{
    public record CreateActor
    {
        [Required]
        public string ActorName { get; init; } = string.Empty;

        // Link existing movies by id when creating an actor.
        public IReadOnlyList<Guid> MovieIds { get; init; } = Array.Empty<Guid>();
    }
}
