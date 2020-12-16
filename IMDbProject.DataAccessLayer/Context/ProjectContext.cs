using IMDbProject.EntityLayer.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDbProject.DataAccessLayer.Context
{
   public class ProjectContext:DbContext
    {

        public ProjectContext()
        {
            Database.Connection.ConnectionString=@"Server=DESKTOP-2A32802\SQLEXPRESS01;Database=IMDBproject;Integrated Security=True;";
        }



        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AssignedMovietoDirector> AssignedMovietoDirector { get; set; }
        public DbSet<AssignedMovietoGenre> AssignedMovietoGenre { get; set; }
        public DbSet<Genre> Genders { get; set; }
        public DbSet<Movie> Movies { get; set; }



    }
}
