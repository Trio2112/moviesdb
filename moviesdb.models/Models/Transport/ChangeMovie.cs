using System;
using System.Collections.Generic;

namespace moviesdb.models.transport
{
    public record ChangeMovie
    {
        public Guid Id { get; init; }
        public string MovieName { get; init; } = string.Empty;
        public int Year { get; init; }
        public IReadOnlyList<Guid> ActorIds { get; init; } = Array.Empty<Guid>();
    }
}
