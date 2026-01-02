using System;
using System.Collections.Generic;

namespace moviesdb.models
{
    public class Movie
    {
        public Guid Id { get; set; }

        public string MovieName { get; set; } = null!;

        public int Year { get; set; }

        // POCO navigation: list of actors in this movie
        public List<Actor> Actors { get; set; } = new List<Actor>();
    }
}
