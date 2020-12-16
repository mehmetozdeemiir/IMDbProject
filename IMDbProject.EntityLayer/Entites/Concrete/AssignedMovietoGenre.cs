using IMDbProject.EntityLayer.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDbProject.EntityLayer.Entites.Concrete
{
    [Table("AssignedMovietoGenre")]
    public class AssignedMovietoGenre : BaseEntity<int>
    {
        // Bir Filmin birden fazla türü olabilir. Bir türünde birden fazla filmi olabileceği için çokça çok ilişkisi için AssignedMovietoGenre tablosuna ihtiyacımız vardır.
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        //---------- MOVİE---------------------
        [ForeignKey("Movie")]
        public int MovieId { get; set; }           //Çoka çok ilişki için Movie tablo ile ilişkilendirmek için Id ForeingKey olarak işaretlendi
        public virtual Movie Movie { get; set; }

        //-------------------GENRE--------------
        [ForeignKey("Genre")]
        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }
    }
}
