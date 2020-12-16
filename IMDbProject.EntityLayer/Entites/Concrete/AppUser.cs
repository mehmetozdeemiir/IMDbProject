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
    [Table("AppUser")] // Tablo ismi verildi
    public class AppUser : BaseEntity<int>,IBaseEntity
    {
        [Key] // PrimaryKey verildi.
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]// Idendity eklendi.
        public override int Id { get; set; } // BaseEntity'de abstract olarak tanımladığımız Id override edildi.

        [Required] //Boş geçilmemesini sağladık.
        [MaxLength(15)] // Karakter uzunluğunu maximum 15 karakter olarak verildi.
        [MinLength(3)] // Minimum karakter uzunluğu 3 verildi.
        public string FirstName { get; set; }
        [Required] 
        [MaxLength(20)] 
        [MinLength(3)] 
        public string LastName { get; set; }
        public string FullName => FirstName + " " + LastName;
        [Required]
        [MaxLength(10)]
        [MinLength(3)]
        public string UserName { get; set; }
        [Required]
        [MaxLength(20)]
        [MinLength(5)]
        public string Password { get; set; }
        public Role Role { get; set; } // Enum class'ından Role tipinde Role alındı.

        public List<AssignedMovietoDirector>  AssignedMovietoDirectors { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? PassivedDate { get; set; }
        public Status Status { get; set; }
    }
}
