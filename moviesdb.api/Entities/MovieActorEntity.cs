using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace moviesdb.api.Entities
{
    [Table("MOVIE_ACTOR", Schema = "MoviesDB")]
    public class MovieActorEntity
    {
        [Key]
        [Column("MOVIE_ACTOR_ID")]
        public Guid MovieActorId { get; set; }

        [Required]
        [Column("MOVIE_ID")]
        public Guid MovieId { get; set; }

        [Required]
        [Column("ACTOR_ID")]
        public Guid ActorId { get; set; }

        [ForeignKey(nameof(MovieId))]
        public MovieEntity? Movie { get; set; }

        [ForeignKey(nameof(ActorId))]
        public ActorEntity? Actor { get; set; }
    }
}
