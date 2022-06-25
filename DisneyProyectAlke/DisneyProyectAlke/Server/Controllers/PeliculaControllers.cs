using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DisneyProyectAlke.Shared.Date;
using DisneyProyectAlke.Shared.Date.Entidades;
using DisneyProyectAlke.Comunes.data;

namespace DisneyProyectAlke.Server.Controllers.DisneyControllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class PeliculaControllers : ControllerBase
    {
        private readonly dbcontext context;

        public PeliculaControllers(dbcontext context)
        {
            this.context = context;

        }

        [HttpGet]
        
        public async Task<IEnumerable<Movie>> GetAll()
        {
            List <Movie> peliculas = await context.pelicula.ToListAsync();
            

            List<Movie> Listado = new List<Movie>();

            foreach (Movie pelicula in peliculas)
            {
                Listado.Add(new Movie
                {
                    Titulo = pelicula.Titulo,
                    Imagen = pelicula.Imagen,
                    Fechacreacion = pelicula.Fechacreacion
                });
            }
            return Listado; 
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Movie>> Get(int id)
        {
            
            Movie peli = await context.pelicula.Where(x => x.Id == id).FirstOrDefaultAsync();
            
            if (peli == null)
            {
                return NotFound($"No existe el Personaje con id igual a {id}.");
            }
            return peli;
        }
        [HttpPost]
        public async Task<ActionResult<Movie>> PostAsync(Movie peli)
                                                                              
        {
            try
            {
                context.pelicula.Add(peli);
                await context.SaveChangesAsync();
                return peli;
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut("{id:int}")] 
        public async Task<ActionResult> Put(int id, [FromBody] Movie peli)
        {

            

            Movie peliserieencontrada = await context.pelicula.Where(x => x.Id == id).FirstOrDefaultAsync();
            
            if (peliserieencontrada == null)
            {
                return NotFound("no existe el estudiante a modificar.");
            }
            
            peliserieencontrada.Id = peli.Id;
            peliserieencontrada.Imagen = peli.Imagen;
            peliserieencontrada.Titulo = peli.Titulo;
            peliserieencontrada.Fechacreacion = peli.Fechacreacion;
            peliserieencontrada.calificacion = peli.calificacion;
            peliserieencontrada.PersonajeAsociado = peli.PersonajeAsociado;

            try
            {
                context.pelicula.Update(peliserieencontrada);
                await context.SaveChangesAsync();
                return Ok("Los datos han sido cambiados");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            
            if (id <= 0)
            {
                return BadRequest("No es correcto");
            }
            Movie peli = await context.pelicula.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (peli == null)
            {
                return NotFound($"No existe el personaje con id igual a {id}.");
            }
            
            try
            {
                context.pelicula.Remove(peli);
                await context.SaveChangesAsync();
                return Ok($"la pelicua o serie  {peli.Titulo} ha sido borrado.");
            }
            catch (Exception) 
            {
                return new StatusCodeResult(Microsoft.AspNetCore.Http.StatusCodes.Status500InternalServerError);
            }

        }

    } 
}
