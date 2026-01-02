using System;
using System.Collections.Generic;

namespace moviesdb.models.transport
{
    public record ChangeActor
    {
        public Guid Id { get; init; }
        public string ActorName { get; init; } = string.Empty;
        public IReadOnlyList<Guid> MovieIds { get; init; } = Array.Empty<Guid>();
    }
}
