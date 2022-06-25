using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DisneyProyectAlke.Shared.Date.Entidades;
using DisneyProyectAlke.Shared.Date;
using DisneyProyectAlke.Comunes.data;

namespace DisneyProyectAlke.Server.Controllers.DisneyControllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class PersonajesControllers : ControllerBase
    {
        private readonly dbcontext context;

        public PersonajesControllers(dbcontext context)
        {
            this.context = context;
        }

       

        [HttpGet]
        
        public async Task<ActionResult<List<Character>>> GetAll(string Nombre, string Edad, string PeliculaSeries)
        {
            return await context.personajes.Include(x => x.pelicula).ToListAsync();
            
            
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Character>> Get(int id)
        {
            
            Character dibujo = await context.personajes.Where(x => x.Id == id).FirstOrDefaultAsync();
            
            if (dibujo == null)
            {
                return NotFound($"No existe el Personaje con id igual a {id}.");
            }
            return dibujo;
        }
        [HttpPost]


        
        public async Task<ActionResult<Character>> PostAsync(Character dibujo)
        {
            
            try
            {
                context.personajes.Add(dibujo);
                await context.SaveChangesAsync();
                return dibujo;
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut("{id:int}")] 
        public async Task<ActionResult> Put(int id, [FromBody] Character dibujo)
        {

            

            Character personajeencontrado = await context.personajes.Where(x => x.Id == id).FirstOrDefaultAsync();
            
            if (personajeencontrado == null)
            {
                return NotFound("no existe el estudiante a modificar.");
            }
            
            personajeencontrado.Imagen = dibujo.Imagen;
            personajeencontrado.Edad = dibujo.Edad;
            personajeencontrado.Historia = dibujo.Historia;
            personajeencontrado.Nombre = dibujo.Nombre;
            personajeencontrado.Peso = dibujo.Peso;
            personajeencontrado.PeliculasSeriesAsociadas = dibujo.PeliculasSeriesAsociadas;

            try
            {
                context.personajes.Update(personajeencontrado);
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
            Character dibujo = await context.personajes.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (dibujo == null)
            {
                return NotFound($"No existe el personaje con id igual a {id}.");
            }
            
            
            try
            {
                context.personajes.Remove(dibujo);
                await context.SaveChangesAsync();
                return Ok($"El estudiante {dibujo.Nombre} ha sido borrado.");
            }
            catch (Exception) 
            {
                return new StatusCodeResult(Microsoft.AspNetCore.Http.StatusCodes.Status500InternalServerError);
            }

        }

    }
}
