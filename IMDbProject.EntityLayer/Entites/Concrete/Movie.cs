using IMDbProject.EntityLayer.Entites.Abstract;
using IMDbProject.EntityLayer.Entites.Inferfaces;
using IMDbProject.EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDbProject.EntityLayer.Entites.Concrete
{
    [Table("Movie")]
    public class Movie : BaseEntity<int>,IBaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Required]
        public string MovieName { get; set; }
        [Required]
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        [Required]
        public DateTime ProductionDate { get; set; }
        [Required]
        [MinLength(10)]
        [MaxLength(100)]
        public string MovieReview { get; set; }

        public List<AssignedMovietoGenre> AssignedMovietoGenres { get; set; } //AssignedMovietoGenres ile Movie tablosu ile bire çok ilişki yapıldı.
        public List<AssignedMovietoDirector>  AssignedMovietoDirectors { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? PassivedDate { get; set ; }
        public Status Status { get; set; }
    }
}
