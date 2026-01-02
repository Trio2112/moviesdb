using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace moviesdb.api.Entities
{
    [Table("MOVIE", Schema = "MoviesDB")]
    public class MovieEntity
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }

        [Required]
        [Column("MOVIE_NAME")]
        [MaxLength(255)]
        public string MovieName { get; set; } = string.Empty;

        [Column("YEAR")]
        public int Year { get; set; }
    }
}
