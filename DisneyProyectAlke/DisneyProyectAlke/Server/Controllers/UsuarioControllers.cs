﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DisneyProyectAlke.Shared.Date;
using DisneyProyectAlke.Shared.Date.Entidades;
using DisneyProyectAlke.Comunes.data;
using The_world_of_Disney.Comunes.data.database;

namespace DisneyProyectAlke.Server.Controllers.DisneyControllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly dbcontext context;

        public UsuarioController(dbcontext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> Get()
        {
            return await context.usuarios.ToListAsync();
        }


        [HttpGet("{id:int}")]

        public async Task<ActionResult<User>> Get(int Id)
        {
            User personausuario = await context.usuarios.Where(x => x.Id == Id).FirstOrDefaultAsync();
            if (personausuario == null)
            {
                return NotFound($"No existe el usuario con id igual a {Id}.");
            }
            return personausuario;
        }

        [HttpPost("{id:int}")]

        public async Task<ActionResult<User>> PostAsync(User personausuario)
        {
            try
            {
                context.usuarios.Add(personausuario);
                await context.SaveChangesAsync();
                return personausuario;
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, [FromBody] User usuario)
        {
            User personausuario = await context.usuarios.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (personausuario == null)
            {
                return NotFound("no existe el usuario a modificar.");
            }
            personausuario.Username = personausuario.Username;
            personausuario.Email = personausuario.Email;
            personausuario.Pasword = personausuario.Pasword;
            personausuario.Lastname = personausuario.Lastname;
            
            try
            {
                context.usuarios.Remove(personausuario);
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
            User personausuarios = await context.usuarios.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (personausuarios == null)
            {
                return NotFound($"No existe el usuario con id igual a {id}.");
            }

            try
            {
                context.usuarios.Remove(personausuarios);
                await context.SaveChangesAsync();
                return Ok($"el usuario {personausuarios.Username} ha sido borrado.");
            }
            catch (Exception) 
            {
                return new StatusCodeResult(Microsoft.AspNetCore.Http.StatusCodes.Status500InternalServerError);
            }

        }


    }
}
