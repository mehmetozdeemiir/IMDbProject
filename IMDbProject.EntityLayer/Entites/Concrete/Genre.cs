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
    [Table("Genre")]
    public class Genre : BaseEntity<int>,IBaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }
        [Required]
        public string GenreName { get; set; }
        public List<AssignedMovietoGenre>  AssignedMovietoGenres { get; set; }
        public DateTime? CreateDate { get ; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? PassivedDate { get; set; }
        public Status Status { get; set; }
    }
}
