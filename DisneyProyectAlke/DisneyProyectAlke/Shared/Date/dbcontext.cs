using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DisneyProyectAlke.Shared.Date.Entidades;
using The_world_of_Disney.Comunes.data.database;

namespace DisneyProyectAlke.Comunes.data
{
    public class dbcontext : DbContext
    {
        public DbSet<Character> personajes { get; set; }
        public DbSet<Genero> generos { get; set; }
        public DbSet<Movie>pelicula { get; set; }
        public DbSet<User> usuarios { get; set; }
        public dbcontext(DbContextOptions<dbcontext> options)
           : base(options)
        {

        }
        
    }

}
