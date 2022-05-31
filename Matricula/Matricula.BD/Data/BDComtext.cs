using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Matricula.BD.Data.Entidades;

namespace Matricula.BD.Data
{

    //Representacion de la Base de datos
    public class BDComtext : DbContext
    {
        public DbSet<Medico> Medicos { get; set; }

        public BDComtext(DbContextOptions options) : base(options)
        {
            seguir con el segundo video 
        }
    }


}
