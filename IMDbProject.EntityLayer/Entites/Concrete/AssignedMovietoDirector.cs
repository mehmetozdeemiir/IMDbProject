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
    [Table("AssignedMovietoDirector")]
    public class AssignedMovietoDirector : BaseEntity<int>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }
        //------------- MOVİE ----------------
        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }

        //-----------------APPUSER------------
        [ForeignKey("AppUser")]
        public int AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}
