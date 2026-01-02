using System;
using System.Collections.Generic;

namespace moviesdb.models
{
    public class Actor
    {
        public Guid ActorId { get; set; }

        public string ActorName { get; set; } = null!;

        // POCO navigation: list of movies this actor appears in
        public List<Movie> Movies { get; set; } = new List<Movie>();
    }
}
