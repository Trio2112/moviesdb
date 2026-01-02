using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace moviesdb.api.Entities
{
    [Table("ACTOR", Schema = "MoviesDB")]
    public class ActorEntity
    {
        [Key]
        [Column("ACTOR_ID")]
        public Guid ActorId { get; set; }

        [Required]
        [Column("ACTOR_NAME")]
        [MaxLength(255)]
        public string ActorName { get; set; } = string.Empty;
    }
}
