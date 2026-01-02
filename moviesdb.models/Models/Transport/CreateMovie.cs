using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace moviesdb.models.transport
{
    public record CreateMovie
    {
        [Required]
        public string MovieName { get; init; } = string.Empty;

        [Range(1888, 2100)]
        public int Year { get; init; }

        // Link existing actors by id when creating a movie.
        public IReadOnlyList<Guid> ActorIds { get; init; } = Array.Empty<Guid>();
    }
}