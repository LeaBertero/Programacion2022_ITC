using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisneyProyectAlke.Shared.Date.Entidades
{
    [Index(nameof(Id), Name = "UQ_PeliculaSerie_Id", IsUnique = true)]
    public class Movie
    {
        public int Id { get; set; }
        public string Imagen { get; set; }

        [Required(ErrorMessage = "el titulo es obligatorio.")]
        [MaxLength(155, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "la fecha es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public int Fechacreacion { get; set; }

        [Required(ErrorMessage = "la calificacion es obligatorio.")]
        [MaxLength(2, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public int calificacion { get; set; }

        [Required(ErrorMessage = "el personaje es obligatorio.")]
        [MaxLength(155, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public string PersonajeAsociado { get; set; }

    }
}
