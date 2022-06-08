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
    public class BD : DbContext
    {
        public DbSet<Medico> Medicos { get; set; }

        public BD()
        {

        }
        public BD(DbContextOptions options) : base(options)
        {
            
        }
    }
}
       




